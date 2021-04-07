namespace WindowsFormsApp1
{
    partial class FormAñadirSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAñadirSector));
            this.label_id = new System.Windows.Forms.Label();
            this.button_añadir = new System.Windows.Forms.Button();
            this.textBox_secY = new System.Windows.Forms.TextBox();
            this.label_nuevaV = new System.Windows.Forms.Label();
            this.textBox_secX = new System.Windows.Forms.TextBox();
            this.label_tiempoSimulacion = new System.Windows.Forms.Label();
            this.textBox_capacidad = new System.Windows.Forms.TextBox();
            this.label_tiempoCiclo = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_ancho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_alto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(25, 29);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 16);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "ID";
            // 
            // button_añadir
            // 
            this.button_añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_añadir.ForeColor = System.Drawing.Color.Silver;
            this.button_añadir.Location = new System.Drawing.Point(29, 421);
            this.button_añadir.Margin = new System.Windows.Forms.Padding(2);
            this.button_añadir.Name = "button_añadir";
            this.button_añadir.Size = new System.Drawing.Size(106, 40);
            this.button_añadir.TabIndex = 6;
            this.button_añadir.Text = "Añadir";
            this.button_añadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_añadir.UseVisualStyleBackColor = true;
            this.button_añadir.Click += new System.EventHandler(this.Button_añadir_Click);
            // 
            // textBox_secY
            // 
            this.textBox_secY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_secY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_secY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_secY.ForeColor = System.Drawing.Color.Silver;
            this.textBox_secY.Location = new System.Drawing.Point(27, 241);
            this.textBox_secY.Multiline = true;
            this.textBox_secY.Name = "textBox_secY";
            this.textBox_secY.Size = new System.Drawing.Size(120, 24);
            this.textBox_secY.TabIndex = 3;
            // 
            // label_nuevaV
            // 
            this.label_nuevaV.AutoSize = true;
            this.label_nuevaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevaV.ForeColor = System.Drawing.Color.Silver;
            this.label_nuevaV.Location = new System.Drawing.Point(25, 222);
            this.label_nuevaV.Name = "label_nuevaV";
            this.label_nuevaV.Size = new System.Drawing.Size(72, 16);
            this.label_nuevaV.TabIndex = 6;
            this.label_nuevaV.Text = "Posición Y";
            // 
            // textBox_secX
            // 
            this.textBox_secX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_secX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_secX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_secX.ForeColor = System.Drawing.Color.Silver;
            this.textBox_secX.Location = new System.Drawing.Point(27, 176);
            this.textBox_secX.Multiline = true;
            this.textBox_secX.Name = "textBox_secX";
            this.textBox_secX.Size = new System.Drawing.Size(120, 24);
            this.textBox_secX.TabIndex = 2;
            // 
            // label_tiempoSimulacion
            // 
            this.label_tiempoSimulacion.AutoSize = true;
            this.label_tiempoSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoSimulacion.ForeColor = System.Drawing.Color.Silver;
            this.label_tiempoSimulacion.Location = new System.Drawing.Point(24, 93);
            this.label_tiempoSimulacion.Name = "label_tiempoSimulacion";
            this.label_tiempoSimulacion.Size = new System.Drawing.Size(75, 16);
            this.label_tiempoSimulacion.TabIndex = 15;
            this.label_tiempoSimulacion.Text = "Capacidad";
            // 
            // textBox_capacidad
            // 
            this.textBox_capacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_capacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_capacidad.ForeColor = System.Drawing.Color.Silver;
            this.textBox_capacidad.Location = new System.Drawing.Point(26, 112);
            this.textBox_capacidad.Multiline = true;
            this.textBox_capacidad.Name = "textBox_capacidad";
            this.textBox_capacidad.Size = new System.Drawing.Size(120, 24);
            this.textBox_capacidad.TabIndex = 1;
            // 
            // label_tiempoCiclo
            // 
            this.label_tiempoCiclo.AutoSize = true;
            this.label_tiempoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoCiclo.ForeColor = System.Drawing.Color.Silver;
            this.label_tiempoCiclo.Location = new System.Drawing.Point(23, 157);
            this.label_tiempoCiclo.Name = "label_tiempoCiclo";
            this.label_tiempoCiclo.Size = new System.Drawing.Size(71, 16);
            this.label_tiempoCiclo.TabIndex = 8;
            this.label_tiempoCiclo.Text = "Posición X";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.ForeColor = System.Drawing.Color.Silver;
            this.textBox_id.Location = new System.Drawing.Point(27, 48);
            this.textBox_id.MaximumSize = new System.Drawing.Size(120, 50);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(120, 24);
            this.textBox_id.TabIndex = 0;
            // 
            // textBox_ancho
            // 
            this.textBox_ancho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_ancho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ancho.ForeColor = System.Drawing.Color.Silver;
            this.textBox_ancho.Location = new System.Drawing.Point(26, 306);
            this.textBox_ancho.Multiline = true;
            this.textBox_ancho.Name = "textBox_ancho";
            this.textBox_ancho.Size = new System.Drawing.Size(120, 24);
            this.textBox_ancho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ancho";
            // 
            // textBox_alto
            // 
            this.textBox_alto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_alto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alto.ForeColor = System.Drawing.Color.Silver;
            this.textBox_alto.Location = new System.Drawing.Point(28, 367);
            this.textBox_alto.Multiline = true;
            this.textBox_alto.Name = "textBox_alto";
            this.textBox_alto.Size = new System.Drawing.Size(120, 24);
            this.textBox_alto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(26, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(441, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Info: Se puede usar el tabulador para cambiar de textbox al insertar los datos.";
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
            this.button_volver.Location = new System.Drawing.Point(738, 433);
            this.button_volver.Name = "button_volver";
            this.button_volver.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_volver.Size = new System.Drawing.Size(116, 45);
            this.button_volver.TabIndex = 24;
            this.button_volver.Text = "  Volver";
            this.button_volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.Button_volver_Click);
            // 
            // FormAñadirSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(919, 512);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_alto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ancho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_añadir);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_secY);
            this.Controls.Add(this.label_tiempoCiclo);
            this.Controls.Add(this.label_nuevaV);
            this.Controls.Add(this.textBox_capacidad);
            this.Controls.Add(this.textBox_secX);
            this.Controls.Add(this.label_tiempoSimulacion);
            this.Name = "FormAñadirSector";
            this.Text = "FormAñadirSector";
            this.Load += new System.EventHandler(this.FormAñadirSector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_añadir;
        private System.Windows.Forms.TextBox textBox_secY;
        private System.Windows.Forms.Label label_nuevaV;
        private System.Windows.Forms.TextBox textBox_secX;
        private System.Windows.Forms.Label label_tiempoSimulacion;
        private System.Windows.Forms.TextBox textBox_capacidad;
        private System.Windows.Forms.Label label_tiempoCiclo;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_ancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_alto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_volver;
    }
}