namespace ejemplo.math 
{
    public class MathFunctions
    {
        public static int GetFactorial(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            else
            {
                return numero * GetFactorial(numero - 1);
            }
        }
    }
}