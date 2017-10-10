using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
            double mt =Double.Parse(textBoxMontant.Text);
            double res = stub.ConversionEuroToDh(mt);
            textBoxResultat.Text =res.ToString();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
            ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
            ServiceReference1.compte[] cptes = stub.getComptes();
            foreach (ServiceReference1.compte cp in cptes)
            {
                dataGridView1.Rows.Add(cp.code, cp.solde);
            }
        }
    }
}
