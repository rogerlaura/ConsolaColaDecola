using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaColaDecola
{
    internal class Cola
    {
        private int primero, ultimo, maxcola;
        private int[] items;
        public Cola(int maxcola)
        {
            this.maxcola = maxcola;
            this.items=new int[maxcola];
            this.primero=0;
            this.ultimo = -1;
        }
        public bool colavacia()
        {
            if (this.ultimo<this.primero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool colallena()
        {
            if (this.ultimo == this.maxcola - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertarItemsDelate(int dato)
        {
            if (this.colallena())
            {
                Console.WriteLine("LA COLA ESTA LLENA");

            }
            else
            {
                this.ultimo++;
                for(int i=ultimo; i>0; i--)
                {
                    this.items[i]=this.items[i-1];  
                }
                this.items[this.primero] = dato;
            }
        }
        public void InsertarItemsDetras(int dato)
        {
            if (this.colallena())
            {
                Console.WriteLine("LA COLA ESTA LLENA");

            }
            else
            {
               
                this.ultimo++;
                this.items[this.ultimo] = dato;
            }
        }
        public void EliminarItemsDelante()
        {
            if (this.colavacia())
            {
                Console.WriteLine("LA COLA ESTA VACIA");
            }
            else
            {
                Console.WriteLine("SE ELIMINO CON EXITO EL ELEMENTO " + this.items[this.primero] + " DE LA COLA");
                for (int i = 0; i < this.ultimo; i++)
                {
                    this.items[i] = this.items[i + 1];
                }
                this.ultimo--;
            }
        }
        public void EliminarItemsDetras()
        {
            if (this.colavacia())
            {
                Console.WriteLine("LA COLA ESTA VACIA");
            }
            else
            {
                Console.WriteLine("SE ELIMINO CON EXITO EL ELEMENTO " + this.items[this.ultimo] + " DE LA COLA");
                this.ultimo--;
            }
        }
        public void ListarItems()
        {
            if (this.colavacia())
            {
                Console.WriteLine("LA COLA ESTA VACIA");

            }
            else
            {
                for(int i=0; i <= this.ultimo; i++)
                {
                    Console.WriteLine("["+i+"] => "+this.items[i]);
                }
            }
        }
    }
}
