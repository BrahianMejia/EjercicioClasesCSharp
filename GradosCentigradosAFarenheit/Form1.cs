using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradosCentigradosAFarenheit
{
    public partial class Form1 : Form
    {
        Temperatura temperatura= new Temperatura();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            temperatura.setGrados(double.Parse(txtcentigrados.Text));

            lblresultado.Text = "Resultado: " + temperatura.calculo().ToString();
            lblresultado.Visible = true;
        }
    }
}
