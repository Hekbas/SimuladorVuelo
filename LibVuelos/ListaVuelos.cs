using System;
using System.IO;


namespace LibVuelos
{
    public class ListaVuelos
    {
        private int count;      //cantidad de vuelos
        private Vuelo[] listaVuelo;      //vector de objetos de la clase Vuelo  
        private double[,] reiniciar;        //para reiniciar las posiciones en la simulación

        public ListaVuelos() { }
        public ListaVuelos(int count)
        {
            this.count = count;
        }

        //================ Métodos de Acceso ==================//
        public int GetCount()
        {
            return count;
        }
        public void SetCount(int count)
        {
            this.count = count;
        }

        public Vuelo GetVuelo(int i)
        {
            return this.listaVuelo[i];
        }
        public void SetVuelo(Vuelo a, int i)
        {
            this.listaVuelo[i] = a;
        }

        public double GetReiniciar(int i, int j)
        {
            return this.reiniciar[i,j];
        }


        //================ Métodos de Consola ==================//
        public void MostrarVuelos(string loadPath)
        {
            CargarVuelos(loadPath);
            for (int i = 0; i <2; i++)
            {
                Console.Write(listaVuelo[i].GetId() + "  X=" + listaVuelo[i].GetPosX() + "  Y=" + listaVuelo[i].GetPosY());
            }
            Console.Read();
        }


        //============== Métodos de FormPrincipal ==============//
        public void CargarVuelos(string loadPath)
        {
            count = 0;

            StreamReader rLine = new StreamReader(loadPath);
            TextReader rDatos = new StreamReader(loadPath);

            string[] datos = new string[9];

            while ((rLine.ReadLine()) != null)
            {
                count++;
            }
            rLine.Close();

            listaVuelo = new Vuelo[count];

            Array.Clear(listaVuelo, 0, count);

            for (int i = 0; i < count; i++)
            {
                listaVuelo[i] = new Vuelo();
                datos = rDatos.ReadLine().Split('_');

                listaVuelo[i].SetId(datos[0]);
                listaVuelo[i].SetCia(datos[1]);
                listaVuelo[i].SetPosX(Convert.ToDouble(datos[2]));
                listaVuelo[i].SetPosY(Convert.ToDouble(datos[3]));
                listaVuelo[i].SetV(Convert.ToDouble(datos[4]));
                listaVuelo[i].SetPosXi(Convert.ToDouble(datos[5]));
                listaVuelo[i].SetPosYi(Convert.ToDouble(datos[6]));
                listaVuelo[i].SetPosXf(Convert.ToDouble(datos[7]));
                listaVuelo[i].SetPosYf(Convert.ToDouble(datos[8]));
            }
            rDatos.Close();

            reiniciar = new double[count,2];
            for (int i = 0; i < count; i++)
            {
                reiniciar[i, 0] = listaVuelo[i].GetPosX();
                reiniciar[i, 1] = listaVuelo[i].GetPosY();
            }
        }

        public void Guardar(string savePath)
        {
            StreamWriter w = new StreamWriter(savePath);

            for (int i = 0; i < count; i++)
            {
                w.Write(
                    listaVuelo[i].GetId() + "_" +
                    listaVuelo[i].GetCia() + "_" +
                    listaVuelo[i].GetPosX() + "_" +
                    listaVuelo[i].GetPosY() + "_" +
                    listaVuelo[i].GetV() + "_" +
                    listaVuelo[i].GetPosXi() + "_" +
                    listaVuelo[i].GetPosYi() + "_" +
                    listaVuelo[i].GetPosXf() + "_" +
                    listaVuelo[i].GetPosYf() + ";");
            }
            w.Close();
        }

        public void Simulacion(double t)
        {
            
            for (int i = 0; i < count; i++)     //calculo posición
            {

                double dist = (listaVuelo[i].GetV() / 60) * t;
                double deltaX = (dist * (listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosX())) / (Math.Sqrt(Math.Pow(listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosX(), 2) + Math.Pow(listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosY(), 2)));
                double deltaY = (dist * (listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosY())) / (Math.Sqrt(Math.Pow(listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosX(), 2) + Math.Pow(listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosY(), 2)));

                double X = deltaX + listaVuelo[i].GetPosX();
                double Y = deltaY + listaVuelo[i].GetPosY();

                // Se va a pasar de su destino?
                if (listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosXi() > 0 && listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosYi() > 0 && X > listaVuelo[i].GetPosXf())     //vector 1r cuadrante
                {
                    // Establecer pos final como pos actual
                    listaVuelo[i].SetPosX(listaVuelo[i].GetPosXf());
                    listaVuelo[i].SetPosY(listaVuelo[i].GetPosYf());
                }
                else if (listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosXi() < 0 && listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosYi() > 0 && X < listaVuelo[i].GetPosXf())        //vector 2o cuadrante
                {
                    listaVuelo[i].SetPosX(listaVuelo[i].GetPosXf());
                    listaVuelo[i].SetPosY(listaVuelo[i].GetPosYf());
                }
                else if (listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosXi() < 0 && listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosYi() < 0 && X < listaVuelo[i].GetPosXf())        //vector 3r cuadrante
                {
                    listaVuelo[i].SetPosX(listaVuelo[i].GetPosXf());
                    listaVuelo[i].SetPosY(listaVuelo[i].GetPosYf());
                }
                else if (listaVuelo[i].GetPosXf() - listaVuelo[i].GetPosXi() > 0 && listaVuelo[i].GetPosYf() - listaVuelo[i].GetPosYi() < 0 && X > listaVuelo[i].GetPosXf())        //vector 4o cuadrante
                {
                    listaVuelo[i].SetPosX(listaVuelo[i].GetPosXf());
                    listaVuelo[i].SetPosY(listaVuelo[i].GetPosYf());
                }
                else
                {
                    // Establecer pos calculada como actual
                    listaVuelo[i].SetPosX(X);
                    listaVuelo[i].SetPosY(Y);
                }

                if (Double.IsNaN(deltaX) == true)        // Si PosXf = PosX deltaX queda dividido por 0 (NotANumber)
                {
                    listaVuelo[i].SetPosX(listaVuelo[i].GetPosXf());
                    listaVuelo[i].SetPosY(listaVuelo[i].GetPosYf());
                }
            }
        }


        //=============== Ampliación Individual ================//
        string idBuscar;
        double vCambio;

        public ListaVuelos(string idBuscar, double vCambio)
        {
            this.idBuscar = idBuscar;
            this.vCambio = vCambio;
        }

        public int CambiarV()
        {
            for (int i = 0; i < GetCount(); i++)
            {
                if (listaVuelo[i].GetId() == idBuscar)
                {
                    listaVuelo[i].SetV(vCambio);
                    return 0;
                }
            }
            return -1;
        }

        public string GetIdBuscar()
        {
            return idBuscar;
        }
        public void SetIdBuscar(string idBuscar)
        {
            this.idBuscar = idBuscar;
        }

        public double GetVCambio()
        {
            return vCambio;
        }
        public void SetVCambio(double vCambio)
        {
            this.vCambio = vCambio;
        }
    }
}