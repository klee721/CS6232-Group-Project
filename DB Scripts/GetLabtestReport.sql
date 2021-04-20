CREATE PROCEDURE GetLabtestReport   
    @FromDate Datetime,   
    @ToDate Datetime   
AS   
BEGIn

    SET NOCOUNT ON;  
	select 
  test.testCode, 
  test.Name,
  stat.qualified_test_counts,
  stat.total_tests,
  (stat.qualified_test_counts*100/stat.total_tests) total_pct,
  stat.normal_count,
  stat.Abnormal_count,
  convert(decimal(4,2),(((convert(decimal(4,2),stat.counts_19_29)) * 100 /stat.total_tests)))  pct_19_29,
   convert(decimal(4,2),((convert(decimal(4,2),stat.counts_30_39)) * 100 /stat.total_tests)) pct_30_39,
  (100 - ( convert(decimal(4,2),(((convert(decimal(4,2),stat.counts_19_29)) * 100 /stat.total_tests)))) - (convert(decimal(4,2),((convert(decimal(4,2),stat.counts_30_39)) * 100 /stat.total_tests)))) other_age_pct
  from (
  select t.testcode, t.qualified_test_counts,total_tests,l.normal_count,ln.Abnormal_count, ISNULL(age19_29_count,0) counts_19_29, ISNULL(age30_39_count,0) counts_30_39 from  
  (SELECT testCode,
  count(visit_id) as qualified_test_counts
  FROM labtests labs where performedDateTime is not null
  and performedDateTime >= @FromDate and performedDateTime <= @ToDate
  group by testCode having count(visit_id) >1) t
  join (select testCode,count(*) normal_count from labtests l where l.performedDateTime >= @FromDate and l.performedDateTime <= @ToDate and normal = 'Y' group by testCode) l on l.testCode = t.testcode 
  join (select testCode,count(*) Abnormal_count from labtests l where l.performedDateTime >= @FromDate and l.performedDateTime <= @ToDate and normal = 'N' group by testCode) ln on ln.testCode = t.testcode 
  join (select count(*) total_tests from labtests l where l.performedDateTime >= @FromDate and l.performedDateTime <= @ToDate) c on (1=1)
  join ( select testcode,count(*) age19_29_count from labtests l
  join patients p on (p.Id = l.patientId) 
  join persons s on (s.id = p.persons_id)
  where l.performedDateTime >= @FromDate and l.performedDateTime <= @ToDate and DATEDIFF(YY,s.dateOfBirth,GETDATE()) > = 19 and DATEDIFF(YY,s.dateOfBirth,GETDATE()) < = 29
  group by testCode) t28 on (t28.testCode = t.testCode)
  left join ( select testcode,count(*) age30_39_count from labtests l
  left join patients p on (p.Id = l.patientId) 
  join persons s on (s.id = p.persons_id)
  where l.performedDateTime >= @FromDate and l.performedDateTime <= @ToDate and DATEDIFF(YY,s.dateOfBirth,GETDATE()) > = 30 and DATEDIFF(YY,s.dateOfBirth,GETDATE()) < = 39
  group by testCode) t30 on (t30.testCode = t.testCode)) stat 
  join tests test on (test.testCode = stat.testCode)
  order by stat.qualified_test_counts desc, test.testCode desc;
 END