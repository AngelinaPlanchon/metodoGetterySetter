using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoGetterySettery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Auto auto2 = new Auto(3.5, 2.5);
            auto2.setExtras(true, "cuero");


            Moto moto1 = new Moto();
            Moto moto2 = new Moto(1.8, "deportiva");
            moto2.setExtras(true, "piel");


            Console.WriteLine(auto1.getInfoAtuto());
            Console.WriteLine(auto1.getExtras());
            Console.WriteLine(auto2.getInfoAtuto());
            Console.WriteLine(auto2.getExtras());

            Console.WriteLine(moto1.getInfoMoto());
            Console.WriteLine(moto1.getExtras());
            Console.WriteLine(moto2.getInfoMoto());
            Console.WriteLine(moto2.getExtras());

        }
    }
    class Auto
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;


        public Auto()
        {
            ruedas = 4;
            largo = 3;
            ancho = 2;
            climatizador = false;
            tapiceria = "tela";

        }

        public Auto(double largoAuto, double anchoAuto)
        {
            ruedas = 4;
            largo = largoAuto;
            ancho = anchoAuto;
            climatizador = false;
            tapiceria = "tela";
        }


        public string getInfoAtuto()
        {
            return "El auto tiene \n" + " ruedas: " + ruedas + " largo: " + largo + " ancho: " + ancho;
        }

        public void setExtras(bool climatiadorAuto, string tapiceriaAuto)
        {
            climatizador = climatiadorAuto;
            tapiceria = tapiceriaAuto;
        }

        public string getExtras()
        {
            return "El auto tiene \n" + " climatizador: " + climatizador + " tapiceria: " + tapiceria + "\n";
        }
    }

    class Moto
    {
        private int ruedas;
        private double largo;
        private string tipo;
        private bool casco;

        public Moto()
        {
            ruedas = 2;
            largo = 2;
            tipo = "estandar";
            casco = false;
        }

        public Moto(double largoMoto, string tipoMoto)
        {
            ruedas = 2;
            largo = largoMoto;
            tipo = tipoMoto;
            casco = false;
        }

        public string getInfoMoto()
        {
            return "La moto tiene \n" + " ruedas: " + ruedas + " largo: " + largo + " tipo: " + tipo;

        }

        public void setExtras(bool cascoMoto, string tapiceriaMoto)
        {
            casco = cascoMoto;
            tipo = tapiceriaMoto;
        }

        public string getExtras()
        {
            return "La moto tiene \n" + " casco: " + casco + "\n";
        }
    }

}

