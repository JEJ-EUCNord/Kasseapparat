using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasseapparat
{
    public partial class Form1 : Form
    {
        decimal subtotal;
        decimal total;
        decimal dagstotal;

        public Form1()
        {
            InitializeComponent();
            Opdater();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            subtotal = subtotal + Decimal.Parse(tbPris.Text);
            lblSubtotal.Text = subtotal.ToString();
            
            Opdater();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            total = subtotal;
            dagstotal = dagstotal + total;
            subtotal = 0;

            Opdater();         
        }
        
        private void Opdater()
        {
            lblTotal.Text = total.ToString();
            lblDagsTotal.Text = dagstotal.ToString();
            lblSubtotal.Text = subtotal.ToString();
            tbPris.Text = "";
        }
    }
}
