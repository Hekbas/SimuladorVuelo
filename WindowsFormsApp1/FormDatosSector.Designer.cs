namespace WindowsFormsApp1
{
    partial class FormDatosSector
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_capacidad = new System.Windows.Forms.Label();
            this.label_ocupacion = new System.Windows.Forms.Label();
            this.dgvVuelosSector = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosSector)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(12, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 12;
            this.label_id.Text = "ID";
            // 
            // label_capacidad
            // 
            this.label_capacidad.AutoSize = true;
            this.label_capacidad.ForeColor = System.Drawing.Color.Silver;
            this.label_capacidad.Location = new System.Drawing.Point(13, 61);
            this.label_capacidad.Name = "label_capacidad";
            this.label_capacidad.Size = new System.Drawing.Size(58, 13);
            this.label_capacidad.TabIndex = 8;
            this.label_capacidad.Text = "Capacidad";
            // 
            // label_ocupacion
            // 
            this.label_ocupacion.AutoSize = true;
            this.label_ocupacion.ForeColor = System.Drawing.Color.Silver;
            this.label_ocupacion.Location = new System.Drawing.Point(12, 85);
            this.label_ocupacion.Name = "label_ocupacion";
            this.label_ocupacion.Size = new System.Drawing.Size(59, 13);
            this.label_ocupacion.TabIndex = 7;
            this.label_ocupacion.Text = "Ocupación";
            // 
            // dgvVuelosSector
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.dgvVuelosSector.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVuelosSector.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.dgvVuelosSector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVuelosSector.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVuelosSector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelosSector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVuelosSector.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVuelosSector.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVuelosSector.EnableHeadersVisualStyles = false;
            this.dgvVuelosSector.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvVuelosSector.Location = new System.Drawing.Point(107, 26);
            this.dgvVuelosSector.Name = "dgvVuelosSector";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelosSector.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVuelosSector.RowHeadersVisible = false;
            this.dgvVuelosSector.RowHeadersWidth = 45;
            this.dgvVuelosSector.Size = new System.Drawing.Size(483, 116);
            this.dgvVuelosSector.TabIndex = 13;
            // 
            // FormDatosSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(642, 153);
            this.Controls.Add(this.dgvVuelosSector);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_capacidad);
            this.Controls.Add(this.label_ocupacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatosSector";
            this.Text = "FormSector";
            this.Load += new System.EventHandler(this.FormSector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_capacidad;
        private System.Windows.Forms.Label label_ocupacion;
        private System.Windows.Forms.DataGridView dgvVuelosSector;
    }
}