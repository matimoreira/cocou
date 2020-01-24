
using System;
using System.Collections.Generic;

namespace ejemplo
{
    class Program
    {
        public const float pi = 3.14159F;
        static void Main(string[] args)
        {
            Miembro miembro = new Miembro();
            
            try 
            {
                var cero = 0;
                var result = 10 / cero;
                MiembroCrack mc = (MiembroCrack) miembro;
                Console.WriteLine("Todo bien");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Todo mal con el casteo {ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine($"ni idea, pero paso algo malo");
            }


        }
    }
}
