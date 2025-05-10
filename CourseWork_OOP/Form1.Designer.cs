namespace CourseWork_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCreateAccount = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonCreateAccount);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 450);
            panel1.TabIndex = 0;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            buttonCreateAccount.Location = new Point(117, 378);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(127, 23);
            buttonCreateAccount.TabIndex = 9;
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(53, 61);
            label6.Name = "label6";
            label6.Size = new Size(257, 58);
            label6.TabIndex = 2;
            label6.Text = "Car Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_car_repair_logo_in_line_art_style_with_gears_png_image_5821463;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(760, 9);
            exit.Name = "exit";
            exit.Size = new Size(28, 29);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(395, 62);
            label2.Name = "label2";
            label2.Size = new Size(291, 42);
            label2.TabIndex = 2;
            label2.Text = "Login account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(395, 165);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Location = new Point(395, 191);
            login_username.Name = "login_username";
            login_username.Size = new Size(291, 23);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Location = new Point(395, 280);
            login_password.Name = "login_password";
            login_password.Size = new Size(291, 23);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(395, 254);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 11, 97);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(395, 359);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(150, 52);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private Button login_btn;
        private Label label6;
        private PictureBox pictureBox1;
        private Button buttonCreateAccount;
    }
}
