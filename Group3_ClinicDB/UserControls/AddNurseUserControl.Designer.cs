
namespace Group3_ClinicDB.UserControls
{
    partial class AddNurseUserControl
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
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.registrationSuccessMessage = new System.Windows.Forms.Label();
            this.phoneNumberErrorLabel = new System.Windows.Forms.Label();
            this.zipCodeErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.address1ErrorLabel = new System.Windows.Forms.Label();
            this.ssnErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.registerNurseLabel = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.AutoSize = true;
            this.stateErrorLabel.Location = new System.Drawing.Point(979, 254);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(121, 13);
            this.stateErrorLabel.TabIndex = 57;
            this.stateErrorLabel.Text = "No State Data Available";
            this.stateErrorLabel.Visible = false;
            // 
            // registrationSuccessMessage
            // 
            this.registrationSuccessMessage.AutoSize = true;
            this.registrationSuccessMessage.Location = new System.Drawing.Point(717, 458);
            this.registrationSuccessMessage.Name = "registrationSuccessMessage";
            this.registrationSuccessMessage.Size = new System.Drawing.Size(121, 13);
            this.registrationSuccessMessage.TabIndex = 56;
            this.registrationSuccessMessage.Text = "Registration Successful!";
            this.registrationSuccessMessage.Visible = false;
            // 
            // phoneNumberErrorLabel
            // 
            this.phoneNumberErrorLabel.AutoSize = true;
            this.phoneNumberErrorLabel.Location = new System.Drawing.Point(713, 357);
            this.phoneNumberErrorLabel.Name = "phoneNumberErrorLabel";
            this.phoneNumberErrorLabel.Size = new System.Drawing.Size(220, 13);
            this.phoneNumberErrorLabel.TabIndex = 55;
            this.phoneNumberErrorLabel.Text = "Phone number must contain exactly ten digits";
            this.phoneNumberErrorLabel.Visible = false;
            // 
            // zipCodeErrorLabel
            // 
            this.zipCodeErrorLabel.AutoSize = true;
            this.zipCodeErrorLabel.Location = new System.Drawing.Point(715, 306);
            this.zipCodeErrorLabel.Name = "zipCodeErrorLabel";
            this.zipCodeErrorLabel.Size = new System.Drawing.Size(196, 13);
            this.zipCodeErrorLabel.TabIndex = 54;
            this.zipCodeErrorLabel.Text = "Zip Code must contain exactly five digits";
            this.zipCodeErrorLabel.Visible = false;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.Location = new System.Drawing.Point(716, 253);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.cityErrorLabel.TabIndex = 53;
            this.cityErrorLabel.Text = "City information missing";
            this.cityErrorLabel.Visible = false;
            // 
            // address1ErrorLabel
            // 
            this.address1ErrorLabel.AutoSize = true;
            this.address1ErrorLabel.Location = new System.Drawing.Point(716, 161);
            this.address1ErrorLabel.Name = "address1ErrorLabel";
            this.address1ErrorLabel.Size = new System.Drawing.Size(175, 13);
            this.address1ErrorLabel.TabIndex = 52;
            this.address1ErrorLabel.Text = "Street address 1 information missing";
            this.address1ErrorLabel.Visible = false;
            // 
            // ssnErrorLabel
            // 
            this.ssnErrorLabel.AutoSize = true;
            this.ssnErrorLabel.Location = new System.Drawing.Point(172, 341);
            this.ssnErrorLabel.Name = "ssnErrorLabel";
            this.ssnErrorLabel.Size = new System.Drawing.Size(262, 13);
            this.ssnErrorLabel.TabIndex = 51;
            this.ssnErrorLabel.Text = "Social security number must contain exactly nine digits";
            this.ssnErrorLabel.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(172, 155);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(146, 13);
            this.firstNameErrorLabel.TabIndex = 50;
            this.firstNameErrorLabel.Text = "First name information missing";
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(172, 204);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(147, 13);
            this.lastNameErrorLabel.TabIndex = 49;
            this.lastNameErrorLabel.Text = "Last name information missing";
            this.lastNameErrorLabel.Visible = false;
            // 
            // registerNurseLabel
            // 
            this.registerNurseLabel.AutoSize = true;
            this.registerNurseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNurseLabel.Location = new System.Drawing.Point(56, 60);
            this.registerNurseLabel.Name = "registerNurseLabel";
            this.registerNurseLabel.Size = new System.Drawing.Size(181, 29);
            this.registerNurseLabel.TabIndex = 48;
            this.registerNurseLabel.Text = "Register Nurse";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(717, 181);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(347, 20);
            this.address2TextBox.TabIndex = 34;
            this.address2TextBox.TextChanged += new System.EventHandler(this.address2TextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(716, 133);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(348, 20);
            this.addressTextBox.TabIndex = 33;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(175, 181);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.lastNameTextBox.TabIndex = 25;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(175, 132);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.firstNameTextBox.TabIndex = 24;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(175, 315);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(200, 20);
            this.ssnTextBox.TabIndex = 31;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.ssnTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(716, 334);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(181, 20);
            this.phoneNumberTextBox.TabIndex = 42;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(717, 283);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(130, 20);
            this.zipCodeTextBox.TabIndex = 41;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.zipCodeTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(717, 230);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(236, 20);
            this.cityTextBox.TabIndex = 37;
            this.cityTextBox.TabIndexChanged += new System.EventHandler(this.cityTextBox_TabIndexChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(1028, 229);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(75, 21);
            this.stateComboBox.TabIndex = 39;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(175, 271);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(103, 21);
            this.genderComboBox.TabIndex = 29;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(175, 229);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDateTimePicker.TabIndex = 26;
            this.dobDateTimePicker.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(589, 336);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(112, 18);
            this.phoneNumberLabel.TabIndex = 47;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(589, 286);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(72, 18);
            this.zipCodeLabel.TabIndex = 44;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(976, 232);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 18);
            this.stateLabel.TabIndex = 43;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(589, 232);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 18);
            this.cityLabel.TabIndex = 40;
            this.cityLabel.Text = "City:";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(589, 184);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(121, 18);
            this.address2Label.TabIndex = 38;
            this.address2Label.Text = "Street Address 2:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(589, 136);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(121, 18);
            this.address1Label.TabIndex = 36;
            this.address1Label.Text = "Street Address 1:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(58, 315);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(43, 18);
            this.ssnLabel.TabIndex = 35;
            this.ssnLabel.Text = "SSN:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(58, 274);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(61, 18);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "Gender:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(58, 232);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(94, 18);
            this.dateOfBirthLabel.TabIndex = 30;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(57, 132);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 18);
            this.firstNameLabel.TabIndex = 28;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(58, 181);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(926, 477);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 32);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(717, 477);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(180, 32);
            this.registerButton.TabIndex = 45;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // AddNurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.registrationSuccessMessage);
            this.Controls.Add(this.phoneNumberErrorLabel);
            this.Controls.Add(this.zipCodeErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.address1ErrorLabel);
            this.Controls.Add(this.ssnErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.registerNurseLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registerButton);
            this.MaximumSize = new System.Drawing.Size(1215, 615);
            this.MinimumSize = new System.Drawing.Size(1215, 615);
            this.Name = "AddNurseUserControl";
            this.Size = new System.Drawing.Size(1215, 615);
            this.Load += new System.EventHandler(this.AddNurseUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.AddNurseUserControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label registrationSuccessMessage;
        private System.Windows.Forms.Label phoneNumberErrorLabel;
        private System.Windows.Forms.Label zipCodeErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label address1ErrorLabel;
        private System.Windows.Forms.Label ssnErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label registerNurseLabel;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button registerButton;
    }
}
