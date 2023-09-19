using ProductManager.Data;
using ProductManager.Models;
using ProductManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager.UI;

public partial class frmProductDetail : Form
{
    private IProductRepository _products;


    private frmProduct frmProduct;
    public frmProductDetail(frmProduct frmProduct, DataContext context)
    {
        _products = new ProductRepository(context);
        this.frmProduct = frmProduct;
        InitializeComponent();
    }

    private void frmProductDetail_Load(object sender, EventArgs e)
    {

    }

    private void updateButton_Click(object sender, EventArgs e)
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
            var id = Convert.ToInt32(idLabel.Text);

            var product = _products.GetById(id);
            if (product == null)
            {
                MessageBox.Show("Product not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            product.Name = nameTextBox.Text;
            product.Price = numericUpDownPrice.Value;
            if (_products.Update(product))
            {
                MessageBox.Show("Product has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmProduct.LoadData();
            }
            else
            {
                MessageBox.Show("Product saved failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var id = Convert.ToInt32(idLabel.Text);
            var product = _products.GetById(id);
            if (product == null)
            {
                MessageBox.Show("Product not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            if (MessageBox.Show("Do you want to delete?", "Qeuestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
                if (_products.Delete(product))
                {
                    MessageBox.Show("Product has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmProduct.LoadData();
                }
                else
                {
                    MessageBox.Show("Product deletion failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
