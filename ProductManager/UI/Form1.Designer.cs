namespace ProductManager
{
    partial class frmProduct
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
            groupBox1 = new GroupBox();
            productDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            saveButton = new Button();
            numericUpDownPrice = new NumericUpDown();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(productDataGridView);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(49, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 621);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // productDataGridView
            // 
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.AllowUserToDeleteRows = false;
            productDataGridView.AllowUserToResizeColumns = false;
            productDataGridView.AllowUserToResizeRows = false;
            productDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Price });
            productDataGridView.Location = new Point(160, 217);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.ReadOnly = true;
            productDataGridView.RowTemplate.Height = 25;
            productDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDataGridView.Size = new Size(534, 371);
            productDataGridView.TabIndex = 6;
            productDataGridView.CellContentClick += productDataGridView_CellContentClick;
            productDataGridView.RowHeaderMouseDoubleClick += productDataGridView_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGreen;
            saveButton.Location = new Point(593, 157);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 33);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(408, 89);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(260, 29);
            numericUpDownPrice.TabIndex = 4;
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 89);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(408, 37);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(260, 29);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 669);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            //Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Entry";
            Load += frmProduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDownPrice;
        private Button saveButton;
        private DataGridView productDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
    }
}