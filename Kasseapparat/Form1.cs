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
        decimal moms;
        decimal dagstotal;
        List<decimal> priser = new List<decimal>();


        public Form1()
        {
            InitializeComponent();
            Opdater();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            subtotal = subtotal + Decimal.Parse(tbPris.Text);
            priser.Add(Decimal.Parse(tbPris.Text));

            Opdater();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            total = subtotal;
            moms = total/5;
            dagstotal = dagstotal + total;
            subtotal = 0;

            Opdater();

            foreach (var item in priser)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
        
        private void Opdater()
        {
            lblTotal.Text = total.ToString();
            lblDagsTotal.Text = dagstotal.ToString();
            lblSubtotal.Text = subtotal.ToString();
            lblMoms.Text = moms.ToString();
            tbPris.Text = "";
        }
    }
}
