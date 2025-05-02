namespace CourseWork_OOP
{
    partial class ShopForm
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
            flowLayoutPanelContent = new FlowLayoutPanel();
            label3 = new Label();
            buttonSearch = new Button();
            textBoxMake = new TextBox();
            textBoxTo = new TextBox();
            textBoxFrom = new TextBox();
            panel1 = new Panel();
            label13 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonClearSearchSettings = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonSell = new Button();
            panel2 = new Panel();
            pictureBoxBacket = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxToYear = new TextBox();
            textBoxFromYear = new TextBox();
            label9 = new Label();
            comboBoxCountry = new ComboBox();
            label8 = new Label();
            comboBoxGear = new ComboBox();
            label7 = new Label();
            comboBoxCondition = new ComboBox();
            label6 = new Label();
            comboBoxType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            textBoxModel = new TextBox();
            textBoxColor = new TextBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBacket).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            flowLayoutPanelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelContent.BackColor = Color.FromArgb(33, 11, 97);
            flowLayoutPanelContent.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelContent.Location = new Point(0, 121);
            flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            flowLayoutPanelContent.Size = new Size(758, 330);
            flowLayoutPanelContent.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(730, 1);
            label3.Name = "label3";
            label3.Size = new Size(28, 29);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            buttonSearch.Location = new Point(15, 7);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(3, 21);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(102, 23);
            textBoxMake.TabIndex = 10;
            // 
            // textBoxTo
            // 
            textBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTo.Location = new Point(88, 44);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(76, 23);
            textBoxTo.TabIndex = 5;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFrom.Location = new Point(2, 44);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(80, 23);
            textBoxFrom.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTo);
            panel1.Controls.Add(textBoxFrom);
            panel1.Location = new Point(553, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 71);
            panel1.TabIndex = 12;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.LightGray;
            label13.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label13.Location = new Point(62, 7);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 9;
            label13.Text = "PRICE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label2.Location = new Point(88, 26);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "TO:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "FROM:";
            // 
            // buttonClearSearchSettings
            // 
            buttonClearSearchSettings.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            buttonClearSearchSettings.Location = new Point(96, 8);
            buttonClearSearchSettings.Name = "buttonClearSearchSettings";
            buttonClearSearchSettings.Size = new Size(140, 23);
            buttonClearSearchSettings.TabIndex = 13;
            buttonClearSearchSettings.Text = "Clear Search Settings";
            buttonClearSearchSettings.UseVisualStyleBackColor = true;
            buttonClearSearchSettings.Click += buttonClearSearchSettings_Click_1;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            buttonSell.Location = new Point(601, 4);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(75, 23);
            buttonSell.TabIndex = 15;
            buttonSell.Text = "UnLogin";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBoxBacket);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buttonSell);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(buttonClearSearchSettings);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 125);
            panel2.TabIndex = 16;
            // 
            // pictureBoxBacket
            // 
            pictureBoxBacket.Cursor = Cursors.Hand;
            pictureBoxBacket.Location = new Point(682, 4);
            pictureBoxBacket.Name = "pictureBoxBacket";
            pictureBoxBacket.Size = new Size(32, 26);
            pictureBoxBacket.TabIndex = 17;
            pictureBoxBacket.TabStop = false;
            pictureBoxBacket.Click += pictureBoxBacket_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBoxColor);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(comboBoxCountry);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBoxGear);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(comboBoxCondition);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBoxType);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxModel);
            panel3.Controls.Add(textBoxMake);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(12, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 92);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textBoxToYear);
            panel4.Controls.Add(textBoxFromYear);
            panel4.Location = new Point(385, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(166, 71);
            panel4.TabIndex = 13;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label10.Location = new Point(60, 8);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 9;
            label10.Text = "YEAR";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label11.Location = new Point(86, 27);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 7;
            label11.Text = "TO:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label12.Location = new Point(3, 27);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 6;
            label12.Text = "FROM:";
            // 
            // textBoxToYear
            // 
            textBoxToYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxToYear.Location = new Point(86, 45);
            textBoxToYear.Name = "textBoxToYear";
            textBoxToYear.Size = new Size(76, 23);
            textBoxToYear.TabIndex = 5;
            // 
            // textBoxFromYear
            // 
            textBoxFromYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFromYear.Location = new Point(3, 44);
            textBoxFromYear.Name = "textBoxFromYear";
            textBoxFromYear.Size = new Size(80, 23);
            textBoxFromYear.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label9.Location = new Point(287, 46);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 26;
            label9.Text = "Country";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(287, 61);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(92, 23);
            comboBoxCountry.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label8.Location = new Point(195, 46);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Gear";
            // 
            // comboBoxGear
            // 
            comboBoxGear.FormattingEnabled = true;
            comboBoxGear.Location = new Point(195, 61);
            comboBoxGear.Name = "comboBoxGear";
            comboBoxGear.Size = new Size(89, 23);
            comboBoxGear.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label7.Location = new Point(110, 46);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 22;
            label7.Text = "Condition";
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(110, 61);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(79, 23);
            comboBoxCondition.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label6.Location = new Point(3, 46);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Type";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(3, 61);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(102, 23);
            comboBoxType.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label5.Location = new Point(136, 4);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 18;
            label5.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 4);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Make";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(114, 21);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(97, 23);
            textBoxModel.TabIndex = 16;
            textBoxModel.TextChanged += textBoxModel_TextChanged;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(217, 20);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(82, 23);
            textBoxColor.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            label14.Location = new Point(217, 4);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 28;
            label14.Text = "Color";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(758, 451);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShopForm";
            Text = "ShopForm";
            Load += ShopForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBacket).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Button buttonSearch;
        private TextBox textBoxMake;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button buttonClearSearchSettings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button buttonSell;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBoxModel;
        private Label label5;
        private Label label4;
        private PictureBox pictureBoxBacket;
        private Label label9;
        private ComboBox comboBoxCountry;
        private Label label8;
        private ComboBox comboBoxGear;
        private Label label7;
        private ComboBox comboBoxCondition;
        private Label label6;
        private ComboBox comboBoxType;
        private Label label13;
        private Panel panel4;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxToYear;
        private TextBox textBoxFromYear;
        private Label label14;
        private TextBox textBoxColor;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}