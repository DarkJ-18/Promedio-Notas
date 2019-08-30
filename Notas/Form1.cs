using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            Double prom;

            Double nota1 = Convert.ToDouble(txtnota1.Text);

            Double nota2 = Convert.ToDouble(txtnota2.Text);

            Double nota3 = Convert.ToDouble(txtnota3.Text);

            prom = (nota1 + nota2 + nota3) / 3.0;

            txtpromedio.Text = Convert.ToString(prom);

        }
    }
}
