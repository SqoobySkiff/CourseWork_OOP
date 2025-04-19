namespace CourseWork_OOP
{
    partial class CarPage
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
            label1 = new Label();
            labelMake = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelPrice = new Label();
            labelColor = new Label();
            pictureBoxImage = new PictureBox();
            buttonBuy = new Button();
            labelDescription = new Label();
            labelCondition = new Label();
            labelCountry = new Label();
            labelHP = new Label();
            labelGear = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(727, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 58);
            label1.TabIndex = 0;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelMake.ForeColor = SystemColors.ButtonFace;
            labelMake.Location = new Point(217, 44);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(82, 23);
            labelMake.TabIndex = 2;
            labelMake.Text = "label2";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelModel.ForeColor = SystemColors.ButtonFace;
            labelModel.Location = new Point(495, 44);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(82, 23);
            labelModel.TabIndex = 3;
            labelModel.Text = "label3";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelYear.ForeColor = SystemColors.ButtonFace;
            labelYear.Location = new Point(12, 92);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(82, 23);
            labelYear.TabIndex = 4;
            labelYear.Text = "label4";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelPrice.ForeColor = SystemColors.ButtonFace;
            labelPrice.Location = new Point(583, 235);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(82, 23);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "label5";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelColor.ForeColor = SystemColors.ButtonFace;
            labelColor.Location = new Point(12, 155);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(82, 23);
            labelColor.TabIndex = 6;
            labelColor.Text = "label2";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(217, 132);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(360, 188);
            pictureBoxImage.TabIndex = 7;
            pictureBoxImage.TabStop = false;
            // 
            // buttonBuy
            // 
            buttonBuy.Location = new Point(583, 261);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(112, 59);
            buttonBuy.TabIndex = 8;
            buttonBuy.Text = "Buy NOW !!!!";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelDescription.ForeColor = SystemColors.ButtonFace;
            labelDescription.Location = new Point(217, 333);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(82, 23);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "label2";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelCondition.ForeColor = SystemColors.ButtonFace;
            labelCondition.Location = new Point(12, 212);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(82, 23);
            labelCondition.TabIndex = 10;
            labelCondition.Text = "label2";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelCountry.ForeColor = SystemColors.ButtonFace;
            labelCountry.Location = new Point(12, 277);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(82, 23);
            labelCountry.TabIndex = 11;
            labelCountry.Text = "label2";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelHP.ForeColor = SystemColors.ButtonFace;
            labelHP.Location = new Point(287, 92);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(82, 23);
            labelHP.TabIndex = 12;
            labelHP.Text = "label2";
            // 
            // labelGear
            // 
            labelGear.AutoSize = true;
            labelGear.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            labelGear.ForeColor = SystemColors.ButtonFace;
            labelGear.Location = new Point(422, 92);
            labelGear.Name = "labelGear";
            labelGear.Size = new Size(82, 23);
            labelGear.TabIndex = 13;
            labelGear.Text = "label2";
            // 
            // CarPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 11, 97);
            ClientSize = new Size(800, 450);
            Controls.Add(labelGear);
            Controls.Add(labelHP);
            Controls.Add(labelCountry);
            Controls.Add(labelCondition);
            Controls.Add(labelDescription);
            Controls.Add(buttonBuy);
            Controls.Add(pictureBoxImage);
            Controls.Add(labelColor);
            Controls.Add(labelPrice);
            Controls.Add(labelYear);
            Controls.Add(labelModel);
            Controls.Add(labelMake);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarPage";
            Text = "CarPage";
            Load += CarPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelMake;
        private Label labelModel;
        private Label labelYear;
        private Label labelPrice;
        private Label labelColor;
        private PictureBox pictureBoxImage;
        private Button buttonBuy;
        private Label labelDescription;
        private Label labelCondition;
        private Label labelCountry;
        private Label labelHP;
        private Label labelGear;
    }
}