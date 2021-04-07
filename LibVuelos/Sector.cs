using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace LibVuelos
{
    public class Sector
    {
        ListaVuelos objLista = new ListaVuelos();
        ListaSectores objListaSec = new ListaSectores();

        string id;
        int capacidad;
        int secX;
        int secY;
        int ancho;
        int alto;

        public Sector() { }
        public Sector(string id, int capacidad, int secX, int secY, int ancho, int alto) 
        {
            this.id = id;
            this.capacidad = capacidad;
            this.secX = secX;
            this.secY = secY;
            this.ancho = ancho;
            this.alto = alto;
        }

        //================ Métodos de Acceso ==================//
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }

        public int GetCapacidad()
        {
            return this.capacidad;
        }
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public int GetSecX()
        {
            return this.secX;
        }
        public void SetSecX(int secX)
        {
            this.secX = secX;
        }

        public int GetSecY()
        {
            return this.secY;
        }
        public void SetSecY(int secY)
        {
            this.secY = secY;
        }

        public int GetAncho()
        {
            return this.ancho;
        }
        public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }

        public int GetAlto()
        {
            return this.alto;
        }
        public void SetAlto(int alto)
        {
            this.alto = alto;
        }


        //============== Métodos de FormPrincipal ==============//
        

        public int Ocupacion(ListaVuelos objLista)
        {
            int cantidadSector = 0;

            //vuelo dentro del sector?
            for (int i = 0; i < objLista.GetCount(); i++)
            {
                if ((this.secX <= objLista.GetVuelo(i).GetPosX()) && (objLista.GetVuelo(i).GetPosX() <= (this.secX + this.ancho)))
                {
                    if ((this.secY <= objLista.GetVuelo(i).GetPosY()) && (objLista.GetVuelo(i).GetPosY() <= (this.secY + this.alto)))
                    {
                        cantidadSector++;
                    }
                }
            }
            return cantidadSector;
        }
    }
}