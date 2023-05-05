using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio04_Judith
{
    internal class Auto : Vehiculo
    {
        public Auto() { }

        public Auto(char airbag)
        {
            this.airbag = airbag;
        }

        char airbag;

        public char Airbag { get => airbag; set => airbag = value; }

        public override decimal Precitotal()
        {
            Console.WriteLine("¿El auto tiene airbag?");
            airbag = char.Parse(Console.ReadLine());
            if (this.Airbag == 's' || this.Airbag == 'S')
            {
                this.Precio += 200;
            }
            else
            {
                this.Precio = this.Precio;
            }
            return base.Precitotal();
        }
    }
}
