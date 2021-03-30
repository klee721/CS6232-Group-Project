
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search  Criteria:";
            // 
            // fnlnSearchRadioButton
            // 
            this.fnlnSearchRadioButton.AutoSize = true;
            this.fnlnSearchRadioButton.Location = new System.Drawing.Point(404, 26);
            this.fnlnSearchRadioButton.Name = "fnlnSearchRadioButton";
            this.fnlnSearchRadioButton.Size = new System.Drawing.Size(173, 17);
            this.fnlnSearchRadioButton.TabIndex = 2;
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
            this.dobLastNameSearchRadioButton.TabIndex = 3;
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
            this.dobSearchDateTimePicker.TabIndex = 5;
            // 
            // dobSearchButton
            // 
            this.dobSearchButton.Location = new System.Drawing.Point(42, 127);
            this.dobSearchButton.Name = "dobSearchButton";
            this.dobSearchButton.Size = new System.Drawing.Size(75, 23);
            this.dobSearchButton.TabIndex = 6;
            this.dobSearchButton.Text = "Search";
            this.dobSearchButton.UseVisualStyleBackColor = true;
            // 
            // firstNameFnlnSearchLabel
            // 
            this.firstNameFnlnSearchLabel.AutoSize = true;
            this.firstNameFnlnSearchLabel.Location = new System.Drawing.Point(401, 52);
            this.firstNameFnlnSearchLabel.Name = "firstNameFnlnSearchLabel";
            this.firstNameFnlnSearchLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameFnlnSearchLabel.TabIndex = 7;
            this.firstNameFnlnSearchLabel.Text = "First Name:";
            // 
            // firstNameFnlnSearchTextBox
            // 
            this.firstNameFnlnSearchTextBox.Location = new System.Drawing.Point(467, 49);
            this.firstNameFnlnSearchTextBox.Name = "firstNameFnlnSearchTextBox";
            this.firstNameFnlnSearchTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameFnlnSearchTextBox.TabIndex = 8;
            this.firstNameFnlnSearchTextBox.TextChanged += new System.EventHandler(this.FirstNameFnlnSearchTextBoxTextChanged);
            // 
            // lastNameFnlnSearchLabel
            // 
            this.lastNameFnlnSearchLabel.AutoSize = true;
            this.lastNameFnlnSearchLabel.Location = new System.Drawing.Point(400, 89);
            this.lastNameFnlnSearchLabel.Name = "lastNameFnlnSearchLabel";
            this.lastNameFnlnSearchLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameFnlnSearchLabel.TabIndex = 9;
            this.lastNameFnlnSearchLabel.Text = "Last Name:";
            // 
            // lastNameFnlnSearchTextBox
            // 
            this.lastNameFnlnSearchTextBox.Location = new System.Drawing.Point(467, 86);
            this.lastNameFnlnSearchTextBox.Name = "lastNameFnlnSearchTextBox";
            this.lastNameFnlnSearchTextBox.Size = new System.Drawing.Size(161, 20);
            this.lastNameFnlnSearchTextBox.TabIndex = 10;
            this.lastNameFnlnSearchTextBox.TextChanged += new System.EventHandler(this.LastNameFnlnSearchTextBoxTextChanged);
            // 
            // fnlnSearchButton
            // 
            this.fnlnSearchButton.Location = new System.Drawing.Point(403, 127);
            this.fnlnSearchButton.Name = "fnlnSearchButton";
            this.fnlnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.fnlnSearchButton.TabIndex = 11;
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
            this.dobDoblnSearchDateTimePicker.TabIndex = 13;
            // 
            // doblnSearchButton
            // 
            this.doblnSearchButton.Location = new System.Drawing.Point(703, 127);
            this.doblnSearchButton.Name = "doblnSearchButton";
            this.doblnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.doblnSearchButton.TabIndex = 14;
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
            this.lastNameDoblnSearchTextBox.TabIndex = 16;
            this.lastNameDoblnSearchTextBox.TextChanged += new System.EventHandler(this.LastNameDoblnSearchTextBoxTextChanged);
            // 
            // firstNameFnlnErrorLabel
            // 
            this.firstNameFnlnErrorLabel.AutoSize = true;
            this.firstNameFnlnErrorLabel.Location = new System.Drawing.Point(475, 70);
            this.firstNameFnlnErrorLabel.Name = "firstNameFnlnErrorLabel";
            this.firstNameFnlnErrorLabel.Size = new System.Drawing.Size(139, 13);
            this.firstNameFnlnErrorLabel.TabIndex = 17;
            this.firstNameFnlnErrorLabel.Text = "First Name cannot be empty";
            this.firstNameFnlnErrorLabel.Visible = false;
            // 
            // lastNameFnlnErrorLabel
            // 
            this.lastNameFnlnErrorLabel.AutoSize = true;
            this.lastNameFnlnErrorLabel.Location = new System.Drawing.Point(478, 108);
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
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dobSearchRadioButton);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(1025, 156);
            this.Load += new System.EventHandler(this.SearchUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.SearchUserControlVisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dobSearchRadioButton;
        private System.Windows.Forms.Label label1;
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
    }
}
