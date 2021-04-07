namespace WindowsFormsApp1
{
    partial class FormListaVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaVuelos));
            this.listaVuelos = new System.Windows.Forms.DataGridView();
            this.panelControlesBaseDatos = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaVuelos)).BeginInit();
            this.panelControlesBaseDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaVuelos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.listaVuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaVuelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.listaVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaVuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listaVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaVuelos.ColumnHeadersHeight = 92;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaVuelos.DefaultCellStyle = dataGridViewCellStyle3;
            this.listaVuelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaVuelos.EnableHeadersVisualStyles = false;
            this.listaVuelos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.listaVuelos.Location = new System.Drawing.Point(0, 0);
            this.listaVuelos.Name = "listaVuelos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaVuelos.RowHeadersVisible = false;
            this.listaVuelos.RowHeadersWidth = 45;
            this.listaVuelos.Size = new System.Drawing.Size(875, 581);
            this.listaVuelos.TabIndex = 0;
            // 
            // panelControlesBaseDatos
            // 
            this.panelControlesBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelControlesBaseDatos.Controls.Add(this.button_volver);
            this.panelControlesBaseDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlesBaseDatos.Location = new System.Drawing.Point(0, 429);
            this.panelControlesBaseDatos.Name = "panelControlesBaseDatos";
            this.panelControlesBaseDatos.Size = new System.Drawing.Size(875, 152);
            this.panelControlesBaseDatos.TabIndex = 1;
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
            this.button_volver.Location = new System.Drawing.Point(692, 95);
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
            // FormListaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(875, 581);
            this.Controls.Add(this.panelControlesBaseDatos);
            this.Controls.Add(this.listaVuelos);
            this.Name = "FormListaVuelos";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.listaVuelos)).EndInit();
            this.panelControlesBaseDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaVuelos;
        private System.Windows.Forms.Panel panelControlesBaseDatos;
        private System.Windows.Forms.Button button_volver;
    }
}