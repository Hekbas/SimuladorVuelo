using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVuelos;

namespace WindowsFormsApp1
{
    public partial class FormAñadirSector : Form
    {
        ListaSectores objListaSec;

        public void GetSectores(ListaSectores objListaSec)
        {
            this.objListaSec = objListaSec;
        }

        public FormAñadirSector()
        {
            InitializeComponent();
        }

        private void Button_añadir_Click(object sender, EventArgs e)
        {
            double tryFormat;

            if (double.TryParse(textBox_capacidad.Text, out tryFormat) && double.TryParse(textBox_secX.Text, out tryFormat) && double.TryParse(textBox_secY.Text, out tryFormat) && double.TryParse(textBox_ancho.Text, out tryFormat) && double.TryParse(textBox_alto.Text, out tryFormat))      // Se comprueba si se ha introducido una cadena numérica
            {
                objListaSec.GetListaSectores().Add(new Sector(textBox_id.Text, Convert.ToInt32(textBox_capacidad.Text), Convert.ToInt32(textBox_secX.Text), Convert.ToInt32(textBox_secY.Text), Convert.ToInt32(textBox_ancho.Text), Convert.ToInt32(textBox_alto.Text)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Intruduce datos válidos.");
            }


        }

        private void FormAñadirSector_Load(object sender, EventArgs e)
        {

        }

        private void Button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
