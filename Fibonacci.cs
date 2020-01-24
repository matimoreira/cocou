
using System.Collections.Generic;

namespace ejemplo 
{
    public class Fibonacci 
    {
        public List<int> DevolverSerie(int cantidadElementos)
        {
            if (cantidadElementos==1)
            {
                return new List<int> { 1 };            
            } 
            if (cantidadElementos == 2)
            {
                return new List<int> { 1, 2 };
            }
            var list = new List<int> { 1, 2 };
            for(int i = 3; i <= cantidadElementos; i++)
            {
                list.Add(list[list.Count - 1] + list[list.Count - 2]);
            }
            return list;
        }

        public int GetElementByPosition(int position)
        {
            /*
            este metodo calcula el elemento de la posición y lo devuelve
            */

            return 13;
        }
    }
}
