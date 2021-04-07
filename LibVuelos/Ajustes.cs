using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibVuelos
{
    public class Ajustes
    {
        bool[] listaAjustes = new bool[3];

        private bool sonido;
        private bool aeropuertos;
        private bool rutas;

        public bool GetSonido()
        {
            return this.sonido;
        }
        public void SetSonido(bool sonido)
        {
            this.sonido = sonido;
        }

        public bool GetAeropuertos()
        {
            return this.aeropuertos;
        }
        public void SetAeropuertos(bool aeropuertos)
        {
            this.aeropuertos = aeropuertos;
        }

        public bool GetRutas()
        {
            return this.rutas;
        }
        public void SetRutas(bool rutas)
        {
            this.rutas = rutas;
        }

        // Carga los ajustes del fichero a la listaAjustes y establece los Setters
        public void CargarAjustes()
        {
            TextReader rAjustes = new StreamReader(@"..\..\..\Datos\Ajustes.ini");

            for (int i = 0; i < listaAjustes.Length; i++)
            {
                if (rAjustes.ReadLine().EndsWith("True"))
                {
                    listaAjustes[i] = true;
                }
                else
                    listaAjustes[i] = false;

            }
            rAjustes.Close();

            SetSonido(listaAjustes[0]);
            SetAeropuertos(listaAjustes[1]);
            SetRutas(listaAjustes[2]);
        }

        // Guarda los ajustes de la listaAjustes al fichero
        public void GuardarAjustes()
        {
            StreamWriter wAjustes = new StreamWriter(@"..\..\..\Datos\Ajustes.ini");

            wAjustes.WriteLine("sonido=" + sonido);
            wAjustes.WriteLine("aeropuertos=" + aeropuertos);
            wAjustes.WriteLine("rutas=" + rutas);

            wAjustes.Close();
        }
    }
}
