namespace CourseWork_OOP
{
    partial class SellForm
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
            button1 = new Button();
            textBoxMake = new TextBox();
            textBoxModel = new TextBox();
            textBoxYear = new TextBox();
            textBoxColor = new TextBox();
            textBoxPrice = new TextBox();
            checkBoxLightCars = new CheckBox();
            checkBoxSUV = new CheckBox();
            textBoxDescription = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(62, 79);
            button1.Name = "button1";
            button1.Size = new Size(135, 69);
            button1.TabIndex = 0;
            button1.Text = "Place on market";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxMake
            // 
            textBoxMake.BackColor = Color.FromArgb(224, 224, 224);
            textBoxMake.BorderStyle = BorderStyle.None;
            textBoxMake.Location = new Point(3, 17);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(225, 16);
            textBoxMake.TabIndex = 1;
            // 
            // textBoxModel
            // 
            textBoxModel.BackColor = Color.FromArgb(224, 224, 224);
            textBoxModel.BorderStyle = BorderStyle.None;
            textBoxModel.Location = new Point(3, 46);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(225, 16);
            textBoxModel.TabIndex = 2;
            // 
            // textBoxYear
            // 
            textBoxYear.BackColor = Color.FromArgb(224, 224, 224);
            textBoxYear.BorderStyle = BorderStyle.None;
            textBoxYear.Location = new Point(3, 74);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 16);
            textBoxYear.TabIndex = 3;
            // 
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.FromArgb(224, 224, 224);
            textBoxColor.BorderStyle = BorderStyle.None;
            textBoxColor.Location = new Point(3, 103);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 16);
            textBoxColor.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(224, 224, 224);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Location = new Point(3, 132);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 16);
            textBoxPrice.TabIndex = 5;
            // 
            // checkBoxLightCars
            // 
            checkBoxLightCars.AutoSize = true;
            checkBoxLightCars.Font = new Font("Unispace", 18F, FontStyle.Bold);
            checkBoxLightCars.ForeColor = SystemColors.ControlDark;
            checkBoxLightCars.Location = new Point(33, 41);
            checkBoxLightCars.Name = "checkBoxLightCars";
            checkBoxLightCars.Size = new Size(167, 33);
            checkBoxLightCars.TabIndex = 6;
            checkBoxLightCars.Text = "LightCars";
            checkBoxLightCars.UseVisualStyleBackColor = true;
            checkBoxLightCars.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxSUV
            // 
            checkBoxSUV.AutoSize = true;
            checkBoxSUV.Font = new Font("Unispace", 18F, FontStyle.Bold);
            checkBoxSUV.ForeColor = SystemColors.ControlDark;
            checkBoxSUV.Location = new Point(120, 3);
            checkBoxSUV.Name = "checkBoxSUV";
            checkBoxSUV.Size = new Size(77, 33);
            checkBoxSUV.TabIndex = 7;
            checkBoxSUV.Text = "SUV";
            checkBoxSUV.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = Color.FromArgb(224, 224, 224);
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Location = new Point(3, 218);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(496, 91);
            textBoxDescription.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(634, 58);
            label1.TabIndex = 9;
            label1.Text = "SELL YOUR CAR WITH US";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxMake);
            panel2.Controls.Add(textBoxModel);
            panel2.Controls.Add(textBoxYear);
            panel2.Controls.Add(textBoxDescription);
            panel2.Controls.Add(textBoxColor);
            panel2.Controls.Add(textBoxPrice);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 313);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(328, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(317, 8);
            label8.Name = "label8";
            label8.Size = new Size(238, 29);
            label8.TabIndex = 16;
            label8.Text = "Drag here photo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(167, 186);
            label7.Name = "label7";
            label7.Size = new Size(178, 29);
            label7.TabIndex = 14;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(109, 129);
            label6.Name = "label6";
            label6.Size = new Size(88, 29);
            label6.TabIndex = 13;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(109, 103);
            label5.Name = "label5";
            label5.Size = new Size(88, 29);
            label5.TabIndex = 12;
            label5.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(109, 72);
            label4.Name = "label4";
            label4.Size = new Size(73, 29);
            label4.TabIndex = 11;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(234, 40);
            label3.Name = "label3";
            label3.Size = new Size(88, 29);
            label3.TabIndex = 10;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(234, 11);
            label2.Name = "label2";
            label2.Size = new Size(73, 29);
            label2.TabIndex = 9;
            label2.Text = "Make";
            // 
            // panel3
            // 
            panel3.Controls.Add(checkBoxSUV);
            panel3.Controls.Add(checkBoxLightCars);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(588, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 152);
            panel3.TabIndex = 12;
            // 
            // SellForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 11, 97);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "SellForm";
            Text = "SellForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxMake;
        private TextBox textBoxModel;
        private TextBox textBoxYear;
        private TextBox textBoxColor;
        private TextBox textBoxPrice;
        private CheckBox checkBoxLightCars;
        private CheckBox checkBoxSUV;
        private TextBox textBoxDescription;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label8;
        private PictureBox pictureBox1;
    }
}