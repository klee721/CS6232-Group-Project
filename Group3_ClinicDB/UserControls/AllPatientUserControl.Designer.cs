
namespace Group3_ClinicDB.UserControls
{
    partial class AllPatientUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientListView = new System.Windows.Forms.ListView();
            this.patientIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address1ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address2ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipCodeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allPatientsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientIdColumnHeader,
            this.personIdColumnHeader,
            this.firstNameColumnHeader,
            this.lastNameColumnHeader,
            this.dateOfBirthColumnHeader,
            this.genderColumnHeader,
            this.ssnColumnHeader,
            this.address1ColumnHeader,
            this.address2ColumnHeader,
            this.cityColumnHeader,
            this.stateColumnHeader,
            this.zipCodeColumnHeader,
            this.phoneNumberColumnHeader});
            this.patientListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(0, 83);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(1215, 532);
            this.patientListView.TabIndex = 0;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            // 
            // patientIdColumnHeader
            // 
            this.patientIdColumnHeader.Text = "Patient ID";
            this.patientIdColumnHeader.Width = 64;
            // 
            // personIdColumnHeader
            // 
            this.personIdColumnHeader.Text = "Person ID";
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "First Name";
            this.firstNameColumnHeader.Width = 107;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Last Name";
            this.lastNameColumnHeader.Width = 118;
            // 
            // dateOfBirthColumnHeader
            // 
            this.dateOfBirthColumnHeader.Text = "Date of Birth";
            this.dateOfBirthColumnHeader.Width = 106;
            // 
            // genderColumnHeader
            // 
            this.genderColumnHeader.Text = "Gender";
            this.genderColumnHeader.Width = 91;
            // 
            // ssnColumnHeader
            // 
            this.ssnColumnHeader.Text = "SSN";
            this.ssnColumnHeader.Width = 103;
            // 
            // address1ColumnHeader
            // 
            this.address1ColumnHeader.Text = "Address 1";
            this.address1ColumnHeader.Width = 114;
            // 
            // address2ColumnHeader
            // 
            this.address2ColumnHeader.Text = "Address 2";
            this.address2ColumnHeader.Width = 71;
            // 
            // cityColumnHeader
            // 
            this.cityColumnHeader.Text = "City";
            this.cityColumnHeader.Width = 78;
            // 
            // stateColumnHeader
            // 
            this.stateColumnHeader.Text = "State";
            this.stateColumnHeader.Width = 57;
            // 
            // zipCodeColumnHeader
            // 
            this.zipCodeColumnHeader.Text = "Zip Code";
            this.zipCodeColumnHeader.Width = 96;
            // 
            // phoneNumberColumnHeader
            // 
            this.phoneNumberColumnHeader.Text = "Phone Number";
            this.phoneNumberColumnHeader.Width = 490;
            // 
            // allPatientsLabel
            // 
            this.allPatientsLabel.AutoSize = true;
            this.allPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPatientsLabel.Location = new System.Drawing.Point(46, 26);
            this.allPatientsLabel.Name = "allPatientsLabel";
            this.allPatientsLabel.Size = new System.Drawing.Size(306, 29);
            this.allPatientsLabel.TabIndex = 1;
            this.allPatientsLabel.Text = "Patients/Searched Patient";
            // 
            // AllPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allPatientsLabel);
            this.Controls.Add(this.patientListView);
            this.Name = "AllPatientUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.Load += new System.EventHandler(this.AllPatientUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.AllPatientUserControlVisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ColumnHeader patientIdColumnHeader;
        private System.Windows.Forms.ColumnHeader personIdColumnHeader;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader dateOfBirthColumnHeader;
        private System.Windows.Forms.ColumnHeader genderColumnHeader;
        private System.Windows.Forms.ColumnHeader ssnColumnHeader;
        private System.Windows.Forms.ColumnHeader address1ColumnHeader;
        private System.Windows.Forms.ColumnHeader address2ColumnHeader;
        private System.Windows.Forms.ColumnHeader cityColumnHeader;
        private System.Windows.Forms.ColumnHeader stateColumnHeader;
        private System.Windows.Forms.ColumnHeader zipCodeColumnHeader;
        private System.Windows.Forms.ColumnHeader phoneNumberColumnHeader;
        private System.Windows.Forms.Label allPatientsLabel;
    }
}
