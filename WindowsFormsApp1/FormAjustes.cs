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
    public partial class FormAjustes : Form
    {
        FormPrincipal fp = new FormPrincipal();
        PictureBox[] airport_vector;
        Ajustes objAjustes;

        bool cargarVuelos;

        public FormAjustes(Ajustes objAjustes, PictureBox[] airport_vector, bool cargarVuelos)
        {
            InitializeComponent();
            this.objAjustes = objAjustes;
            this.airport_vector = airport_vector;
            this.cargarVuelos = cargarVuelos;
        }


        private void FormAjustes_Load(object sender, EventArgs e)
        {
            ToggleOnOff();

            // Para pruebas
            //textBox_sonido.Text = Convert.ToString(objAjustes.GetSonido());
            //textBox_aeropuertos.Text = Convert.ToString(objAjustes.GetAeropuertos());
            //textBox_rutas.Text = Convert.ToString(objAjustes.GetRutas());

            this.Controls.Remove(textBox_sonido);
            this.Controls.Remove(textBox_aeropuertos);
            this.Controls.Remove(textBox_rutas);
        }

        public void ToggleOnOff()
        {
            if (objAjustes.GetSonido() == true)
                button_sonido.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
            else
                button_sonido.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");

            if (objAjustes.GetAeropuertos() == true)
                button_aeropuertos.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
            else
                button_aeropuertos.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");

            if (objAjustes.GetRutas() == true)
                button_rutas.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
            else
                button_rutas.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");
        }

        private void Button_sonido_Click(object sender, EventArgs e)
        {
            if (objAjustes.GetSonido() == true)
            {
                button_sonido.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");
                objAjustes.SetSonido(false);
            }
            else
            {
                button_sonido.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
                objAjustes.SetSonido(true);
            }
            //textBox_sonido.Text = Convert.ToString(objAjustes.GetSonido());
        }

        private void Button_aeropuertos_Click(object sender, EventArgs e)
        {
            if (objAjustes.GetAeropuertos() == true)
            {
                button_aeropuertos.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");
                objAjustes.SetAeropuertos(false);
            }
            else
            {
                button_aeropuertos.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
                objAjustes.SetAeropuertos(true);
            }
            //textBox_aeropuertos.Text = Convert.ToString(objAjustes.GetAeropuertos());
            fp.MostrarAeropuertos(airport_vector, cargarVuelos, objAjustes);
        }

        private void Button_rutas_Click(object sender, EventArgs e)
        {
            if (objAjustes.GetRutas() == true)
            {
                button_rutas.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_off_32px.png");
                objAjustes.SetRutas(false);
            }
            else
            {
                button_rutas.Image = Image.FromFile(@"..\..\..\UI\iconos\icons8_toggle_on_32px.png");
                objAjustes.SetRutas(true);
            }
            //textBox_rutas.Text = Convert.ToString(objAjustes.GetRutas());
            fp.MostrarRutas();
            MessageBox.Show("Lo siento! Esta opción aun no esta disponible :(");

        }

        private void Button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
