using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using LibVuelos;

namespace WindowsFormsApp1
{
    public partial class FormBaseDatos : Form
    {
        FormPrincipal fp = new FormPrincipal();
        SQLiteConnection cnx;
        
        public FormBaseDatos()
        {
            InitializeComponent();
        }

        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            panelControlesBaseDatos.Controls.Add(button_volver);
            panelControlesBaseDatos.Controls.Add(button_cambiarTlf);
            panelControlesBaseDatos.Controls.Remove(button_recargar);


            IniciarConexion();
            DataTable consulta = GetDatosCia();
            dgvBaseDatos.DataSource = consulta;
            dgvBaseDatos.Refresh();

            foreach (DataGridViewRow fila in dgvBaseDatos.Rows)
                fila.Height = 45;
        }

        public void IniciarConexion()
        {
            string dataSource = @"Data Source = ..\..\..\Datos\baseDatos.db";
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        public void CerrarConexion()
        {
            cnx.Close();
        }

        public DataTable GetDatosCia()
        {
            SQLiteDataAdapter adp;
            DataTable dt = new DataTable();
            string sql;
            sql = "SELECT * FROM datosCia";
            adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }

        public int CambiarTlf(string Nombre, int Telefono)
        {
            string sql;
            sql = "UPDATE datosCia SET Telefono =" + Telefono + " WHERE NOMBRE='" + Nombre + "'";
            SQLiteCommand command = new SQLiteCommand(sql, cnx);
            int affectedRows = command.ExecuteNonQuery();
            if (affectedRows == 1)
                return 0;
            else
                return -1;
        }

        public int AñadirCia(string Nombre, int Telefono, string Email, string Web)
        {
            string sql;
            sql = "INSERT INTO datosCia VALUES ('" + Nombre + "','" + Telefono + "','" + Email + "','" + Web + "')";
            SQLiteCommand command = new SQLiteCommand(sql, cnx);
            int affectedRows = command.ExecuteNonQuery();
            if (affectedRows == 1)
                return 0;
            else
                return -1;
        }

        public int EliminarCia(string Nombre)
        {
            string sql;
            sql = "DELETE FROM datosCia WHERE NOMBRE='" + Nombre + "'";
            SQLiteCommand command = new SQLiteCommand(sql, cnx);
            int affectedRows = command.ExecuteNonQuery();
            if (affectedRows == 1)
                return 0;
            else
                return -1;
        }

        public DataTable BuscarCia(string Nombre)
        {
            string sql;
            SQLiteDataAdapter adp;
            DataTable dt = new DataTable();
            sql = "SELECT * FROM datosCia WHERE NOMBRE='" + Nombre + "'";
            adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }

        //Form datos vuelos
        public DataTable GetDatosParaVuelos(string Nombre)
        {
            DataTable dt = new DataTable();
            string sql;
            sql = "SELECT Email, Telefono FROM datosCia WHERE NOMBRE='" + Nombre + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }

        public void ActulizarInfo()
        {
            DataTable consulta = GetDatosCia();

            dgvBaseDatos.DataSource = consulta;
            dgvBaseDatos.Refresh();
        }


        // BOTONES
        private void Button_cambiarTlf_Click(object sender, EventArgs e)
        {
            if (CambiarTlf(textBox_nombre.Text, Convert.ToInt32(textBox_tlf.Text)) == 0)
                MessageBox.Show("Se ha modificado el telefono");
            else
                MessageBox.Show("No se ha podido cambiar el telefono");

            ActulizarInfo();
        }

        private void Button_añadirCia_Click(object sender, EventArgs e)
        {
            if (AñadirCia(textBox_nombre.Text, Convert.ToInt32(textBox_tlf.Text), textBox_email.Text, textBox_web.Text) == 0)
                MessageBox.Show("Se ha añadido la Compañia");
            else
                MessageBox.Show("No se ha podido añadir la Compañia");

            ActulizarInfo();
        }

        private void Button_eliminarCia_Click(object sender, EventArgs e)
        {
            if (EliminarCia(textBox_nombre.Text) == 0)
                MessageBox.Show("Se ha eliminado la Compañia");
            else
                MessageBox.Show("No se ha encontrado la Compañia");

            ActulizarInfo();
        }

        private void Button_buscarCia_Click(object sender, EventArgs e)
        {
            DataTable consulta = BuscarCia(textBox_nombre.Text);

            if (consulta.Rows.Count == 0)
                MessageBox.Show("No hay ninguna compañia con ese nombre");
            else if (consulta.Rows.Count > 1)
                MessageBox.Show("Hay mas de una compañia con ese nombre");
            else
            {
                dgvBaseDatos.DataSource = consulta;
                dgvBaseDatos.Refresh();
                panelControlesBaseDatos.Controls.Add(button_recargar);
            }
        }

        private void Button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_recargar_Click(object sender, EventArgs e)
        {
            ActulizarInfo();
            panelControlesBaseDatos.Controls.Remove(button_recargar);
        }
    }   
}
