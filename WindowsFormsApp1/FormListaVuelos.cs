using System;
using System.Drawing;
using System.Windows.Forms;
using LibVuelos;
using System.Data;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class FormListaVuelos : Form
    {
        ListaVuelos objLista = new ListaVuelos();
        

        public FormListaVuelos()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaVuelos.ColumnCount = 6;
            listaVuelos.RowCount = objLista.GetCount();

            listaVuelos.ColumnHeadersVisible = true;
            listaVuelos.RowHeadersVisible = false;

            foreach (DataGridViewRow fila in listaVuelos.Rows)
                fila.Height = 45;

            //listaVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            listaVuelos.Columns[0].HeaderText = "ID";
            listaVuelos.Columns[1].HeaderText = "Compañía";
            listaVuelos.Columns[2].HeaderText = "Posición";
            listaVuelos.Columns[3].HeaderText = "Velocidad";
            listaVuelos.Columns[4].HeaderText = "Salida";
            listaVuelos.Columns[5].HeaderText = "Destino";

            for (int i = 0; i < listaVuelos.RowCount; i++)
            {
                listaVuelos.Rows[i].HeaderCell.Value = "" + i;

                listaVuelos.Rows[i].Cells[0].Value = objLista.GetVuelo(i).GetId();
                listaVuelos.Rows[i].Cells[1].Value = objLista.GetVuelo(i).GetCia();
                listaVuelos.Rows[i].Cells[2].Value = "(" + objLista.GetVuelo(i).GetPosX().ToString("N2") + "," + objLista.GetVuelo(i).GetPosY().ToString("N2") + ")";
                listaVuelos.Rows[i].Cells[3].Value = objLista.GetVuelo(i).GetV();
                listaVuelos.Rows[i].Cells[4].Value = "(" + objLista.GetVuelo(i).GetPosXi() + "," + objLista.GetVuelo(i).GetPosYi() + ")";
                listaVuelos.Rows[i].Cells[5].Value = "(" + objLista.GetVuelo(i).GetPosXf() + "," + objLista.GetVuelo(i).GetPosYf() + ")";      
            }
        }
        public void SetLista(ListaVuelos listaVuelo)
        {
            this.objLista = listaVuelo;
        }

        private void Button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
