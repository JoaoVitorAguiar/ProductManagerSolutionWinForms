using ProductManager.Data;
using ProductManager.Models;

namespace ProductManager
{
    public partial class frmProduct : Form
    {
        private DataContext _dataContext = new DataContext();
        public frmProduct()
        {
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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    Reset();
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

        private void Reset()
        {
            nameTextBox.Text = string.Empty;
            numericUpDownPrice.Value = 0;
        }
    }
}