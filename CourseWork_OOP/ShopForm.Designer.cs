﻿namespace CourseWork_OOP
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
            label2 = new Label();
            label1 = new Label();
            buttonClearSearchSettings = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonSell = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            textBoxModel = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            flowLayoutPanelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelContent.BackColor = Color.FromArgb(33, 11, 97);
            flowLayoutPanelContent.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelContent.Location = new Point(0, 110);
            flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            flowLayoutPanelContent.Size = new Size(758, 341);
            flowLayoutPanelContent.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(727, 8);
            label3.Name = "label3";
            label3.Size = new Size(28, 29);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(8, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(8, 37);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(105, 23);
            textBoxMake.TabIndex = 10;
            // 
            // textBoxTo
            // 
            textBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTo.Location = new Point(123, 32);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(76, 23);
            textBoxTo.TabIndex = 5;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFrom.Location = new Point(3, 32);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(80, 23);
            textBoxFrom.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTo);
            panel1.Controls.Add(textBoxFrom);
            panel1.Location = new Point(501, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 71);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(151, 14);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "TO:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "FROM:";
            // 
            // buttonClearSearchSettings
            // 
            buttonClearSearchSettings.Location = new Point(8, 66);
            buttonClearSearchSettings.Name = "buttonClearSearchSettings";
            buttonClearSearchSettings.Size = new Size(140, 23);
            buttonClearSearchSettings.TabIndex = 13;
            buttonClearSearchSettings.Text = "Clear Search Settings";
            buttonClearSearchSettings.UseVisualStyleBackColor = true;
            buttonClearSearchSettings.Click += buttonClearSearchSettings_Click_1;
            // 
            // buttonSell
            // 
            buttonSell.Location = new Point(412, 3);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(75, 23);
            buttonSell.TabIndex = 15;
            buttonSell.Text = "Sell";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 111);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(textBoxModel);
            panel3.Controls.Add(buttonSell);
            panel3.Controls.Add(textBoxMake);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(buttonClearSearchSettings);
            panel3.Controls.Add(buttonSearch);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 92);
            panel3.TabIndex = 16;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(119, 37);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(111, 23);
            textBoxModel.TabIndex = 16;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}