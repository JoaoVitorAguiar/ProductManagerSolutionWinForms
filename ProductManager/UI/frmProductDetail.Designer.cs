namespace ProductManager.UI
{
    partial class frmProductDetail
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            updateButton = new Button();
            numericUpDownPrice = new NumericUpDown();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            idLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(87, 65);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(368, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Information";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(202, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 11;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.LightGreen;
            updateButton.Location = new Point(283, 165);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 33);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(98, 97);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(260, 29);
            numericUpDownPrice.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 8;
            label2.Text = "Price";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(98, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(260, 29);
            nameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 48);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(432, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 21);
            idLabel.TabIndex = 1;
            idLabel.Visible = false;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 372);
            Controls.Add(idLabel);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Detail";
            Load += frmProductDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button updateButton;
        private Label label2;
        private Label label1;
        public NumericUpDown numericUpDownPrice;
        public TextBox nameTextBox;
        public Label idLabel;
        private Button button1;
    }
}