namespace WindowsFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.textBox_countTest = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelMenuIz = new System.Windows.Forms.Panel();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_ajustes = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_baseDatos = new System.Windows.Forms.Button();
            this.button_ampInd = new System.Windows.Forms.Button();
            this.panelSimSubMenu = new System.Windows.Forms.Panel();
            this.button_simAuto = new System.Windows.Forms.Button();
            this.button_simManual = new System.Windows.Forms.Button();
            this.button_menuSim = new System.Windows.Forms.Button();
            this.button_listaVuelos = new System.Windows.Forms.Button();
            this.panelCargarSubMenu = new System.Windows.Forms.Panel();
            this.button_añadirSector = new System.Windows.Forms.Button();
            this.button_guardarVuelos = new System.Windows.Forms.Button();
            this.button_cargarSector = new System.Windows.Forms.Button();
            this.button_cargarVuelos = new System.Windows.Forms.Button();
            this.button_menuCargar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_reanudar = new System.Windows.Forms.PictureBox();
            this.textBox_tiempoCiclo = new System.Windows.Forms.TextBox();
            this.label_tiempoCiclo = new System.Windows.Forms.Label();
            this.textBox_tiempoSimulacion = new System.Windows.Forms.TextBox();
            this.button_avanzar = new System.Windows.Forms.PictureBox();
            this.button_retroceder = new System.Windows.Forms.PictureBox();
            this.label_tiempoSimulacion = new System.Windows.Forms.Label();
            this.button_reiniciar = new System.Windows.Forms.PictureBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_pausar = new System.Windows.Forms.PictureBox();
            this.label_tiempoTotal = new System.Windows.Forms.Label();
            this.label_nuevaV = new System.Windows.Forms.Label();
            this.label_tiempoActual = new System.Windows.Forms.Label();
            this.textBox_v = new System.Windows.Forms.TextBox();
            this.progressBar_sim = new System.Windows.Forms.ProgressBar();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_aplicar = new System.Windows.Forms.Button();
            this.button_iniciar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panelControlesPrincipal = new System.Windows.Forms.Panel();
            this.panelSubForm.SuspendLayout();
            this.panelMenuIz.SuspendLayout();
            this.panelSimSubMenu.SuspendLayout();
            this.panelCargarSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_reanudar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_avanzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_retroceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_reiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_iniciar)).BeginInit();
            this.panelControlesPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubForm
            // 
            this.panelSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.panelSubForm.Controls.Add(this.textBox_countTest);
            this.panelSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSubForm.Location = new System.Drawing.Point(230, 0);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(1034, 681);
            this.panelSubForm.TabIndex = 1;
            this.panelSubForm.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // textBox_countTest
            // 
            this.textBox_countTest.Location = new System.Drawing.Point(56, 12);
            this.textBox_countTest.Name = "textBox_countTest";
            this.textBox_countTest.Size = new System.Drawing.Size(106, 22);
            this.textBox_countTest.TabIndex = 17;
            // 
            // panelMenuIz
            // 
            this.panelMenuIz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuIz.Controls.Add(this.button_salir);
            this.panelMenuIz.Controls.Add(this.button_ajustes);
            this.panelMenuIz.Controls.Add(this.button_info);
            this.panelMenuIz.Controls.Add(this.button_baseDatos);
            this.panelMenuIz.Controls.Add(this.button_ampInd);
            this.panelMenuIz.Controls.Add(this.panelSimSubMenu);
            this.panelMenuIz.Controls.Add(this.button_menuSim);
            this.panelMenuIz.Controls.Add(this.button_listaVuelos);
            this.panelMenuIz.Controls.Add(this.panelCargarSubMenu);
            this.panelMenuIz.Controls.Add(this.button_menuCargar);
            this.panelMenuIz.Controls.Add(this.panelLogo);
            this.panelMenuIz.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIz.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIz.Name = "panelMenuIz";
            this.panelMenuIz.Size = new System.Drawing.Size(230, 681);
            this.panelMenuIz.TabIndex = 1;
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_salir.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_salir.FlatAppearance.BorderSize = 0;
            this.button_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.ForeColor = System.Drawing.Color.Silver;
            this.button_salir.Image = ((System.Drawing.Image)(resources.GetObject("button_salir.Image")));
            this.button_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salir.Location = new System.Drawing.Point(0, 647);
            this.button_salir.Name = "button_salir";
            this.button_salir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_salir.Size = new System.Drawing.Size(230, 45);
            this.button_salir.TabIndex = 14;
            this.button_salir.Text = "  Salir";
            this.button_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.Button_salir_Click);
            this.button_salir.MouseEnter += new System.EventHandler(this.Button_salir_MouseEnter);
            // 
            // button_ajustes
            // 
            this.button_ajustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_ajustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ajustes.FlatAppearance.BorderSize = 0;
            this.button_ajustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajustes.ForeColor = System.Drawing.Color.Silver;
            this.button_ajustes.Image = ((System.Drawing.Image)(resources.GetObject("button_ajustes.Image")));
            this.button_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajustes.Location = new System.Drawing.Point(0, 602);
            this.button_ajustes.Name = "button_ajustes";
            this.button_ajustes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_ajustes.Size = new System.Drawing.Size(230, 45);
            this.button_ajustes.TabIndex = 13;
            this.button_ajustes.Text = "  Ajustes";
            this.button_ajustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ajustes.UseVisualStyleBackColor = false;
            this.button_ajustes.Click += new System.EventHandler(this.Button_ajustes_Click);
            this.button_ajustes.MouseEnter += new System.EventHandler(this.Button_ajustes_MouseEnter);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_info.FlatAppearance.BorderSize = 0;
            this.button_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info.ForeColor = System.Drawing.Color.Silver;
            this.button_info.Image = ((System.Drawing.Image)(resources.GetObject("button_info.Image")));
            this.button_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_info.Location = new System.Drawing.Point(0, 557);
            this.button_info.Name = "button_info";
            this.button_info.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_info.Size = new System.Drawing.Size(230, 45);
            this.button_info.TabIndex = 11;
            this.button_info.Text = "  Información";
            this.button_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.Button_info_Click);
            this.button_info.MouseEnter += new System.EventHandler(this.Button_info_MouseEnter);
            // 
            // button_baseDatos
            // 
            this.button_baseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_baseDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_baseDatos.FlatAppearance.BorderSize = 0;
            this.button_baseDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_baseDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_baseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_baseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baseDatos.ForeColor = System.Drawing.Color.Silver;
            this.button_baseDatos.Image = ((System.Drawing.Image)(resources.GetObject("button_baseDatos.Image")));
            this.button_baseDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baseDatos.Location = new System.Drawing.Point(0, 512);
            this.button_baseDatos.Name = "button_baseDatos";
            this.button_baseDatos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_baseDatos.Size = new System.Drawing.Size(230, 45);
            this.button_baseDatos.TabIndex = 10;
            this.button_baseDatos.Text = "  Base de datos";
            this.button_baseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_baseDatos.UseVisualStyleBackColor = false;
            this.button_baseDatos.Click += new System.EventHandler(this.Button_baseDatos_Click);
            this.button_baseDatos.MouseEnter += new System.EventHandler(this.Button_otros_MouseEnter);
            // 
            // button_ampInd
            // 
            this.button_ampInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_ampInd.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ampInd.FlatAppearance.BorderSize = 0;
            this.button_ampInd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_ampInd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_ampInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ampInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ampInd.ForeColor = System.Drawing.Color.Silver;
            this.button_ampInd.Image = ((System.Drawing.Image)(resources.GetObject("button_ampInd.Image")));
            this.button_ampInd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ampInd.Location = new System.Drawing.Point(0, 467);
            this.button_ampInd.Name = "button_ampInd";
            this.button_ampInd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_ampInd.Size = new System.Drawing.Size(230, 45);
            this.button_ampInd.TabIndex = 9;
            this.button_ampInd.Text = "  Ampliación individual";
            this.button_ampInd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ampInd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ampInd.UseVisualStyleBackColor = false;
            this.button_ampInd.Click += new System.EventHandler(this.Button_ampInd_Click);
            this.button_ampInd.MouseEnter += new System.EventHandler(this.Button_ampInd_MouseEnter);
            // 
            // panelSimSubMenu
            // 
            this.panelSimSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSimSubMenu.Controls.Add(this.button_simAuto);
            this.panelSimSubMenu.Controls.Add(this.button_simManual);
            this.panelSimSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSimSubMenu.Location = new System.Drawing.Point(0, 387);
            this.panelSimSubMenu.Name = "panelSimSubMenu";
            this.panelSimSubMenu.Size = new System.Drawing.Size(230, 80);
            this.panelSimSubMenu.TabIndex = 6;
            // 
            // button_simAuto
            // 
            this.button_simAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_simAuto.FlatAppearance.BorderSize = 0;
            this.button_simAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_simAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_simAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simAuto.ForeColor = System.Drawing.Color.Silver;
            this.button_simAuto.Location = new System.Drawing.Point(0, 40);
            this.button_simAuto.Name = "button_simAuto";
            this.button_simAuto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_simAuto.Size = new System.Drawing.Size(230, 40);
            this.button_simAuto.TabIndex = 1;
            this.button_simAuto.Text = "Automática";
            this.button_simAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simAuto.UseVisualStyleBackColor = true;
            this.button_simAuto.Click += new System.EventHandler(this.Button_simAuto_Click);
            this.button_simAuto.MouseEnter += new System.EventHandler(this.Button_simAuto_MouseEnter);
            // 
            // button_simManual
            // 
            this.button_simManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_simManual.FlatAppearance.BorderSize = 0;
            this.button_simManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_simManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_simManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simManual.ForeColor = System.Drawing.Color.Silver;
            this.button_simManual.Location = new System.Drawing.Point(0, 0);
            this.button_simManual.Name = "button_simManual";
            this.button_simManual.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_simManual.Size = new System.Drawing.Size(230, 40);
            this.button_simManual.TabIndex = 0;
            this.button_simManual.Text = "Manual";
            this.button_simManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simManual.UseVisualStyleBackColor = true;
            this.button_simManual.Click += new System.EventHandler(this.Button_simManual_Click);
            this.button_simManual.MouseEnter += new System.EventHandler(this.Button_simManual_MouseEnter);
            // 
            // button_menuSim
            // 
            this.button_menuSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_menuSim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menuSim.FlatAppearance.BorderSize = 0;
            this.button_menuSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_menuSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_menuSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menuSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menuSim.ForeColor = System.Drawing.Color.Silver;
            this.button_menuSim.Image = ((System.Drawing.Image)(resources.GetObject("button_menuSim.Image")));
            this.button_menuSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menuSim.Location = new System.Drawing.Point(0, 342);
            this.button_menuSim.Name = "button_menuSim";
            this.button_menuSim.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_menuSim.Size = new System.Drawing.Size(230, 45);
            this.button_menuSim.TabIndex = 5;
            this.button_menuSim.Text = "  Simulación";
            this.button_menuSim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menuSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menuSim.UseVisualStyleBackColor = false;
            this.button_menuSim.Click += new System.EventHandler(this.Button_menuSim_Click);
            this.button_menuSim.MouseEnter += new System.EventHandler(this.Button_menuSim_MouseEnter);
            // 
            // button_listaVuelos
            // 
            this.button_listaVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_listaVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_listaVuelos.FlatAppearance.BorderSize = 0;
            this.button_listaVuelos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_listaVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_listaVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_listaVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listaVuelos.ForeColor = System.Drawing.Color.Silver;
            this.button_listaVuelos.Image = ((System.Drawing.Image)(resources.GetObject("button_listaVuelos.Image")));
            this.button_listaVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_listaVuelos.Location = new System.Drawing.Point(0, 297);
            this.button_listaVuelos.Name = "button_listaVuelos";
            this.button_listaVuelos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_listaVuelos.Size = new System.Drawing.Size(230, 45);
            this.button_listaVuelos.TabIndex = 4;
            this.button_listaVuelos.Text = "  Listar vuelos";
            this.button_listaVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_listaVuelos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_listaVuelos.UseVisualStyleBackColor = false;
            this.button_listaVuelos.Click += new System.EventHandler(this.Button_listaVuelos_Click);
            this.button_listaVuelos.MouseEnter += new System.EventHandler(this.Button_listaVuelos_MouseEnter);
            // 
            // panelCargarSubMenu
            // 
            this.panelCargarSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCargarSubMenu.Controls.Add(this.button_añadirSector);
            this.panelCargarSubMenu.Controls.Add(this.button_guardarVuelos);
            this.panelCargarSubMenu.Controls.Add(this.button_cargarSector);
            this.panelCargarSubMenu.Controls.Add(this.button_cargarVuelos);
            this.panelCargarSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCargarSubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelCargarSubMenu.Name = "panelCargarSubMenu";
            this.panelCargarSubMenu.Size = new System.Drawing.Size(230, 160);
            this.panelCargarSubMenu.TabIndex = 3;
            // 
            // button_añadirSector
            // 
            this.button_añadirSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_añadirSector.FlatAppearance.BorderSize = 0;
            this.button_añadirSector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_añadirSector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_añadirSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_añadirSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_añadirSector.ForeColor = System.Drawing.Color.Silver;
            this.button_añadirSector.Location = new System.Drawing.Point(0, 120);
            this.button_añadirSector.Name = "button_añadirSector";
            this.button_añadirSector.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_añadirSector.Size = new System.Drawing.Size(230, 40);
            this.button_añadirSector.TabIndex = 3;
            this.button_añadirSector.Text = "Añadir Sector";
            this.button_añadirSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_añadirSector.UseVisualStyleBackColor = true;
            this.button_añadirSector.Click += new System.EventHandler(this.Button_añadirSector_Click);
            // 
            // button_guardarVuelos
            // 
            this.button_guardarVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_guardarVuelos.FlatAppearance.BorderSize = 0;
            this.button_guardarVuelos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_guardarVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_guardarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guardarVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardarVuelos.ForeColor = System.Drawing.Color.Silver;
            this.button_guardarVuelos.Location = new System.Drawing.Point(0, 80);
            this.button_guardarVuelos.Name = "button_guardarVuelos";
            this.button_guardarVuelos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_guardarVuelos.Size = new System.Drawing.Size(230, 40);
            this.button_guardarVuelos.TabIndex = 2;
            this.button_guardarVuelos.Text = "Guardar vuelos";
            this.button_guardarVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardarVuelos.UseVisualStyleBackColor = true;
            this.button_guardarVuelos.Click += new System.EventHandler(this.Button_guardarVuelos_Click);
            this.button_guardarVuelos.MouseEnter += new System.EventHandler(this.Button_guardarVuelos_MouseEnter);
            // 
            // button_cargarSector
            // 
            this.button_cargarSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cargarSector.FlatAppearance.BorderSize = 0;
            this.button_cargarSector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_cargarSector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_cargarSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargarSector.ForeColor = System.Drawing.Color.Silver;
            this.button_cargarSector.Location = new System.Drawing.Point(0, 40);
            this.button_cargarSector.Name = "button_cargarSector";
            this.button_cargarSector.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_cargarSector.Size = new System.Drawing.Size(230, 40);
            this.button_cargarSector.TabIndex = 1;
            this.button_cargarSector.Text = "Cargar sectores";
            this.button_cargarSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cargarSector.UseVisualStyleBackColor = true;
            this.button_cargarSector.Click += new System.EventHandler(this.Button_cargarSector_Click);
            this.button_cargarSector.MouseEnter += new System.EventHandler(this.Button_cargarSector_MouseEnter);
            // 
            // button_cargarVuelos
            // 
            this.button_cargarVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cargarVuelos.FlatAppearance.BorderSize = 0;
            this.button_cargarVuelos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_cargarVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_cargarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargarVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargarVuelos.ForeColor = System.Drawing.Color.Silver;
            this.button_cargarVuelos.Location = new System.Drawing.Point(0, 0);
            this.button_cargarVuelos.Name = "button_cargarVuelos";
            this.button_cargarVuelos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_cargarVuelos.Size = new System.Drawing.Size(230, 40);
            this.button_cargarVuelos.TabIndex = 0;
            this.button_cargarVuelos.Text = "Cargar vuelos";
            this.button_cargarVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cargarVuelos.UseVisualStyleBackColor = true;
            this.button_cargarVuelos.Click += new System.EventHandler(this.Button_cargarVuelos_Click);
            this.button_cargarVuelos.MouseEnter += new System.EventHandler(this.Button_cargarVuelos_MouseEnter);
            // 
            // button_menuCargar
            // 
            this.button_menuCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button_menuCargar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menuCargar.FlatAppearance.BorderSize = 0;
            this.button_menuCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_menuCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button_menuCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menuCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menuCargar.ForeColor = System.Drawing.Color.Silver;
            this.button_menuCargar.Image = ((System.Drawing.Image)(resources.GetObject("button_menuCargar.Image")));
            this.button_menuCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menuCargar.Location = new System.Drawing.Point(0, 92);
            this.button_menuCargar.Name = "button_menuCargar";
            this.button_menuCargar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_menuCargar.Size = new System.Drawing.Size(230, 45);
            this.button_menuCargar.TabIndex = 2;
            this.button_menuCargar.Text = "  Cargar/Guardar";
            this.button_menuCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menuCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menuCargar.UseVisualStyleBackColor = false;
            this.button_menuCargar.Click += new System.EventHandler(this.Button_menuCargar_Click);
            this.button_menuCargar.MouseEnter += new System.EventHandler(this.Button_menuCargar_MouseEnter);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 92);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button_reanudar
            // 
            this.button_reanudar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_reanudar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reanudar.Image = ((System.Drawing.Image)(resources.GetObject("button_reanudar.Image")));
            this.button_reanudar.Location = new System.Drawing.Point(377, 45);
            this.button_reanudar.Name = "button_reanudar";
            this.button_reanudar.Size = new System.Drawing.Size(32, 32);
            this.button_reanudar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_reanudar.TabIndex = 17;
            this.button_reanudar.TabStop = false;
            this.button_reanudar.Click += new System.EventHandler(this.Button_reanudar_Click);
            // 
            // textBox_tiempoCiclo
            // 
            this.textBox_tiempoCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_tiempoCiclo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tiempoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tiempoCiclo.ForeColor = System.Drawing.Color.Silver;
            this.textBox_tiempoCiclo.Location = new System.Drawing.Point(34, 37);
            this.textBox_tiempoCiclo.MaximumSize = new System.Drawing.Size(120, 50);
            this.textBox_tiempoCiclo.Multiline = true;
            this.textBox_tiempoCiclo.Name = "textBox_tiempoCiclo";
            this.textBox_tiempoCiclo.Size = new System.Drawing.Size(120, 24);
            this.textBox_tiempoCiclo.TabIndex = 7;
            // 
            // label_tiempoCiclo
            // 
            this.label_tiempoCiclo.AutoSize = true;
            this.label_tiempoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoCiclo.ForeColor = System.Drawing.Color.Silver;
            this.label_tiempoCiclo.Location = new System.Drawing.Point(31, 17);
            this.label_tiempoCiclo.Name = "label_tiempoCiclo";
            this.label_tiempoCiclo.Size = new System.Drawing.Size(137, 16);
            this.label_tiempoCiclo.TabIndex = 8;
            this.label_tiempoCiclo.Text = "Tiempo de ciclo (min)";
            // 
            // textBox_tiempoSimulacion
            // 
            this.textBox_tiempoSimulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_tiempoSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tiempoSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tiempoSimulacion.ForeColor = System.Drawing.Color.Silver;
            this.textBox_tiempoSimulacion.Location = new System.Drawing.Point(33, 101);
            this.textBox_tiempoSimulacion.Multiline = true;
            this.textBox_tiempoSimulacion.Name = "textBox_tiempoSimulacion";
            this.textBox_tiempoSimulacion.Size = new System.Drawing.Size(120, 24);
            this.textBox_tiempoSimulacion.TabIndex = 14;
            // 
            // button_avanzar
            // 
            this.button_avanzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_avanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_avanzar.Image = ((System.Drawing.Image)(resources.GetObject("button_avanzar.Image")));
            this.button_avanzar.Location = new System.Drawing.Point(415, 45);
            this.button_avanzar.Name = "button_avanzar";
            this.button_avanzar.Size = new System.Drawing.Size(32, 32);
            this.button_avanzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_avanzar.TabIndex = 13;
            this.button_avanzar.TabStop = false;
            this.button_avanzar.Click += new System.EventHandler(this.Button_avanzar_Click);
            // 
            // button_retroceder
            // 
            this.button_retroceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_retroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_retroceder.Image = ((System.Drawing.Image)(resources.GetObject("button_retroceder.Image")));
            this.button_retroceder.Location = new System.Drawing.Point(339, 45);
            this.button_retroceder.Name = "button_retroceder";
            this.button_retroceder.Size = new System.Drawing.Size(32, 32);
            this.button_retroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_retroceder.TabIndex = 14;
            this.button_retroceder.TabStop = false;
            this.button_retroceder.Click += new System.EventHandler(this.Button_retroceder_Click);
            // 
            // label_tiempoSimulacion
            // 
            this.label_tiempoSimulacion.AutoSize = true;
            this.label_tiempoSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoSimulacion.ForeColor = System.Drawing.Color.Silver;
            this.label_tiempoSimulacion.Location = new System.Drawing.Point(31, 82);
            this.label_tiempoSimulacion.Name = "label_tiempoSimulacion";
            this.label_tiempoSimulacion.Size = new System.Drawing.Size(173, 16);
            this.label_tiempoSimulacion.TabIndex = 15;
            this.label_tiempoSimulacion.Text = "Tiempo de simulación (min)";
            // 
            // button_reiniciar
            // 
            this.button_reiniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_reiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reiniciar.Image = ((System.Drawing.Image)(resources.GetObject("button_reiniciar.Image")));
            this.button_reiniciar.Location = new System.Drawing.Point(469, 45);
            this.button_reiniciar.Name = "button_reiniciar";
            this.button_reiniciar.Size = new System.Drawing.Size(32, 32);
            this.button_reiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_reiniciar.TabIndex = 15;
            this.button_reiniciar.TabStop = false;
            this.button_reiniciar.Click += new System.EventHandler(this.Button_reiniciar_click);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.ForeColor = System.Drawing.Color.Silver;
            this.textBox_id.Location = new System.Drawing.Point(213, 37);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(120, 24);
            this.textBox_id.TabIndex = 2;
            // 
            // button_pausar
            // 
            this.button_pausar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_pausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pausar.Image = ((System.Drawing.Image)(resources.GetObject("button_pausar.Image")));
            this.button_pausar.Location = new System.Drawing.Point(377, 46);
            this.button_pausar.Name = "button_pausar";
            this.button_pausar.Size = new System.Drawing.Size(32, 32);
            this.button_pausar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_pausar.TabIndex = 16;
            this.button_pausar.TabStop = false;
            this.button_pausar.Click += new System.EventHandler(this.Button_pausar_Click);
            // 
            // label_tiempoTotal
            // 
            this.label_tiempoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tiempoTotal.AutoSize = true;
            this.label_tiempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoTotal.ForeColor = System.Drawing.Color.LightGray;
            this.label_tiempoTotal.Location = new System.Drawing.Point(869, 45);
            this.label_tiempoTotal.Name = "label_tiempoTotal";
            this.label_tiempoTotal.Size = new System.Drawing.Size(39, 16);
            this.label_tiempoTotal.TabIndex = 20;
            this.label_tiempoTotal.Text = "00:00";
            // 
            // label_nuevaV
            // 
            this.label_nuevaV.AutoSize = true;
            this.label_nuevaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevaV.ForeColor = System.Drawing.Color.Silver;
            this.label_nuevaV.Location = new System.Drawing.Point(211, 83);
            this.label_nuevaV.Name = "label_nuevaV";
            this.label_nuevaV.Size = new System.Drawing.Size(113, 16);
            this.label_nuevaV.TabIndex = 6;
            this.label_nuevaV.Text = "Nueva Velocidad";
            // 
            // label_tiempoActual
            // 
            this.label_tiempoActual.AutoSize = true;
            this.label_tiempoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoActual.ForeColor = System.Drawing.Color.LightGray;
            this.label_tiempoActual.Location = new System.Drawing.Point(823, 45);
            this.label_tiempoActual.Name = "label_tiempoActual";
            this.label_tiempoActual.Size = new System.Drawing.Size(39, 16);
            this.label_tiempoActual.TabIndex = 22;
            this.label_tiempoActual.Text = "00:00";
            // 
            // textBox_v
            // 
            this.textBox_v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.textBox_v.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_v.ForeColor = System.Drawing.Color.Silver;
            this.textBox_v.Location = new System.Drawing.Point(213, 102);
            this.textBox_v.Multiline = true;
            this.textBox_v.Name = "textBox_v";
            this.textBox_v.Size = new System.Drawing.Size(120, 24);
            this.textBox_v.TabIndex = 3;
            // 
            // progressBar_sim
            // 
            this.progressBar_sim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_sim.Location = new System.Drawing.Point(339, 32);
            this.progressBar_sim.Name = "progressBar_sim";
            this.progressBar_sim.Size = new System.Drawing.Size(567, 5);
            this.progressBar_sim.TabIndex = 24;
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
            this.button_volver.Location = new System.Drawing.Point(906, 95);
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
            // button_aplicar
            // 
            this.button_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aplicar.ForeColor = System.Drawing.Color.Silver;
            this.button_aplicar.Location = new System.Drawing.Point(341, 89);
            this.button_aplicar.Margin = new System.Windows.Forms.Padding(2);
            this.button_aplicar.Name = "button_aplicar";
            this.button_aplicar.Size = new System.Drawing.Size(106, 40);
            this.button_aplicar.TabIndex = 4;
            this.button_aplicar.Text = "Aplicar";
            this.button_aplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_aplicar.UseVisualStyleBackColor = true;
            this.button_aplicar.Click += new System.EventHandler(this.Button_aplicar_Click);
            // 
            // button_iniciar
            // 
            this.button_iniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iniciar.Image = ((System.Drawing.Image)(resources.GetObject("button_iniciar.Image")));
            this.button_iniciar.Location = new System.Drawing.Point(377, 45);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(32, 32);
            this.button_iniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_iniciar.TabIndex = 12;
            this.button_iniciar.TabStop = false;
            this.button_iniciar.Click += new System.EventHandler(this.Button_iniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(860, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "/";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(211, 18);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 16);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "ID";
            // 
            // panelControlesPrincipal
            // 
            this.panelControlesPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelControlesPrincipal.Controls.Add(this.label_id);
            this.panelControlesPrincipal.Controls.Add(this.label3);
            this.panelControlesPrincipal.Controls.Add(this.button_iniciar);
            this.panelControlesPrincipal.Controls.Add(this.button_aplicar);
            this.panelControlesPrincipal.Controls.Add(this.button_volver);
            this.panelControlesPrincipal.Controls.Add(this.progressBar_sim);
            this.panelControlesPrincipal.Controls.Add(this.textBox_v);
            this.panelControlesPrincipal.Controls.Add(this.label_tiempoActual);
            this.panelControlesPrincipal.Controls.Add(this.label_nuevaV);
            this.panelControlesPrincipal.Controls.Add(this.label_tiempoTotal);
            this.panelControlesPrincipal.Controls.Add(this.button_pausar);
            this.panelControlesPrincipal.Controls.Add(this.textBox_id);
            this.panelControlesPrincipal.Controls.Add(this.button_reiniciar);
            this.panelControlesPrincipal.Controls.Add(this.label_tiempoSimulacion);
            this.panelControlesPrincipal.Controls.Add(this.button_retroceder);
            this.panelControlesPrincipal.Controls.Add(this.button_avanzar);
            this.panelControlesPrincipal.Controls.Add(this.textBox_tiempoSimulacion);
            this.panelControlesPrincipal.Controls.Add(this.label_tiempoCiclo);
            this.panelControlesPrincipal.Controls.Add(this.textBox_tiempoCiclo);
            this.panelControlesPrincipal.Controls.Add(this.button_reanudar);
            this.panelControlesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlesPrincipal.Location = new System.Drawing.Point(230, 529);
            this.panelControlesPrincipal.Name = "panelControlesPrincipal";
            this.panelControlesPrincipal.Size = new System.Drawing.Size(1034, 152);
            this.panelControlesPrincipal.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelControlesPrincipal);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.panelMenuIz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 580);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelSubForm.ResumeLayout(false);
            this.panelSubForm.PerformLayout();
            this.panelMenuIz.ResumeLayout(false);
            this.panelSimSubMenu.ResumeLayout(false);
            this.panelCargarSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_reanudar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_avanzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_retroceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_reiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_iniciar)).EndInit();
            this.panelControlesPrincipal.ResumeLayout(false);
            this.panelControlesPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panelSubForm;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelMenuIz;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox_countTest;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelCargarSubMenu;
        private System.Windows.Forms.Button button_guardarVuelos;
        private System.Windows.Forms.Button button_cargarSector;
        private System.Windows.Forms.Button button_cargarVuelos;
        private System.Windows.Forms.Button button_menuCargar;
        private System.Windows.Forms.Panel panelSimSubMenu;
        private System.Windows.Forms.Button button_simManual;
        private System.Windows.Forms.Button button_menuSim;
        private System.Windows.Forms.Button button_listaVuelos;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_baseDatos;
        private System.Windows.Forms.Button button_ampInd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_ajustes;
        private System.Windows.Forms.Button button_simAuto;
        private System.Windows.Forms.PictureBox button_reanudar;
        private System.Windows.Forms.TextBox textBox_tiempoCiclo;
        private System.Windows.Forms.Label label_tiempoCiclo;
        private System.Windows.Forms.TextBox textBox_tiempoSimulacion;
        private System.Windows.Forms.PictureBox button_avanzar;
        private System.Windows.Forms.PictureBox button_retroceder;
        private System.Windows.Forms.Label label_tiempoSimulacion;
        private System.Windows.Forms.PictureBox button_reiniciar;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.PictureBox button_pausar;
        private System.Windows.Forms.Label label_tiempoTotal;
        private System.Windows.Forms.Label label_nuevaV;
        private System.Windows.Forms.Label label_tiempoActual;
        private System.Windows.Forms.TextBox textBox_v;
        private System.Windows.Forms.ProgressBar progressBar_sim;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_aplicar;
        private System.Windows.Forms.PictureBox button_iniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panelControlesPrincipal;
        private System.Windows.Forms.Button button_añadirSector;
    }
}

