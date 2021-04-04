
namespace Group3_ClinicDB.UserControls
{
    partial class EditPatientUserControl
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.editPatientLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.updateSuccessMessage = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.ssnErrorLabel = new System.Windows.Forms.Label();
            this.address1ErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.zipCodeErrorLabel = new System.Windows.Forms.Label();
            this.phoneNumberErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(70, 203);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 18);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(70, 144);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(71, 266);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(94, 18);
            this.dateOfBirthLabel.TabIndex = 2;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(71, 322);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(61, 18);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(71, 376);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(43, 18);
            this.ssnLabel.TabIndex = 4;
            this.ssnLabel.Text = "SSN:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(558, 144);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(78, 18);
            this.address1Label.TabIndex = 5;
            this.address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(558, 203);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(78, 18);
            this.address2Label.TabIndex = 6;
            this.address2Label.Text = "Address 2:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(558, 262);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 18);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(940, 263);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 18);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(558, 318);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(72, 18);
            this.zipCodeLabel.TabIndex = 9;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(558, 372);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(112, 18);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 200);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.firstNameTextBox.TabIndex = 11;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBoxTextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(160, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.lastNameTextBox.TabIndex = 12;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBoxTextChanged);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(161, 374);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.ReadOnly = true;
            this.ssnTextBox.Size = new System.Drawing.Size(210, 20);
            this.ssnTextBox.TabIndex = 15;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.SsnTextBoxTextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(676, 141);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(210, 20);
            this.addressTextBox.TabIndex = 16;
            this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBoxTextChanged);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(676, 200);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(210, 20);
            this.address2TextBox.TabIndex = 17;
            this.address2TextBox.TextChanged += new System.EventHandler(this.Address2TextBoxTextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(676, 260);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(210, 20);
            this.cityTextBox.TabIndex = 18;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBoxTextChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(676, 316);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(210, 20);
            this.zipCodeTextBox.TabIndex = 20;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.ZipCodeTextBoxTextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(676, 372);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(210, 20);
            this.phoneNumberTextBox.TabIndex = 21;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBoxTextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(561, 455);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(180, 32);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(801, 455);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 32);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // editPatientLabel
            // 
            this.editPatientLabel.AutoSize = true;
            this.editPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatientLabel.Location = new System.Drawing.Point(74, 28);
            this.editPatientLabel.Name = "editPatientLabel";
            this.editPatientLabel.Size = new System.Drawing.Size(143, 29);
            this.editPatientLabel.TabIndex = 24;
            this.editPatientLabel.Text = "Edit Patient";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(161, 318);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(105, 21);
            this.genderComboBox.TabIndex = 25;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBoxSelectedIndexChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(992, 263);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(108, 21);
            this.stateComboBox.TabIndex = 26;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.StateComboBoxSelectedIndexChanged);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(162, 263);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDateTimePicker.TabIndex = 27;
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.AutoSize = true;
            this.stateErrorLabel.Location = new System.Drawing.Point(992, 291);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(121, 13);
            this.stateErrorLabel.TabIndex = 28;
            this.stateErrorLabel.Text = "No State Data Available";
            this.stateErrorLabel.Visible = false;
            // 
            // updateSuccessMessage
            // 
            this.updateSuccessMessage.AutoSize = true;
            this.updateSuccessMessage.Location = new System.Drawing.Point(561, 439);
            this.updateSuccessMessage.Name = "updateSuccessMessage";
            this.updateSuccessMessage.Size = new System.Drawing.Size(100, 13);
            this.updateSuccessMessage.TabIndex = 29;
            this.updateSuccessMessage.Text = "Update Successful!";
            this.updateSuccessMessage.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(161, 227);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(146, 13);
            this.firstNameErrorLabel.TabIndex = 30;
            this.firstNameErrorLabel.Text = "First name information missing";
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(160, 168);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(147, 13);
            this.lastNameErrorLabel.TabIndex = 31;
            this.lastNameErrorLabel.Text = "Last name information missing";
            this.lastNameErrorLabel.Visible = false;
            // 
            // ssnErrorLabel
            // 
            this.ssnErrorLabel.AutoSize = true;
            this.ssnErrorLabel.Location = new System.Drawing.Point(161, 397);
            this.ssnErrorLabel.Name = "ssnErrorLabel";
            this.ssnErrorLabel.Size = new System.Drawing.Size(262, 13);
            this.ssnErrorLabel.TabIndex = 32;
            this.ssnErrorLabel.Text = "Social security number must contain exactly nine digits";
            this.ssnErrorLabel.Visible = false;
            // 
            // address1ErrorLabel
            // 
            this.address1ErrorLabel.AutoSize = true;
            this.address1ErrorLabel.Location = new System.Drawing.Point(676, 164);
            this.address1ErrorLabel.Name = "address1ErrorLabel";
            this.address1ErrorLabel.Size = new System.Drawing.Size(175, 13);
            this.address1ErrorLabel.TabIndex = 33;
            this.address1ErrorLabel.Text = "Street address 1 information missing";
            this.address1ErrorLabel.Visible = false;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.Location = new System.Drawing.Point(676, 283);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.cityErrorLabel.TabIndex = 34;
            this.cityErrorLabel.Text = "City information missing";
            this.cityErrorLabel.Visible = false;
            // 
            // zipCodeErrorLabel
            // 
            this.zipCodeErrorLabel.AutoSize = true;
            this.zipCodeErrorLabel.Location = new System.Drawing.Point(676, 343);
            this.zipCodeErrorLabel.Name = "zipCodeErrorLabel";
            this.zipCodeErrorLabel.Size = new System.Drawing.Size(196, 13);
            this.zipCodeErrorLabel.TabIndex = 35;
            this.zipCodeErrorLabel.Text = "Zip Code must contain exactly five digits";
            this.zipCodeErrorLabel.Visible = false;
            // 
            // phoneNumberErrorLabel
            // 
            this.phoneNumberErrorLabel.AutoSize = true;
            this.phoneNumberErrorLabel.Location = new System.Drawing.Point(679, 399);
            this.phoneNumberErrorLabel.Name = "phoneNumberErrorLabel";
            this.phoneNumberErrorLabel.Size = new System.Drawing.Size(220, 13);
            this.phoneNumberErrorLabel.TabIndex = 36;
            this.phoneNumberErrorLabel.Text = "Phone number must contain exactly ten digits";
            this.phoneNumberErrorLabel.Visible = false;
            // 
            // EditPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phoneNumberErrorLabel);
            this.Controls.Add(this.zipCodeErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.address1ErrorLabel);
            this.Controls.Add(this.ssnErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.updateSuccessMessage);
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.editPatientLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "EditPatientUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.Load += new System.EventHandler(this.EditPatientUserControlLoad);
            this.VisibleChanged += new System.EventHandler(this.EditPatientUserControlVisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label editPatientLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label updateSuccessMessage;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label ssnErrorLabel;
        private System.Windows.Forms.Label address1ErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label zipCodeErrorLabel;
        private System.Windows.Forms.Label phoneNumberErrorLabel;
    }
}
