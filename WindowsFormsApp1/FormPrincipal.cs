using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using LibVuelos;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        ListaSectores objListaSec = new ListaSectores();
        Sector objSector = new Sector();
        ListaVuelos objLista = new ListaVuelos();
        Ajustes objAjustes = new Ajustes();

        PictureBox[] aircraft_vector;
        PictureBox[] sectors_vector;
        PictureBox[] airport_vector;

        Stack<List<List<int>>> deshacerSim = new Stack<List<List<int>>>();
        int ciclos = 0;     // Contador de ciclos de la simulación automática
        bool cargarVuelos = false;
        bool cargarSectores = false;
        bool simulacionFinalizada = false;

        public FormPrincipal()
        {
            InitializeComponent();
            mciSendString(@"open ..\..\..\UI\sonidos\MouseOver_button.wav type waveaudio alias MouseOver_button", null, 0, IntPtr.Zero);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Comprobamos que los directorios y ficheros existen y se pueden abrir
            // Vuelos.vue
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\Datos\Vuelos.vue"))
                {
                    //MessageBox.Show("Fichero de vuelos leído correctamente");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el archivo: '{ex}'");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el directorio: '{ex}'");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"No se ha podido abrir el archivo: '{ex}'");
            }

            // Sectores.sec
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\Datos\Sectores.sec"))
                {
                    //MessageBox.Show("Fichero de sectores leído correctamente");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el archivo: '{ex}'");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el directorio: '{ex}'");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"No se ha podido abrir el archivo: '{ex}'");
            }

            // Ajustes.ini
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\Datos\Ajustes.ini"))
                {
                    //MessageBox.Show("Fichero de ajustes leído correctamente");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el archivo: '{ex}'");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"No se ha encontrado el directorio: '{ex}'");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"No se ha podido abrir el archivo: '{ex}'");
            }

            EsconderSubMenu();

            panelControlesPrincipal.Controls.Clear();
            panelSubForm.Controls.Remove(textBox_countTest);

            objAjustes.CargarAjustes();
        }

        // Oculta las subopciones del panelMenuIz
        private void EsconderSubMenu()
        {
            panelCargarSubMenu.Visible = false;
            panelSimSubMenu.Visible = false;
        }

        // Muestra las subopciones del panelMenuIz
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Muestra los forms secundarios en el panelSubForm en vez de abrirlos en otra ventana
        public Form activeForm = null;
        private void AbrirSubForm(Form subForm)
        {
            FormPrincipal fp = new FormPrincipal();

            FormAjustes fa = new FormAjustes(objAjustes, airport_vector, cargarVuelos);
            FormBaseDatos fbd = new FormBaseDatos();
            FormDatosSector fds = new FormDatosSector(objSector, objLista, aircraft_vector);
            FormDatosVuelo fdv = new FormDatosVuelo();
            FormListaVuelos flv = new FormListaVuelos();
            FormAñadirSector fas = new FormAñadirSector();
            FormInfo fi = new FormInfo();

            if (activeForm != null)     // Si hay un form abierto previamente, se cierra
                activeForm.Close();

            activeForm = subForm;       // Se asigna como form activo el que se va a abrir

            subForm.TopLevel = false;

            // Como deben abrirse los distintos Forms
            if (subForm.Name == fa.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
            }
            else if (subForm.Name == fbd.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
            }
            else if (subForm.Name == fds.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Bottom;
            }
            else if (subForm.Name == fdv.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Right;
            }
            else if (subForm.Name == flv.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
            }
            else if (subForm.Name == fas.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
            }
            else if (subForm.Name == fi.Name)
            {
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
            }

            panelSubForm.Controls.Add(subForm);
            panelControlesPrincipal.Visible = false;

            panelSubForm.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
        }


        //============================= MENÚ ==================================//
        private void Button_menuCargar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelCargarSubMenu);
        }

        // Subopciones del botón Cargar del panelMenuIz
        #region CargarSubMenu       
        private void Button_cargarVuelos_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Seleccione el fichero";
            openFileDialog.InitialDirectory = @"..\..\..\Datos\";
            openFileDialog.Filter = "txt files (*.vue)|*.vue|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string loadPath = openFileDialog.FileName;      // Seleccionar ruta de fichero
                objLista.CargarVuelos(loadPath);

                aircraft_vector = new PictureBox[objLista.GetCount()];      // Determina el largo del aircraft_vector
                
                panelSubForm.Controls.Clear();      // Borra el vector de pictureBox y repinta el panel

                for (int i = 0; i < objLista.GetCount(); i++)
                {
                    aircraft_vector[i] = new PictureBox();
                    aircraft_vector[i].BackColor = Color.Transparent;
                    aircraft_vector[i].ClientSize = new Size(50, 50);
                    aircraft_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()), Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));
                    aircraft_vector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap image = new Bitmap("plane.png");
                    aircraft_vector[i].Image = (Image)image;
                    panelSubForm.Controls.Add(aircraft_vector[i]);
                    aircraft_vector[i].Tag = i;
                    aircraft_vector[i].Click += new EventHandler(this.aircraft_vector_Click);
                }

                airport_vector = new PictureBox[objLista.GetCount() * 2];      // Determina el largo del airport_vector

                for (int i = 0; i < 4; i++)
                {
                    airport_vector[i] = new PictureBox();
                    airport_vector[i].Location = new Point(Convert.ToInt32(objLista.GetReiniciar(i, 0)), Convert.ToInt32(objLista.GetReiniciar(i, 1)));
                    airport_vector[i].Size = new Size(30, 30);
                    airport_vector[i].BackColor = Color.Transparent;
                    airport_vector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap image = new Bitmap("icons8_runway_30px_1.png");
                    airport_vector[i].Image = (Image)image;
                    panelSubForm.Controls.Add(airport_vector[i]);
                }

                for (int i = 4; i < 8; i++)
                {
                    airport_vector[i] = new PictureBox();
                    airport_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i/2).GetPosXf()), Convert.ToInt32(objLista.GetVuelo(i/2).GetPosYf()));
                    airport_vector[i].Size = new Size(30, 30);
                    airport_vector[i].BackColor = Color.Transparent;
                    airport_vector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap image = new Bitmap("icons8_runway_30px_1.png");
                    airport_vector[i].Image = (Image)image;
                    panelSubForm.Controls.Add(airport_vector[i]);
                }
                cargarVuelos = true;
                MostrarAeropuertos(airport_vector, cargarVuelos, objAjustes);
                EsconderSubMenu();
            }
            else
            {
                MessageBox.Show("Ha habido un error al cargar el fichero.");
            }
        }

        // Muestra los datos del vuelo pulsado
        private void aircraft_vector_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            FormDatosVuelo fd = new FormDatosVuelo();

            fd.SetVuelo(objLista.GetVuelo(i));

            fd.Text = "Datos " + objLista.GetVuelo(i).GetId();
            fd.Size = new Size(250, 300);
            AbrirSubForm(fd);

            //fd.ShowDialog();      //esto abriria FormDatos en una ventana diferente
        }

        private void Button_cargarSector_Click(object sender, EventArgs e)
        {
            //Estas 2 lineas muestran la cantidad de vuelos de la lista por pantalla (para pruebas)
            //panelSubForm.Controls.Add(textBox_countTest);
            //textBox_countTest.Text = Convert.ToString(objLista.GetCount());

            openFileDialog.Title = "Seleccione el fichero";
            openFileDialog.InitialDirectory = @"..\..\..\Datos\";
            openFileDialog.Filter = "txt files (*.sec)|*.sec|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sectorPath = openFileDialog.FileName;        // Pide al usuario que seleccione el fichero de sectores
                objListaSec.CargarSector(sectorPath);

                sectors_vector = new PictureBox[objListaSec.GetCountSectores()];

                for (int i = 0; i < objListaSec.GetCountSectores(); i++)
                {
                    sectors_vector[i] = new PictureBox();
                    sectors_vector[i].BackColor = Color.Transparent;
                    sectors_vector[i].ClientSize = new Size(Convert.ToInt32(objListaSec.GetSector(i).GetAncho()), Convert.ToInt32(objListaSec.GetSector(i).GetAlto()));
                    sectors_vector[i].Location = new Point(objListaSec.GetSector(i).GetSecX(), objListaSec.GetSector(i).GetSecY());
                    sectors_vector[i].SizeMode = PictureBoxSizeMode.StretchImage;

                    panelSubForm.Controls.Add(sectors_vector[i]);
                    sectors_vector[i].Tag = i;
                    sectors_vector[i].Click += new EventHandler(this.sectores_vector_Click);
                }
                MostrarOcupacion();

                panelSubForm.Invalidate();      // Redibuja el panel
                EsconderSubMenu();      // Esconde los submenus que haya abiertos

                cargarSectores = true;
            }
            else
            {
                MessageBox.Show("Ha habido un error al cargar el fichero.");
            }
        }

        private void sectores_vector_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            FormDatosSector fds = new FormDatosSector(objListaSec.GetSector(i), objLista, aircraft_vector);

            fds.Text = "Datos " + objLista.GetVuelo(i).GetId();
            fds.Size = new Size(150, 120);
            AbrirSubForm(fds);
        }

        // Dibuja el sector cuando se llama a Invalidate()
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen myPen = new Pen(Color.White);        // Establece el color del boli
            SolidBrush myColorBrush = new SolidBrush(Color.White);       // Establece el color del pincel

            Color ocupacionPerimetro;       // Color ARGB (Alpha, Red, Green, Blue) para el perimetro del sector, el canal alpha establece la opacidad
            Color ocupacionArea;        // Color ARGB para el área del sector

            for (int i = 0; i < objListaSec.GetListaSectores().Count; i++)
            {
                if (objListaSec.GetSector(i).GetCapacidad() != 0)
                {
                    int ocupacion = objListaSec.GetSector(i).Ocupacion(objLista);


                    // Ocupación >= 75%, color rojo
                    if (ocupacion * 100 / objListaSec.GetSector(i).GetCapacidad() > 75)
                    {
                        ocupacionPerimetro = Color.FromArgb(255, 0, 0);
                        ocupacionArea = Color.FromArgb(25, 255, 0, 0);
                    }
                    // Ocupación >= 50% y < 75%, color amarillo
                    else if (ocupacion * 100 / objListaSec.GetSector(i).GetCapacidad() >= 50)
                    {
                        ocupacionPerimetro = Color.FromArgb(255, 255, 0);
                        ocupacionArea = Color.FromArgb(25, 255, 255, 0);
                    }
                    // Ocupacion >= 0% y < 50%, color verde
                    else
                    {
                        ocupacionPerimetro = Color.FromArgb(0, 255, 0);
                        ocupacionArea = Color.FromArgb(25, 0, 255, 0);
                    }
                }
                else
                {
                    ocupacionPerimetro = Color.FromArgb(0, 0, 0, 0);
                    ocupacionArea = Color.FromArgb(0, 0, 0, 0);
                }
                myPen = new Pen(ocupacionPerimetro);
                myColorBrush = new SolidBrush(ocupacionArea);

                Point[] polygonPoints = new Point[4];
                polygonPoints[0] = new Point(Convert.ToInt32(objListaSec.GetSector(i).GetSecX()), Convert.ToInt32(objListaSec.GetSector(i).GetSecY()));
                polygonPoints[1] = new Point(Convert.ToInt32(objListaSec.GetSector(i).GetSecX()), Convert.ToInt32(objListaSec.GetSector(i).GetSecY()) + Convert.ToInt32(objListaSec.GetSector(i).GetAlto()));
                polygonPoints[2] = new Point(Convert.ToInt32(objListaSec.GetSector(i).GetSecX()) + Convert.ToInt32(objListaSec.GetSector(i).GetAncho()), Convert.ToInt32(objListaSec.GetSector(i).GetSecY()) + Convert.ToInt32(objListaSec.GetSector(i).GetAlto()));
                polygonPoints[3] = new Point(Convert.ToInt32(objListaSec.GetSector(i).GetSecX()) + Convert.ToInt32(objListaSec.GetSector(i).GetAncho()), Convert.ToInt32(objListaSec.GetSector(i).GetSecY()));

                graphics.DrawPolygon(myPen, polygonPoints);     // Dibuja el perímetro del sector
                graphics.FillPolygon(myColorBrush, polygonPoints);      // Pinta el interior del sector
            }
            myPen.Dispose();
            myColorBrush.Dispose();
        }

        private void Button_guardarVuelos_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Seleccione el fichero";
            saveFileDialog.InitialDirectory = @"..\..\..\Datos\";
            saveFileDialog.Filter = "txt files (*.vue)|*.vue|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                objLista.Guardar(savePath);
                EsconderSubMenu();
            }
            else
            {
                MessageBox.Show("Ha habido un error al guardar el fichero.");
            }
        }
        #endregion              

        private void Button_añadirSector_Click(object sender, EventArgs e)
        {
            panelControlesPrincipal.Controls.Clear();
            panelControlesPrincipal.Controls.Add(button_volver);

            FormAñadirSector fad = new FormAñadirSector();
            fad.Text = "Añadir sector";
            AbrirSubForm(fad);
            fad.GetSectores(objListaSec);
            panelSubForm.Invalidate();
        }

        private void Button_listaVuelos_Click(object sender, EventArgs e)
        {
            if (cargarVuelos == true)
            {
                panelControlesPrincipal.Controls.Clear();
                panelControlesPrincipal.Controls.Add(button_volver);

                FormListaVuelos fl = new FormListaVuelos();
                fl.SetLista(objLista);
                fl.Text = "Lista de vuelos";
                AbrirSubForm(fl);

                //fl.ShowDialog();      //esto abriria FormListaVuelos en una ventana diferente
            }
            else
            {
                MessageBox.Show("No se ha cargado el fichero de vuelos.");
            }
        }

        private void Button_menuSim_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSimSubMenu);
        }

        // Subopciones del botón Simulación del panelMenuIz
        #region SimulaciónSubMenu
        private void Button_simManual_Click(object sender, EventArgs e)
        {
            if (cargarVuelos == true && cargarSectores == true)
            {
                panelControlesPrincipal.Controls.Clear();
                panelControlesPrincipal.BringToFront();
                panelControlesPrincipal.Visible = true;

                panelControlesPrincipal.Controls.Add(label_tiempoCiclo);
                panelControlesPrincipal.Controls.Add(textBox_tiempoCiclo);
                panelControlesPrincipal.Controls.Add(button_avanzar);
                panelControlesPrincipal.Controls.Add(button_retroceder);
                panelControlesPrincipal.Controls.Add(button_reiniciar);

                EsconderSubMenu();
            }
            else
            {
                MessageBox.Show("Carga primero los ficheros de vuelos y sectores.");
            }
        }

        private void Button_simAuto_Click(object sender, EventArgs e)
        {
            if (cargarVuelos == true && cargarSectores == true)
            {
                panelControlesPrincipal.Controls.Clear();
                panelControlesPrincipal.BringToFront();
                panelControlesPrincipal.Visible = true;

                panelControlesPrincipal.Controls.Add(label_tiempoCiclo);
                panelControlesPrincipal.Controls.Add(textBox_tiempoCiclo);
                panelControlesPrincipal.Controls.Add(button_avanzar);
                panelControlesPrincipal.Controls.Add(button_retroceder);
                panelControlesPrincipal.Controls.Add(label_tiempoSimulacion);
                panelControlesPrincipal.Controls.Add(textBox_tiempoSimulacion);
                panelControlesPrincipal.Controls.Add(button_iniciar);
                panelControlesPrincipal.Controls.Add(button_pausar);
                panelControlesPrincipal.Controls.Add(button_reanudar);
                panelControlesPrincipal.Controls.Add(button_reiniciar);
                panelControlesPrincipal.Controls.Add(progressBar_sim);

                EsconderSubMenu();
            }
            else
            {
                MessageBox.Show("Carga primero los ficheros de vuelos y sectores.");
            }
        }
        #endregion

        private void Button_ampInd_Click(object sender, EventArgs e)
        {
            if (cargarVuelos == true)
            {
                panelSubForm.Controls.Add(panelControlesPrincipal);
                panelControlesPrincipal.Controls.Clear();
                panelControlesPrincipal.BringToFront();
                panelControlesPrincipal.Visible = true;

                panelControlesPrincipal.Controls.Add(label_id);
                panelControlesPrincipal.Controls.Add(textBox_id);
                panelControlesPrincipal.Controls.Add(label_nuevaV);
                panelControlesPrincipal.Controls.Add(textBox_v);
                panelControlesPrincipal.Controls.Add(button_aplicar);
            }
            else
            {
                MessageBox.Show("No se ha cargado el fichero de vuelos.");
            }
        }

        private void Button_baseDatos_Click(object sender, EventArgs e)
        {
            FormBaseDatos fbd = new FormBaseDatos();
            AbrirSubForm(fbd);
        }

        // Info del grupo
        private void Button_info_Click(object sender, EventArgs e)
        {
            FormInfo fi = new FormInfo();
            AbrirSubForm(fi);
        }

        private void Button_ajustes_Click(object sender, EventArgs e)
        {
            panelControlesPrincipal.Controls.Clear();
            panelControlesPrincipal.Controls.Add(button_volver);

            FormAjustes fa = new FormAjustes(objAjustes, airport_vector, cargarVuelos);
            fa.Text = "Ajustes";
            AbrirSubForm(fa);
        }

        private void Button_salir_Click(object sender, EventArgs e)
        {
            objAjustes.GuardarAjustes();
            Application.Exit();
        }


        //============================ SIMULACIÓN ===============================//

        // Muestra el nivel de ocupacion en el label_ocupacion
        public void MostrarOcupacion()
        {
            //label_ocupacion.Text = "Ocupación: " + objSector.Ocupacion(objLista) + "/" + objSector.GetCapacidad() + " (" + (objSector.Ocupacion(objLista) * 100 / objSector.GetCapacidad()) + "%)"; // cap 0?
        }

        // Simulación paso a paso
        private void Button_avanzar_Click(object sender, EventArgs e)
        {
            GuardarSimulacion();

            int t;
            if (int.TryParse(textBox_tiempoCiclo.Text, out t))       //Se comprueba si se ha introducido un número
            {
                objLista.Simulacion(t);

                for (int i = 0; i < objLista.GetCount(); i++)
                {
                    if ((objLista.GetVuelo(i).GetPosX() > 1) && (objLista.GetVuelo(i).GetPosY() > 1))    // MIRAR
                    {
                        aircraft_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()), Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));
                    }
                }

                MostrarOcupacion();
                panelSubForm.Invalidate();
            }
            else
            {
                MessageBox.Show("Intruduce un tiempo de ciclo válido.");
            }
        }

        // Retrocede 1 ciclo en la simulación
        private void Button_retroceder_Click(object sender, EventArgs e)
        {
            DeshacerSimulacion();
            panelSubForm.Invalidate();
        }

        // Inicia la simulación automática usando Timer_Tick
        private void Button_iniciar_Click(object sender, EventArgs e)
        {
            GuardarSimulacion();
            button_pausar.BringToFront();
            progressBar_sim.Value = 0;
            ciclos = 0;
            simulacionFinalizada = true;

            timer.Interval = 1000;
            timer.Enabled = true;
        }

        // Simulación automática
        private void Timer_Tick(object sender, EventArgs e)
        {
            double tryFormat;

            if (double.TryParse(textBox_tiempoCiclo.Text, out tryFormat) && double.TryParse(textBox_tiempoSimulacion.Text, out tryFormat))       // Se comprueba si se ha introducido una cadena numérica
            {
                double t = Convert.ToInt32(textBox_tiempoCiclo.Text);
                int ciclosEnteros = Convert.ToInt32(textBox_tiempoSimulacion.Text) / Convert.ToInt32(textBox_tiempoCiclo.Text);      // Cantidad de ciclos enteros
                double ultimoCiclo = Convert.ToDouble(textBox_tiempoSimulacion.Text) / Convert.ToDouble(textBox_tiempoCiclo.Text) - ciclosEnteros;       // Como de largo es el ciclo restante
                simulacionFinalizada = false;

                if (ciclos < ciclosEnteros)     // Simulación de los cilos enteros
                {
                    objLista.Simulacion(t);
                    for (int i = 0; i < objLista.GetCount(); i++)
                    {
                        if ((objLista.GetVuelo(i).GetPosX() > 1) && (objLista.GetVuelo(i).GetPosY() > 1))
                        {
                            aircraft_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()), Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));
                        }
                    }
                    ActualizarProgressBar();
                    ciclos++;
                }
                else if (ultimoCiclo != 0)     // Simulación del último ciclo
                {
                    t = ultimoCiclo * Convert.ToInt32(textBox_tiempoCiclo.Text);
                    objLista.Simulacion(t);

                    for (int i = 0; i < objLista.GetCount(); i++)
                    {
                        if ((objLista.GetVuelo(i).GetPosX() > 1) && (objLista.GetVuelo(i).GetPosY() > 1))
                        {
                            aircraft_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()), Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));
                        }
                    }
                    ActualizarProgressBar();
                    ciclos = 0;
                    simulacionFinalizada = true;
                    timer.Dispose();
                    button_iniciar.BringToFront();
                }
                MostrarOcupacion();
                GuardarSimulacion();
                panelSubForm.Invalidate();
            }
            else
            {
                timer.Dispose();
                MessageBox.Show("Intruduce un tiempo de ciclo / tiempo de simulación válidos.");
            }
        }

        // Actualiza la barra de progreso de la simulación automatica
        private void ActualizarProgressBar()
        {
            decimal ciclos = Math.Ceiling(Convert.ToDecimal(textBox_tiempoSimulacion.Text) / Convert.ToDecimal(textBox_tiempoCiclo.Text));      //cuantas veces va a tener k actualizarse
            progressBar_sim.Maximum = Convert.ToInt32(ciclos) * 10;     // Largo de la barra = cantidad de actualizaciones * 10
            progressBar_sim.Value += 10;     // Progreso de la barra por actualización
        }

        // Pausa lasimulación automática
        private void Button_pausar_Click(object sender, EventArgs e)
        {
            button_reanudar.BringToFront();
            timer.Stop();
        }

        // Reanuda lasimulación automática
        private void Button_reanudar_Click(object sender, EventArgs e)
        {
            if (simulacionFinalizada == false)
            {
                button_pausar.BringToFront();
                timer.Start();
            }
            else
            {
                MessageBox.Show("La simulación no esta en curso o ya ha finalizado.");
            }
        }

        // Reinicia las posiciones iniciales de todos los vuelos
        private void Button_reiniciar_click(object sender, EventArgs e)
        {
            button_iniciar.BringToFront();
            progressBar_sim.Value = 0;
            ciclos = 0;
            simulacionFinalizada = true;

            timer.Dispose();
            for (int i = 0; i < objLista.GetCount(); i++)
            {
                objLista.GetVuelo(i).SetPosX(objLista.GetReiniciar(i, 0));      // Reestablece la posicion inicial X
                objLista.GetVuelo(i).SetPosY(objLista.GetReiniciar(i, 1));      // Reestablece la posicion inicial Y

                aircraft_vector[i].Location = new Point(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()), Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));      // Dibuja los vuelos en sus posiciones iniciales
            }
            MostrarOcupacion();

            panelSubForm.Invalidate();
        }

        // Añade una lista con las posiciones de cada vuelo al stack
        public void GuardarSimulacion()
        {
            List<List<int>> vuelos = new List<List<int>>();     // Lista de vuelos, contiene listas con las posiciones X e Y

            for (int i = 0; i < objLista.GetCount(); i++)
            {
                vuelos.Add(new List<int>());        // Lista con las posiciones Y e Y

                vuelos[i].Add(Convert.ToInt32(objLista.GetVuelo(i).GetPosX()));
                vuelos[i].Add(Convert.ToInt32(objLista.GetVuelo(i).GetPosY()));
            }

            deshacerSim.Push(vuelos);        // Añadimos la lista "vuelos" al stack deshacerSimulacion
        }

        // Actualiza las posiciones de los PictureBox a la posición simulada anteriormente
        public void DeshacerSimulacion()
        {
            int[] tmp = new int[2];
            int vuelo = 0;

            if (deshacerSim.Count != 0)
            {
                foreach (List<int> vuelos in deshacerSim.Pop())     // Para cada lista de la ultima posicion del stack
                {
                    int pos = 0;

                    foreach (int posicion in vuelos)        // Metemos los numeros de la lista en tmp[]
                    {
                        tmp[pos] = posicion;
                        pos++;
                    }

                    aircraft_vector[vuelo].Location = new Point(tmp[0], tmp[1]);      // Damos la nueva posicion a los picturebox del aircraft_vector
                    vuelo++;
                }
            }
            else
                MessageBox.Show("Se ha llegado a la posición inicial");
        }


        //============================ LISTAR VUELOS ============================//
        private void Button_volver_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            panelControlesPrincipal.Visible = true;
            panelControlesPrincipal.BringToFront();
            panelControlesPrincipal.Controls.Remove(button_volver);
        }


        //======================== AMPLIACIÓN INDIVIDUAL ========================//

        // Busca un Vuelo con un detirminado ID y modifica su velocidad
        private void Button_aplicar_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox_id.Text;
            objLista.SetIdBuscar(idBuscar);

            double vCambio = Convert.ToDouble(textBox_v.Text);
            objLista.SetVCambio(vCambio);

            if (objLista.CambiarV() == 0)
            {
                MessageBox.Show("Velocidad cambiada correctamente.");
            }
            else
            {
                MessageBox.Show("No hay ningún vuelo con ese identificador.");
            }
        }


        //============================= AJUSTES ==============================//

        // SONIDOS ====================

        [DllImport("winmm.dll")]

        // Permite enviar comandos a un dispositivo MCI (especificando en el comando)
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private void PlaySound()
        {
            if (objAjustes.GetSonido() == true)
            {
                mciSendString("play MouseOver_button from 0", null, 0, IntPtr.Zero);
            }
        }

        // Cuando el raton entra en losbotones se llama a PlaySound()
        #region MouseEnter
        // Cargar/guardar
        private void Button_menuCargar_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void Button_cargarVuelos_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void Button_cargarSector_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void Button_guardarVuelos_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Listar Vuelos
        private void Button_listaVuelos_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Simulación
        private void Button_menuSim_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void Button_simManual_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void Button_simAuto_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Amp Individual
        private void Button_ampInd_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Opciones adicionales
        private void Button_otros_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Info
        private void Button_info_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Ajustes
        private void Button_ajustes_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }

        // Salir
        private void Button_salir_MouseEnter(object sender, EventArgs e)
        {
            PlaySound();
        }
        #endregion

        // AEROPUERTOS ================
        public void MostrarAeropuertos(PictureBox[] airport_vector, bool cargarVuelos, Ajustes objAjustes)
        {
            if (objAjustes.GetAeropuertos() == false && cargarVuelos == true)
            {
                for (int i = 0; i < airport_vector.Length; i++)
                {
                    airport_vector[i].Visible = false;
                }
            }
            else if (cargarVuelos == true)
            {
                for (int i = 0; i < airport_vector.Length; i++)
                {
                    airport_vector[i].Visible = true;
                }
            }
            else
                MessageBox.Show("Es necesario cargar los vuelos primero");
        }

        // RUTAS =======================
        public void MostrarRutas()
        {
            if (objAjustes.GetRutas() == true)
            {

            }
        }
    }
}
