namespace CourseWork_OOP
{
    partial class RegistrationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreate = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxConfirmPassword = new TextBox();
            label4 = new Label();
            checkBoxSeller = new CheckBox();
            checkBoxUser = new CheckBox();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(313, 272);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(173, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(313, 214);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(173, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(313, 185);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(173, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(313, 156);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(173, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 164);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 193);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 222);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(313, 243);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(173, 23);
            textBoxConfirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 251);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "confirm password";
            // 
            // checkBoxSeller
            // 
            checkBoxSeller.AutoSize = true;
            checkBoxSeller.Location = new Point(492, 272);
            checkBoxSeller.Name = "checkBoxSeller";
            checkBoxSeller.Size = new Size(54, 19);
            checkBoxSeller.TabIndex = 9;
            checkBoxSeller.Text = "Seller";
            checkBoxSeller.UseVisualStyleBackColor = true;
            // 
            // checkBoxUser
            // 
            checkBoxUser.AutoSize = true;
            checkBoxUser.Location = new Point(552, 272);
            checkBoxUser.Name = "checkBoxUser";
            checkBoxUser.Size = new Size(78, 19);
            checkBoxUser.TabIndex = 10;
            checkBoxUser.Text = "Customer";
            checkBoxUser.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxUser);
            Controls.Add(checkBoxSeller);
            Controls.Add(label4);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonCreate);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxConfirmPassword;
        private Label label4;
        private CheckBox checkBoxSeller;
        private CheckBox checkBoxUser;
    }
}