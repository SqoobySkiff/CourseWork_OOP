namespace CourseWork_OOP
{
    partial class SellerCabinetForm
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
            button2 = new Button();
            flowLayoutPanelCars = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            buttonRefresh = new Button();
            button3 = new Button();
            textBoxID = new TextBox();
            label1 = new Label();
            flowLayoutPanelOrders = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            button1.Location = new Point(319, 103);
            button1.Name = "button1";
            button1.Size = new Size(185, 63);
            button1.TabIndex = 0;
            button1.Text = "Sell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            button2.Location = new Point(529, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "UnLogin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanelCars
            // 
            flowLayoutPanelCars.BackColor = Color.FromArgb(33, 11, 97);
            flowLayoutPanelCars.Location = new Point(1, 172);
            flowLayoutPanelCars.Name = "flowLayoutPanelCars";
            flowLayoutPanelCars.Size = new Size(439, 279);
            flowLayoutPanelCars.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 169);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(768, 3);
            label3.Name = "label3";
            label3.Size = new Size(28, 29);
            label3.TabIndex = 15;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            buttonRefresh.Location = new Point(610, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(152, 23);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh Request";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Unispace", 9.749999F, FontStyle.Bold);
            button3.Location = new Point(117, 143);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 4;
            button3.Text = "Search by ID";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(11, 143);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 35);
            label1.TabIndex = 2;
            label1.Text = "Admin Page";
            // 
            // flowLayoutPanelOrders
            // 
            flowLayoutPanelOrders.BackColor = Color.FromArgb(33, 11, 97);
            flowLayoutPanelOrders.Location = new Point(462, 172);
            flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            flowLayoutPanelOrders.Size = new Size(338, 279);
            flowLayoutPanelOrders.TabIndex = 5;
            // 
            // SellerCabinetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelOrders);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanelCars);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellerCabinetForm";
            Text = "SellerCabinetForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanelCars;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelOrders;
        private Button button3;
        private TextBox textBoxID;
        private Button buttonRefresh;
        private Label label3;
    }
}