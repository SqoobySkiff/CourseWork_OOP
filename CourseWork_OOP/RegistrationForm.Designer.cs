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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreate.Location = new Point(305, 265);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(173, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(305, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(173, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(305, 178);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(173, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(305, 149);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(173, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(240, 153);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(240, 182);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(211, 211);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(305, 236);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(173, 23);
            textBoxConfirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(131, 240);
            label4.Name = "label4";
            label4.Size = new Size(169, 19);
            label4.TabIndex = 8;
            label4.Text = "Confirm password";
            // 
            // checkBoxSeller
            // 
            checkBoxSeller.AutoSize = true;
            checkBoxSeller.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            checkBoxSeller.ForeColor = SystemColors.ButtonFace;
            checkBoxSeller.Location = new Point(484, 265);
            checkBoxSeller.Name = "checkBoxSeller";
            checkBoxSeller.Size = new Size(81, 22);
            checkBoxSeller.TabIndex = 9;
            checkBoxSeller.Text = "Seller";
            checkBoxSeller.UseVisualStyleBackColor = true;
            checkBoxSeller.CheckedChanged += checkBoxSeller_CheckedChanged;
            // 
            // checkBoxUser
            // 
            checkBoxUser.AutoSize = true;
            checkBoxUser.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            checkBoxUser.ForeColor = SystemColors.ButtonFace;
            checkBoxUser.Location = new Point(571, 265);
            checkBoxUser.Name = "checkBoxUser";
            checkBoxUser.Size = new Size(99, 22);
            checkBoxUser.TabIndex = 10;
            checkBoxUser.Text = "Customer";
            checkBoxUser.UseVisualStyleBackColor = true;
            checkBoxUser.CheckedChanged += checkBoxUser_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(checkBoxUser);
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(checkBoxSeller);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxConfirmPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 450);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(742, 9);
            label6.Name = "label6";
            label6.Size = new Size(46, 42);
            label6.TabIndex = 12;
            label6.Text = "←";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(160, 56);
            label5.Name = "label5";
            label5.Size = new Size(459, 42);
            label5.TabIndex = 11;
            label5.Text = "Register Your Account";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}