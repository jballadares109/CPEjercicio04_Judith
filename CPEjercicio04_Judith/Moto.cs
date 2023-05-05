using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio04_Judith
{
    internal class Moto : Vehiculo
    {
        public Moto() { }
        char sidecar;

        public Moto(int id, string marca, string modelo, int kilometraje, decimal precio, int annio, char sidecar)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Kilometraje = kilometraje;
            this.Precio = precio;
            this.Annio = annio;
            this.sidecar = sidecar;
        }

        public char Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal Precitotal()
        {
            //Console.WriteLine("¿La moto tiene sidecar?");
            //sidecar = char.Parse(Console.ReadLine());
            if (this.sidecar == 's' || this.sidecar == 'S')
            {
                this.Precio += 50;
            }
            else
            {
                this.Precio = this.Precio;
            }
            return base.Precitotal();
        }
    }
}
