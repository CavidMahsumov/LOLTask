using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Product Product { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.ShowDialog();
            listBox1.Items.Add(childForm.Product);
            
  
        }
        public DialogResult ShowDialog(Product product)
        {
            listBox1.Items.Add(product);
            return ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.ShowDialog();
            try
            {
                foreach (var item in listBox1.SelectedItems)
                {
                    var Product = item as Product;
                    listBox1.Items.Remove(Product);
                    Product.Name = childForm.Product.Name;
                    Product.Cost = childForm.Product.Cost;
                    Product.OriginCountry = childForm.Product.OriginCountry;
                    listBox1.Items.Add(Product);

                }
            }
            catch (Exception)
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                
                listBox1.Items.Remove(Product);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listBox1.Items)
                {
                    listBox1.Items.Remove(item);
                }
            }
            catch (Exception)
            {

            }
            
        }
    }
}
