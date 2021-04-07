using System;
using System.Windows.Forms;
using LibVuelos;
using System.Data;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class FormDatosVuelo : Form
    {
        Vuelo objVuelo = new Vuelo();

        FormBaseDatos baseDatos = new FormBaseDatos();

        DataTable consulta;


        public FormDatosVuelo()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)     //muestra los datos del avión pulsado
        {
            label_id.Text = "Vuelo: " + objVuelo.GetId();
            label_cia.Text = "Compañía: " + objVuelo.GetCia();
            label_pos.Text = "Posición: (" + objVuelo.GetPosX().ToString("N2") + "," + objVuelo.GetPosY().ToString("N2") + ")";
            label_v.Text = "Velocidad: " + objVuelo.GetV();
            label_posI.Text = "Salida: (" + objVuelo.GetPosXi() + "," + objVuelo.GetPosYi() + ")";
            label_posF.Text = "Destino: (" + objVuelo.GetPosXf() + "," + objVuelo.GetPosYf() + ")";


            baseDatos.IniciarConexion();
            consulta = baseDatos.GetDatosParaVuelos(objVuelo.GetCia());

            if (consulta.Rows.Count == 0)
            {
                MessageBox.Show("No hay ninguna compañía con ese nombre.");
            }
            else if (consulta.Rows.Count > 1)
            {
                MessageBox.Show("Hay más de una compañía con ese nombre.");
            }
            else
            {
                label_tlf.Text = consulta.Rows[0][1].ToString();
                label_email.Text = consulta.Rows[0][0].ToString();

            }
            baseDatos.CerrarConexion();
        }

        public void SetVuelo(Vuelo a)
        {
            this.objVuelo = a;
        }
    }
}
