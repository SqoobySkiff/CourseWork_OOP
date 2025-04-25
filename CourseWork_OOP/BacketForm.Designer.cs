namespace CourseWork_OOP
{
    partial class BacketForm
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
            flowLayoutPanelBacket = new FlowLayoutPanel();
            labelReturn = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelBacket
            // 
            flowLayoutPanelBacket.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanelBacket.Location = new Point(12, 47);
            flowLayoutPanelBacket.Name = "flowLayoutPanelBacket";
            flowLayoutPanelBacket.Size = new Size(776, 391);
            flowLayoutPanelBacket.TabIndex = 0;
            // 
            // labelReturn
            // 
            labelReturn.AutoSize = true;
            labelReturn.Cursor = Cursors.Hand;
            labelReturn.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReturn.Location = new Point(750, 9);
            labelReturn.Name = "labelReturn";
            labelReturn.Size = new Size(38, 35);
            labelReturn.TabIndex = 1;
            labelReturn.Text = "←";
            labelReturn.Click += labelReturn_Click;
            // 
            // BacketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReturn);
            Controls.Add(flowLayoutPanelBacket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BacketForm";
            Text = "BacketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBacket;
        private Label labelReturn;
    }
}