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
    public partial class ChildForm : Form
    {
        public Product Product { get; set; }
        public ChildForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
          
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = textBox1.Text,
                Cost = double.Parse(textBox3.Text),
                OriginCountry = textBox2.Text
            };
            Product = product;

            
        }
        
    }
}
