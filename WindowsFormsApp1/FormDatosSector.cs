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
    public partial class FormDatosSector : Form
    {
        Sector objSector;
        ListaVuelos objLista;
        PictureBox[] aircraft_vector;
        FormPrincipal objFormPrincipal = new FormPrincipal();

        public FormDatosSector(Sector objSector, ListaVuelos objLista, PictureBox[] aircraft_vector)
        {
            this.objSector = objSector;
            this.objLista = objLista;
            this.aircraft_vector = aircraft_vector;

            InitializeComponent();
        }

        private void FormSector_Load(object sender, EventArgs e)
        {
            label_id.Text = "Sector: " + objSector.GetId();
            label_capacidad.Text = "Capacidad: " + objSector.GetCapacidad();
            label_ocupacion.Text = "Ocupación: " + objSector.Ocupacion(objLista);

            if (objSector.Ocupacion(objLista) != 0)
            {
                dgvVuelosSector.Visible = true;
                dgvVuelosSector.RowCount = objSector.Ocupacion(objLista);
                dgvVuelosSector.ColumnCount = 6;

                dgvVuelosSector.ColumnHeadersVisible = true;
                dgvVuelosSector.RowHeadersVisible = false;

                dgvVuelosSector.Columns[0].HeaderText = "ID";
                dgvVuelosSector.Columns[1].HeaderText = "Compañía";
                dgvVuelosSector.Columns[2].HeaderText = "Posición";
                dgvVuelosSector.Columns[3].HeaderText = "Velocidad";
                dgvVuelosSector.Columns[4].HeaderText = "Origen";
                dgvVuelosSector.Columns[5].HeaderText = "Destino";
            }

            int j = 0;
            for (int i = 0; i < objLista.GetCount(); i++)
            {
                if ((aircraft_vector[i].Location.X >= objSector.GetSecX()) && (aircraft_vector[i].Location.X <= (objSector.GetSecX() + objSector.GetAncho())))
                {
                    if ((aircraft_vector[i].Location.Y >= objSector.GetSecY()) && (aircraft_vector[i].Location.Y <= (objSector.GetSecY() + objSector.GetAlto())))
                    {
                        dgvVuelosSector[0, j].Value = objLista.GetVuelo(i).GetId();
                        dgvVuelosSector[1, j].Value = objLista.GetVuelo(i).GetCia();
                        dgvVuelosSector[2, j].Value = "(" + objLista.GetVuelo(i).GetPosX() + "," + objLista.GetVuelo(i).GetPosX() + ")";
                        dgvVuelosSector[3, j].Value = objLista.GetVuelo(i).GetV();
                        dgvVuelosSector[4, j].Value = "(" + objLista.GetVuelo(i).GetPosXi() + "," + objLista.GetVuelo(i).GetPosYi() + ")";
                        dgvVuelosSector[5, j].Value = "(" + objLista.GetVuelo(i).GetPosXf() + "," + objLista.GetVuelo(i).GetPosXf() + ")";
                        j++;
                    }
                }
            }

        }
    }
}
