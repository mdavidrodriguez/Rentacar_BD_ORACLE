using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {

        public string PlacaVehiculo { get; set; }
        public string Marca { get; set; }
        public int KilometrajeActual { get; set; }
        public int modelo { get; set; }
        public string estado { get; set; }
        public string color { get; set; }
        
        public Vehiculo()
        {

        }

        public Vehiculo(string placaVehiculo, string marca, int kilometrajeActual, int modelo, string estado, string color)
        {
            PlacaVehiculo = placaVehiculo;
            Marca = marca;
            KilometrajeActual = kilometrajeActual;
            this.modelo = modelo;
            this.estado = estado;
            this.color = color;
        }
    }
}
