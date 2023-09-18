using ProductManager.Data;
using ProductManager.Models;
using ProductManager.UI;

namespace ProductManager
{
    public partial class frmProduct : Form
    {
        private DataContext _dataContext;

        public frmProduct(DataContext context)
        {
            _dataContext = context;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var products = _dataContext.Products.ToList();
            productDataGridView.Rows.Clear();
            foreach (var product in products)
            {
                productDataGridView.Rows.Add(
                    product.Id,
                    product.Name,
                    product.Price);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }

                if (numericUpDownPrice.Value == 0.00m)
                {
                    MessageBox.Show("Please enter price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDownPrice.Focus();
                    return;
                }
                var product = new Product();
                product.Name = nameTextBox.Text;
                product.Price = numericUpDownPrice.Value;
                _dataContext.Products.Add(product);
                if (_dataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Product has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Product saved failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reset()
        {
            nameTextBox.Text = string.Empty;
            numericUpDownPrice.Value = 0;
            LoadData();
        }

        private void productDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var dr = productDataGridView.SelectedRows[0];
                var frmProductDetail = new frmProductDetail(this, this._dataContext);
                frmProductDetail.idLabel.Text = dr.Cells[0].Value.ToString();
                frmProductDetail.nameTextBox.Text = dr.Cells[1].Value.ToString();
                frmProductDetail.numericUpDownPrice.Value = decimal.Parse(dr.Cells[2].Value.ToString());



                frmProductDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}