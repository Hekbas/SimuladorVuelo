using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibVuelos
{
    public class ListaSectores
    {
        private int countSectores;
        List<Sector> listaSectores = new List<Sector>();


        public int GetCountSectores()
        {
            return countSectores;
        }

        public Sector GetSector(int i)
        {
            return this.listaSectores[i];
        }

        public List<Sector> GetListaSectores()
        {
            return this.listaSectores;
        }

        public void CargarSector(string sectorPath)
        {
            countSectores = 0;

            StreamReader rLine = new StreamReader(sectorPath);
            StreamReader rDatos = new StreamReader(sectorPath);

            while ((rLine.ReadLine()) != null)
            {
                countSectores++;
            }
            rLine.Close();

            listaSectores.Clear();

            for (int i = 0; i < countSectores; i++)
            {
                string text = rDatos.ReadLine();
                string[] datos = text.Split('_');

                listaSectores.Add(new Sector(datos[0], Convert.ToInt32(datos[1]), Convert.ToInt32(datos[2]), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4]), Convert.ToInt32(datos[5])));
            }
            rDatos.Close();
        }
    }
}
