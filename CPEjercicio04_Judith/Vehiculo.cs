using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio04_Judith
{
    internal class Vehiculo
    {
        //Definimos los campos de la clase
        int id;
        string marca;
        string modelo;
        int kilometraje;
        decimal precio;
        int annio;
        public Vehiculo() { }
        public Vehiculo(int id, string marca, string modelo, int kilometraje, decimal precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Kilometraje = kilometraje;
            this.Precio = precio;
            this.Annio = annio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }
        public override string ToString()
        {
            return "El modelo: " + this.Modelo + " \nMarca: " + this.Marca + "\nKilometraje: " + this.Kilometraje + "\nPrecio: " + this.Precio + " \naño: " + this.Annio;
        }
        public virtual decimal Precitotal()
        {
            return this.Precio;
        }
    }
}
