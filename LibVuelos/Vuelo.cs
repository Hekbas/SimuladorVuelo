using System;

namespace LibVuelos
{
    public class Vuelo
    {
        private string id;
        private string cia;
        private double posX;
        private double posY;
        private double v;
        private double posXi;
        private double posYi;
        private double posXf;
        private double posYf;

        public Vuelo() { }
        public Vuelo(string id, string cia, double posX, double posY, double v, double posXi, double posYi, double posXf, double posYf)
        {
            this.id = id;
            this.cia = cia;
            this.posX = posX;
            this.posY = posY;
            this.v = v;
            this.posXi = posXi;
            this.posYi = posYi;
            this.posXf = posXf;
            this.posYf = posYf;
        }

        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetCia()
        {
            return this.cia;
        }
        public void SetCia(string cia)
        {
            this.cia = cia;
        }

        public double GetPosX()
        {
            return this.posX;
        }
        public void SetPosX(double posX)
        {
            this.posX = posX;
        }

        public double GetPosY()
        {
            return this.posY;
        }
        public void SetPosY(double posY)
        {
            this.posY = posY;
        }

        public double GetV()
        {
            return this.v;
        }
        public void SetV(double v)
        {
            this.v = v;
        }

        public double GetPosXi()
        {
            return this.posXi;
        }
        public void SetPosXi(double posXi)
        {
            this.posXi = posXi;
        }

        public double GetPosYi()
        {
            return this.posYi;
        }
        public void SetPosYi(double posYi)
        {
            this.posYi = posYi;
        }

        public double GetPosXf()
        {
            return this.posXf;
        }
        public void SetPosXf(double posXf)
        {
            this.posXf = posXf;
        }

        public double GetPosYf()
        {
            return this.posYf;
        }
        public void SetPosYf(double posYf)
        {
            this.posYf = posYf;
        }
    }
}