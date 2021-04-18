
namespace Group3_ClinicDB.UserControls
{
    partial class SearchUserControl
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
            this.dobSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.fnlnSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastNameSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.dobSearchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dobSearchButton = new System.Windows.Forms.Button();
            this.firstNameFnlnSearchLabel = new System.Windows.Forms.Label();
            this.firstNameFnlnSearchTextBox = new System.Windows.Forms.TextBox();
            this.lastNameFnlnSearchLabel = new System.Windows.Forms.Label();
            this.lastNameFnlnSearchTextBox = new System.Windows.Forms.TextBox();
            this.fnlnSearchButton = new System.Windows.Forms.Button();
            this.dobDoblnSearchLabel = new System.Windows.Forms.Label();
            this.dobDoblnSearchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doblnSearchButton = new System.Windows.Forms.Button();
            this.lastNameDoblnSearchLabel = new System.Windows.Forms.Label();
            this.lastNameDoblnSearchTextBox = new System.Windows.Forms.TextBox();
            this.firstNameFnlnErrorLabel = new System.Windows.Forms.Label();
            this.lastNameFnlnErrorLabel = new System.Windows.Forms.Label();
            this.lastNameDoblnErrorLabel = new System.Windows.Forms.Label();
            this.searchDobErrorLabel = new System.Windows.Forms.Label();
            this.searchFnlnErrorLabel = new System.Windows.Forms.Label();
            this.searchDoblnErrorLabel = new System.Windows.Forms.Label();
            this.ssnDobSearchLabel = new System.Windows.Forms.Label();
            this.ssnFnlnSearchTextBox = new System.Windows.Forms.TextBox();
            this.ssnFnlnSearchLabel = new System.Windows.Forms.Label();
            this.ssnDoblnSearchTextBox = new System.Windows.Forms.TextBox();
            this.ssnDoblnSearchLabel = new System.Windows.Forms.Label();
            this.ssnDobSearchTextBox = new System.Windows.Forms.TextBox();
            this.ssnDobErrorLabel = new System.Windows.Forms.Label();
            this.ssnFnlnErrorLabel = new System.Windows.Forms.Label();
            this.ssnDoblnErrorLabel = new System.Windows.Forms.Label();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.patientLoadedMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dobSearchRadioButton
            // 
            this.dobSearchRadioButton.AutoSize = true;
            this.dobSearchRadioButton.Location = new System.Drawing.Point(42, 26);
            this.dobSearchRadioButton.Name = "dobSearchRadioButton";
            this.dobSearchRadioButton.Size = new System.Drawing.Size(102, 17);
            this.dobSearchRadioButton.TabIndex = 0;
            this.dobSearchRadioButton.Text = "Search by DOB:";
            this.dobSearchRadioButton.UseVisualStyleBackColor = true;
            this.dobSearchRadioButton.CheckedChanged += new System.EventHandler(this.DobSearchRadioButtonCheckedChanged);
            // 
            // fnlnSearchRadioButton
            // 
            this.fnlnSearchRadioButton.AutoSize = true;
            this.fnlnSearchRadioButton.Location = new System.Drawing.Point(379, 26);
            this.fnlnSearchRadioButton.Name = "fnlnSearchRadioButton";
            this.fnlnSearchRadioButton.Size = new System.Drawing.Size(173, 17);
            this.fnlnSearchRadioButton.TabIndex = 3;
            this.fnlnSearchRadioButton.TabStop = true;
            this.fnlnSearchRadioButton.Text = "Search by First and Last Name:";
            this.fnlnSearchRadioButton.UseVisualStyleBackColor = true;
            this.fnlnSearchRadioButton.CheckedChanged += new System.EventHandler(this.FnlnSearchRadioButtonCheckedChanged);
            // 
            // dobLastNameSearchRadioButton
            // 
            this.dobLastNameSearchRadioButton.AutoSize = true;
            this.dobLastNameSearchRadioButton.Location = new System.Drawing.Point(703, 26);
            this.dobLastNameSearchRadioButton.Name = "dobLastNameSearchRadioButton";
            this.dobLastNameSearchRadioButton.Size = new System.Drawing.Size(177, 17);
            this.dobLastNameSearchRadioButton.TabIndex = 7;
            this.dobLastNameSearchRadioButton.TabStop = true;
            this.dobLastNameSearchRadioButton.Text = "Search by DOB and Last Name:";
            this.dobLastNameSearchRadioButton.UseVisualStyleBackColor = true;
            this.dobLastNameSearchRadioButton.CheckedChanged += new System.EventHandler(this.DobLastNameSearchRadioButtonCheckedChanged);
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Location = new System.Drawing.Point(39, 66);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(69, 13);
            this.dobSearchLabel.TabIndex = 4;
            this.dobSearchLabel.Text = "Date of Birth:";
            // 
            // dobSearchDateTimePicker
            // 
            this.dobSearchDateTimePicker.Location = new System.Drawing.Point(114, 66);
            this.dobSearchDateTimePicker.Name = "dobSearchDateTimePicker";
            this.dobSearchDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobSearchDateTimePicker.TabIndex = 1;
            this.dobSearchDateTimePicker.ValueChanged += new System.EventHandler(this.DobSearchDateTimePickerValueChanged);
            // 
            // dobSearchButton
            // 
            this.dobSearchButton.Location = new System.Drawing.Point(42, 164);
            this.dobSearchButton.Name = "dobSearchButton";
            this.dobSearchButton.Size = new System.Drawing.Size(75, 23);
            this.dobSearchButton.TabIndex = 2;
            this.dobSearchButton.Text = "Search";
            this.dobSearchButton.UseVisualStyleBackColor = true;
            this.dobSearchButton.Click += new System.EventHandler(this.DobSearchButtonClick);
            // 
            // firstNameFnlnSearchLabel
            // 
            this.firstNameFnlnSearchLabel.AutoSize = true;
            this.firstNameFnlnSearchLabel.Location = new System.Drawing.Point(376, 52);
            this.firstNameFnlnSearchLabel.Name = "firstNameFnlnSearchLabel";
            this.firstNameFnlnSearchLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameFnlnSearchLabel.TabIndex = 7;
            this.firstNameFnlnSearchLabel.Text = "First Name:";
            // 
            // firstNameFnlnSearchTextBox
            // 
            this.firstNameFnlnSearchTextBox.Location = new System.Drawing.Point(442, 49);
            this.firstNameFnlnSearchTextBox.Name = "firstNameFnlnSearchTextBox";
            this.firstNameFnlnSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameFnlnSearchTextBox.TabIndex = 4;
            this.firstNameFnlnSearchTextBox.TextChanged += new System.EventHandler(this.FirstNameFnlnSearchTextBoxTextChanged);
            // 
            // lastNameFnlnSearchLabel
            // 
            this.lastNameFnlnSearchLabel.AutoSize = true;
            this.lastNameFnlnSearchLabel.Location = new System.Drawing.Point(375, 89);
            this.lastNameFnlnSearchLabel.Name = "lastNameFnlnSearchLabel";
            this.lastNameFnlnSearchLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameFnlnSearchLabel.TabIndex = 9;
            this.lastNameFnlnSearchLabel.Text = "Last Name:";
            // 
            // lastNameFnlnSearchTextBox
            // 
            this.lastNameFnlnSearchTextBox.Location = new System.Drawing.Point(442, 86);
            this.lastNameFnlnSearchTextBox.Name = "lastNameFnlnSearchTextBox";
            this.lastNameFnlnSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameFnlnSearchTextBox.TabIndex = 5;
            this.lastNameFnlnSearchTextBox.TextChanged += new System.EventHandler(this.LastNameFnlnSearchTextBoxTextChanged);
            // 
            // fnlnSearchButton
            // 
            this.fnlnSearchButton.Location = new System.Drawing.Point(378, 164);
            this.fnlnSearchButton.Name = "fnlnSearchButton";
            this.fnlnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.fnlnSearchButton.TabIndex = 6;
            this.fnlnSearchButton.Text = "Search";
            this.fnlnSearchButton.UseVisualStyleBackColor = true;
            this.fnlnSearchButton.Click += new System.EventHandler(this.FnlnSearchButtonClick);
            // 
            // dobDoblnSearchLabel
            // 
            this.dobDoblnSearchLabel.AutoSize = true;
            this.dobDoblnSearchLabel.Location = new System.Drawing.Point(700, 49);
            this.dobDoblnSearchLabel.Name = "dobDoblnSearchLabel";
            this.dobDoblnSearchLabel.Size = new System.Drawing.Size(69, 13);
            this.dobDoblnSearchLabel.TabIndex = 12;
            this.dobDoblnSearchLabel.Text = "Date of Birth:";
            // 
            // dobDoblnSearchDateTimePicker
            // 
            this.dobDoblnSearchDateTimePicker.Location = new System.Drawing.Point(775, 49);
            this.dobDoblnSearchDateTimePicker.Name = "dobDoblnSearchDateTimePicker";
            this.dobDoblnSearchDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDoblnSearchDateTimePicker.TabIndex = 8;
            this.dobDoblnSearchDateTimePicker.ValueChanged += new System.EventHandler(this.DobDoblnSearchDateTimePickerValueChanged);
            // 
            // doblnSearchButton
            // 
            this.doblnSearchButton.Location = new System.Drawing.Point(703, 164);
            this.doblnSearchButton.Name = "doblnSearchButton";
            this.doblnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.doblnSearchButton.TabIndex = 10;
            this.doblnSearchButton.Text = "Search";
            this.doblnSearchButton.UseVisualStyleBackColor = true;
            this.doblnSearchButton.Click += new System.EventHandler(this.DoblnSearchButtonClick);
            // 
            // lastNameDoblnSearchLabel
            // 
            this.lastNameDoblnSearchLabel.AutoSize = true;
            this.lastNameDoblnSearchLabel.Location = new System.Drawing.Point(700, 86);
            this.lastNameDoblnSearchLabel.Name = "lastNameDoblnSearchLabel";
            this.lastNameDoblnSearchLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameDoblnSearchLabel.TabIndex = 15;
            this.lastNameDoblnSearchLabel.Text = "Last Name:";
            // 
            // lastNameDoblnSearchTextBox
            // 
            this.lastNameDoblnSearchTextBox.Location = new System.Drawing.Point(775, 86);
            this.lastNameDoblnSearchTextBox.Name = "lastNameDoblnSearchTextBox";
            this.lastNameDoblnSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameDoblnSearchTextBox.TabIndex = 9;
            this.lastNameDoblnSearchTextBox.TextChanged += new System.EventHandler(this.LastNameDoblnSearchTextBoxTextChanged);
            // 
            // firstNameFnlnErrorLabel
            // 
            this.firstNameFnlnErrorLabel.AutoSize = true;
            this.firstNameFnlnErrorLabel.Location = new System.Drawing.Point(450, 70);
            this.firstNameFnlnErrorLabel.Name = "firstNameFnlnErrorLabel";
            this.firstNameFnlnErrorLabel.Size = new System.Drawing.Size(139, 13);
            this.firstNameFnlnErrorLabel.TabIndex = 17;
            this.firstNameFnlnErrorLabel.Text = "First Name cannot be empty";
            this.firstNameFnlnErrorLabel.Visible = false;
            // 
            // lastNameFnlnErrorLabel
            // 
            this.lastNameFnlnErrorLabel.AutoSize = true;
            this.lastNameFnlnErrorLabel.Location = new System.Drawing.Point(453, 108);
            this.lastNameFnlnErrorLabel.Name = "lastNameFnlnErrorLabel";
            this.lastNameFnlnErrorLabel.Size = new System.Drawing.Size(140, 13);
            this.lastNameFnlnErrorLabel.TabIndex = 18;
            this.lastNameFnlnErrorLabel.Text = "Last Name cannot be empty";
            this.lastNameFnlnErrorLabel.Visible = false;
            // 
            // lastNameDoblnErrorLabel
            // 
            this.lastNameDoblnErrorLabel.AutoSize = true;
            this.lastNameDoblnErrorLabel.Location = new System.Drawing.Point(795, 108);
            this.lastNameDoblnErrorLabel.Name = "lastNameDoblnErrorLabel";
            this.lastNameDoblnErrorLabel.Size = new System.Drawing.Size(140, 13);
            this.lastNameDoblnErrorLabel.TabIndex = 19;
            this.lastNameDoblnErrorLabel.Text = "Last Name cannot be empty";
            this.lastNameDoblnErrorLabel.Visible = false;
            // 
            // searchDobErrorLabel
            // 
            this.searchDobErrorLabel.AutoSize = true;
            this.searchDobErrorLabel.Location = new System.Drawing.Point(39, 190);
            this.searchDobErrorLabel.Name = "searchDobErrorLabel";
            this.searchDobErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchDobErrorLabel.TabIndex = 20;
            this.searchDobErrorLabel.Visible = false;
            // 
            // searchFnlnErrorLabel
            // 
            this.searchFnlnErrorLabel.AutoSize = true;
            this.searchFnlnErrorLabel.Location = new System.Drawing.Point(376, 190);
            this.searchFnlnErrorLabel.Name = "searchFnlnErrorLabel";
            this.searchFnlnErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchFnlnErrorLabel.TabIndex = 21;
            this.searchFnlnErrorLabel.Visible = false;
            // 
            // searchDoblnErrorLabel
            // 
            this.searchDoblnErrorLabel.AutoSize = true;
            this.searchDoblnErrorLabel.Location = new System.Drawing.Point(700, 190);
            this.searchDoblnErrorLabel.Name = "searchDoblnErrorLabel";
            this.searchDoblnErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchDoblnErrorLabel.TabIndex = 22;
            this.searchDoblnErrorLabel.Visible = false;
            // 
            // ssnDobSearchLabel
            // 
            this.ssnDobSearchLabel.AutoSize = true;
            this.ssnDobSearchLabel.Location = new System.Drawing.Point(39, 106);
            this.ssnDobSearchLabel.Name = "ssnDobSearchLabel";
            this.ssnDobSearchLabel.Size = new System.Drawing.Size(32, 13);
            this.ssnDobSearchLabel.TabIndex = 23;
            this.ssnDobSearchLabel.Text = "SSN:";
            this.ssnDobSearchLabel.Visible = false;
            // 
            // ssnFnlnSearchTextBox
            // 
            this.ssnFnlnSearchTextBox.Location = new System.Drawing.Point(442, 125);
            this.ssnFnlnSearchTextBox.Name = "ssnFnlnSearchTextBox";
            this.ssnFnlnSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.ssnFnlnSearchTextBox.TabIndex = 25;
            this.ssnFnlnSearchTextBox.Visible = false;
            // 
            // ssnFnlnSearchLabel
            // 
            this.ssnFnlnSearchLabel.AutoSize = true;
            this.ssnFnlnSearchLabel.Location = new System.Drawing.Point(375, 125);
            this.ssnFnlnSearchLabel.Name = "ssnFnlnSearchLabel";
            this.ssnFnlnSearchLabel.Size = new System.Drawing.Size(32, 13);
            this.ssnFnlnSearchLabel.TabIndex = 26;
            this.ssnFnlnSearchLabel.Text = "SSN:";
            this.ssnFnlnSearchLabel.Visible = false;
            // 
            // ssnDoblnSearchTextBox
            // 
            this.ssnDoblnSearchTextBox.Location = new System.Drawing.Point(775, 125);
            this.ssnDoblnSearchTextBox.Name = "ssnDoblnSearchTextBox";
            this.ssnDoblnSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.ssnDoblnSearchTextBox.TabIndex = 27;
            this.ssnDoblnSearchTextBox.Visible = false;
            // 
            // ssnDoblnSearchLabel
            // 
            this.ssnDoblnSearchLabel.AutoSize = true;
            this.ssnDoblnSearchLabel.Location = new System.Drawing.Point(700, 125);
            this.ssnDoblnSearchLabel.Name = "ssnDoblnSearchLabel";
            this.ssnDoblnSearchLabel.Size = new System.Drawing.Size(32, 13);
            this.ssnDoblnSearchLabel.TabIndex = 28;
            this.ssnDoblnSearchLabel.Text = "SSN:";
            this.ssnDoblnSearchLabel.Visible = false;
            // 
            // ssnDobSearchTextBox
            // 
            this.ssnDobSearchTextBox.Location = new System.Drawing.Point(114, 105);
            this.ssnDobSearchTextBox.Name = "ssnDobSearchTextBox";
            this.ssnDobSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.ssnDobSearchTextBox.TabIndex = 29;
            this.ssnDobSearchTextBox.Visible = false;
            // 
            // ssnDobErrorLabel
            // 
            this.ssnDobErrorLabel.AutoSize = true;
            this.ssnDobErrorLabel.Location = new System.Drawing.Point(96, 129);
            this.ssnDobErrorLabel.Name = "ssnDobErrorLabel";
            this.ssnDobErrorLabel.Size = new System.Drawing.Size(262, 13);
            this.ssnDobErrorLabel.TabIndex = 30;
            this.ssnDobErrorLabel.Text = "Social security number must contain exactly nine digits";
            this.ssnDobErrorLabel.Visible = false;
            // 
            // ssnFnlnErrorLabel
            // 
            this.ssnFnlnErrorLabel.AutoSize = true;
            this.ssnFnlnErrorLabel.Location = new System.Drawing.Point(412, 148);
            this.ssnFnlnErrorLabel.Name = "ssnFnlnErrorLabel";
            this.ssnFnlnErrorLabel.Size = new System.Drawing.Size(262, 13);
            this.ssnFnlnErrorLabel.TabIndex = 31;
            this.ssnFnlnErrorLabel.Text = "Social security number must contain exactly nine digits";
            this.ssnFnlnErrorLabel.Visible = false;
            // 
            // ssnDoblnErrorLabel
            // 
            this.ssnDoblnErrorLabel.AutoSize = true;
            this.ssnDoblnErrorLabel.Location = new System.Drawing.Point(742, 148);
            this.ssnDoblnErrorLabel.Name = "ssnDoblnErrorLabel";
            this.ssnDoblnErrorLabel.Size = new System.Drawing.Size(262, 13);
            this.ssnDoblnErrorLabel.TabIndex = 32;
            this.ssnDoblnErrorLabel.Text = "Social security number must contain exactly nine digits";
            this.ssnDoblnErrorLabel.Visible = false;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(0, 206);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGridView.Size = new System.Drawing.Size(1195, 334);
            this.patientDataGridView.TabIndex = 33;
            this.patientDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientDataGridViewCellMouseClick);
            // 
            // patientLoadedMessage
            // 
            this.patientLoadedMessage.AutoSize = true;
            this.patientLoadedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLoadedMessage.Location = new System.Drawing.Point(552, 566);
            this.patientLoadedMessage.Name = "patientLoadedMessage";
            this.patientLoadedMessage.Size = new System.Drawing.Size(0, 20);
            this.patientLoadedMessage.TabIndex = 34;
            this.patientLoadedMessage.Visible = false;
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientLoadedMessage);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.ssnDoblnErrorLabel);
            this.Controls.Add(this.ssnFnlnErrorLabel);
            this.Controls.Add(this.ssnDobErrorLabel);
            this.Controls.Add(this.ssnDobSearchTextBox);
            this.Controls.Add(this.ssnDoblnSearchLabel);
            this.Controls.Add(this.ssnDoblnSearchTextBox);
            this.Controls.Add(this.ssnFnlnSearchLabel);
            this.Controls.Add(this.ssnFnlnSearchTextBox);
            this.Controls.Add(this.ssnDobSearchLabel);
            this.Controls.Add(this.searchDoblnErrorLabel);
            this.Controls.Add(this.searchFnlnErrorLabel);
            this.Controls.Add(this.searchDobErrorLabel);
            this.Controls.Add(this.lastNameDoblnErrorLabel);
            this.Controls.Add(this.lastNameFnlnErrorLabel);
            this.Controls.Add(this.firstNameFnlnErrorLabel);
            this.Controls.Add(this.lastNameDoblnSearchTextBox);
            this.Controls.Add(this.lastNameDoblnSearchLabel);
            this.Controls.Add(this.doblnSearchButton);
            this.Controls.Add(this.dobDoblnSearchDateTimePicker);
            this.Controls.Add(this.dobDoblnSearchLabel);
            this.Controls.Add(this.fnlnSearchButton);
            this.Controls.Add(this.lastNameFnlnSearchTextBox);
            this.Controls.Add(this.lastNameFnlnSearchLabel);
            this.Controls.Add(this.firstNameFnlnSearchTextBox);
            this.Controls.Add(this.firstNameFnlnSearchLabel);
            this.Controls.Add(this.dobSearchButton);
            this.Controls.Add(this.dobSearchDateTimePicker);
            this.Controls.Add(this.dobSearchLabel);
            this.Controls.Add(this.dobLastNameSearchRadioButton);
            this.Controls.Add(this.fnlnSearchRadioButton);
            this.Controls.Add(this.dobSearchRadioButton);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(1195, 586);
            this.Load += new System.EventHandler(this.SearchUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.SearchUserControlVisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dobSearchRadioButton;
        private System.Windows.Forms.RadioButton fnlnSearchRadioButton;
        private System.Windows.Forms.RadioButton dobLastNameSearchRadioButton;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.DateTimePicker dobSearchDateTimePicker;
        private System.Windows.Forms.Button dobSearchButton;
        private System.Windows.Forms.Label firstNameFnlnSearchLabel;
        private System.Windows.Forms.TextBox firstNameFnlnSearchTextBox;
        private System.Windows.Forms.Label lastNameFnlnSearchLabel;
        private System.Windows.Forms.TextBox lastNameFnlnSearchTextBox;
        private System.Windows.Forms.Button fnlnSearchButton;
        private System.Windows.Forms.Label dobDoblnSearchLabel;
        private System.Windows.Forms.DateTimePicker dobDoblnSearchDateTimePicker;
        private System.Windows.Forms.Button doblnSearchButton;
        private System.Windows.Forms.Label lastNameDoblnSearchLabel;
        private System.Windows.Forms.TextBox lastNameDoblnSearchTextBox;
        private System.Windows.Forms.Label firstNameFnlnErrorLabel;
        private System.Windows.Forms.Label lastNameFnlnErrorLabel;
        private System.Windows.Forms.Label lastNameDoblnErrorLabel;
        private System.Windows.Forms.Label searchDobErrorLabel;
        private System.Windows.Forms.Label searchFnlnErrorLabel;
        private System.Windows.Forms.Label searchDoblnErrorLabel;
        private System.Windows.Forms.Label ssnDobSearchLabel;
        private System.Windows.Forms.TextBox ssnFnlnSearchTextBox;
        private System.Windows.Forms.Label ssnFnlnSearchLabel;
        private System.Windows.Forms.TextBox ssnDoblnSearchTextBox;
        private System.Windows.Forms.Label ssnDoblnSearchLabel;
        private System.Windows.Forms.TextBox ssnDobSearchTextBox;
        private System.Windows.Forms.Label ssnDobErrorLabel;
        private System.Windows.Forms.Label ssnFnlnErrorLabel;
        private System.Windows.Forms.Label ssnDoblnErrorLabel;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Label patientLoadedMessage;
    }
}
