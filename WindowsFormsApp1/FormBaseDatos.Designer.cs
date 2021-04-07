namespace WindowsFormsApp1
{
    partial class FormBaseDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseDatos));
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.panelControlesBaseDatos = new System.Windows.Forms.Panel();
            this.button_buscarCia = new System.Windows.Forms.Button();
            this.button_eliminarCia = new System.Windows.Forms.Button();
            this.button_añadirCia = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.button_cambiarTlf = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_nuevaV = new System.Windows.Forms.Label();
            this.textBox_web = new System.Windows.Forms.TextBox();
            this.label_tiempoSimulacion = new System.Windows.Forms.Label();
            this.textBox_tlf = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.button_recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.panelControlesBaseDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.dgvBaseDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaseDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBaseDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.dgvBaseDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaseDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaseDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaseDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaseDatos.ColumnHeadersHeight = 92;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaseDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaseDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBaseDatos.EnableHeadersVisualStyles = false;
            this.dgvBaseDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvBaseDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaseDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaseDatos.RowHeadersVisible = false;
            this.dgvBaseDatos.RowHeadersWidth = 45;
            this.dgvBaseDatos.Size = new System.Drawing.Size(1034, 530);
            this.dgvBaseDatos.TabIndex = 1;
            // 
            // panelControlesBaseDatos
            // 
            this.panelControlesBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelControlesBaseDatos.Controls.Add(this.button_recargar);
            this.panelControlesBaseDatos.Controls.Add(this.button_buscarCia);
            this.panelControlesBaseDatos.Controls.Add(this.button_eliminarCia);
            this.panelControlesBaseDatos.Controls.Add(this.button_añadirCia);
            this.panelControlesBaseDatos.Controls.Add(this.label_id);
            this.panelControlesBaseDatos.Controls.Add(this.button_cambiarTlf);
            this.panelControlesBaseDatos.Controls.Add(this.button_volver);
            this.panelControlesBaseDatos.Controls.Add(this.textBox_email);
            this.panelControlesBaseDatos.Controls.Add(this.label_nuevaV);
            this.panelControlesBaseDatos.Controls.Add(this.textBox_web);
            this.panelControlesBaseDatos.Controls.Add(this.label_tiempoSimulacion);
            this.panelControlesBaseDatos.Controls.Add(this.textBox_tlf);
            this.panelControlesBaseDatos.Controls.Add(this.label_nombre);
            this.panelControlesBaseDatos.Controls.Add(this.textBox_nombre);
            this.panelControlesBaseDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlesBaseDatos.Location = new System.Drawing.Point(0, 529);
            this.panelControlesBaseDatos.Name = "panelControlesBaseDatos";
            this.panelControlesBaseDatos.Size = new System.Drawing.Size(1034, 152);
            this.panelControlesBaseDatos.TabIndex = 0;
            // 
            // button_buscarCia
            // 
            this.button_buscarCia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscarCia.ForeColor = System.Drawing.Color.Silver;
            this.button_buscarCia.Location = new System.Drawing.Point(471, 81);
            this.button_buscarCia.Margin = new System.Windows.Forms.Padding(2);
            this.button_buscarCia.Name = "button_buscarCia";
            this.button_buscarCia.Size = new System.Drawing.Size(106, 40);
            this.button_buscarCia.TabIndex = 26;
            this.button_buscarCia.Text = "Buscar Compañía";
            this.button_buscarCia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_buscarCia.UseVisualStyleBackColor = true;
            this.button_buscarCia.Click += new System.EventHandler(this.Button_buscarCia_Click);
            // 
            // button_eliminarCia
            // 
            this.button_eliminarCia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminarCia.ForeColor = System.Drawing.Color.Silver;
            this.button_eliminarCia.Location = new System.Drawing.Point(471, 24);
            this.button_eliminarCia.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminarCia.Name = "button_eliminarCia";
            this.button_eliminarCia.Size = new System.Drawing.Size(106, 40);
            this.button_eliminarCia.TabIndex = 25;
            this.button_eliminarCia.Text = "Eliminar Compañía";
            this.button_eliminarCia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_eliminarCia.UseVisualStyleBackColor = true;
            this.button_eliminarCia.Click += new System.EventHandler(this.Button_eliminarCia_Click);
            // 
            // button_añadirCia
            // 
            this.button_añadirCia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_añadirCia.ForeColor = System.Drawing.Color.Silver;
            this.button_añadirCia.Location = new System.Drawing.Point(344, 82);
            this.button_añadirCia.Margin = new System.Windows.Forms.Padding(2);
            this.button_añadirCia.Name = "button_añadirCia";
            this.button_añadirCia.Size = new System.Drawing.Size(106, 40);
            this.button_añadirCia.TabIndex = 24;
            this.button_añadirCia.Text = "Añadir Compañía";
            this.button_añadirCia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_añadirCia.UseVisualStyleBackColor = true;
            this.button_añadirCia.Click += new System.EventHandler(this.Button_añadirCia_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(183, 17);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 16);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "Web";
            // 
            // button_cambiarTlf
            // 
            this.button_cambiarTlf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cambiarTlf.ForeColor = System.Drawing.Color.Silver;
            this.button_cambiarTlf.Location = new System.Drawing.Point(344, 24);
            this.button_cambiarTlf.Margin = new System.Windows.Forms.Padding(2);
            this.button_cambiarTlf.Name = "button_cambiarTlf";
            this.button_cambiarTlf.Size = new System.Drawing.Size(106, 40);
            this.button_cambiarTlf.TabIndex = 4;
            this.button_cambiarTlf.Text = "Cambiar Tlf";
            this.button_cambiarTlf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cambiarTlf.UseVisualStyleBackColor = true;
            this.button_cambiarTlf.Click += new System.EventHandler(this.Button_cambiarTlf_Click);
            // 
            // button_volver
            // 
            this.button_volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_volver.FlatAppearance.BorderSize = 0;
            this.button_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.Silver;
            this.button_volver.Image = ((System.Drawing.Image)(resources.GetObject("button_volver.Image")));
            this.button_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_volver.Location = new System.Drawing.Point(752, 82);
            this.button_volver.Name = "button_volver";
            this.button_volver.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_volver.Size = new System.Drawing.Size(116, 45);
            this.button_volver.TabIndex = 23;
            this.button_volver.Text = "  Volver";
            this.button_volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.Button_volver_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.Color.Silver;
            this.textBox_email.Location = new System.Drawing.Point(185, 101);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(120, 24);
            this.textBox_email.TabIndex = 3;
            // 
            // label_nuevaV
            // 
            this.label_nuevaV.AutoSize = true;
            this.label_nuevaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevaV.ForeColor = System.Drawing.Color.Silver;
            this.label_nuevaV.Location = new System.Drawing.Point(183, 82);
            this.label_nuevaV.Name = "label_nuevaV";
            this.label_nuevaV.Size = new System.Drawing.Size(42, 16);
            this.label_nuevaV.TabIndex = 6;
            this.label_nuevaV.Text = "Email";
            // 
            // textBox_web
            // 
            this.textBox_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_web.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_web.ForeColor = System.Drawing.Color.Silver;
            this.textBox_web.Location = new System.Drawing.Point(185, 36);
            this.textBox_web.Multiline = true;
            this.textBox_web.Name = "textBox_web";
            this.textBox_web.Size = new System.Drawing.Size(120, 24);
            this.textBox_web.TabIndex = 2;
            // 
            // label_tiempoSimulacion
            // 
            this.label_tiempoSimulacion.AutoSize = true;
            this.label_tiempoSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoSimulacion.ForeColor = System.Drawing.Color.Silver;
            this.label_tiempoSimulacion.Location = new System.Drawing.Point(31, 82);
            this.label_tiempoSimulacion.Name = "label_tiempoSimulacion";
            this.label_tiempoSimulacion.Size = new System.Drawing.Size(23, 16);
            this.label_tiempoSimulacion.TabIndex = 15;
            this.label_tiempoSimulacion.Text = "Tlf";
            // 
            // textBox_tlf
            // 
            this.textBox_tlf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_tlf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tlf.ForeColor = System.Drawing.Color.Silver;
            this.textBox_tlf.Location = new System.Drawing.Point(33, 101);
            this.textBox_tlf.Multiline = true;
            this.textBox_tlf.Name = "textBox_tlf";
            this.textBox_tlf.Size = new System.Drawing.Size(120, 24);
            this.textBox_tlf.TabIndex = 14;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.Silver;
            this.label_nombre.Location = new System.Drawing.Point(31, 17);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(57, 16);
            this.label_nombre.TabIndex = 8;
            this.label_nombre.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.ForeColor = System.Drawing.Color.Silver;
            this.textBox_nombre.Location = new System.Drawing.Point(34, 37);
            this.textBox_nombre.MaximumSize = new System.Drawing.Size(120, 50);
            this.textBox_nombre.Multiline = true;
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(120, 24);
            this.textBox_nombre.TabIndex = 7;
            // 
            // button_recargar
            // 
            this.button_recargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_recargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_recargar.FlatAppearance.BorderSize = 0;
            this.button_recargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_recargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_recargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_recargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recargar.ForeColor = System.Drawing.Color.Silver;
            this.button_recargar.Image = ((System.Drawing.Image)(resources.GetObject("button_recargar.Image")));
            this.button_recargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_recargar.Location = new System.Drawing.Point(633, 24);
            this.button_recargar.Name = "button_recargar";
            this.button_recargar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_recargar.Size = new System.Drawing.Size(116, 45);
            this.button_recargar.TabIndex = 27;
            this.button_recargar.Text = "  Recargar";
            this.button_recargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_recargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_recargar.UseVisualStyleBackColor = false;
            this.button_recargar.Click += new System.EventHandler(this.Button_recargar_Click);
            // 
            // FormBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1034, 681);
            this.Controls.Add(this.panelControlesBaseDatos);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "FormBaseDatos";
            this.Text = "FormBaseDatos";
            this.Load += new System.EventHandler(this.FormBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.panelControlesBaseDatos.ResumeLayout(false);
            this.panelControlesBaseDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.Panel panelControlesBaseDatos;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_cambiarTlf;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_nuevaV;
        private System.Windows.Forms.TextBox textBox_web;
        private System.Windows.Forms.Label label_tiempoSimulacion;
        private System.Windows.Forms.TextBox textBox_tlf;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_buscarCia;
        private System.Windows.Forms.Button button_eliminarCia;
        private System.Windows.Forms.Button button_añadirCia;
        private System.Windows.Forms.Button button_recargar;
    }
}