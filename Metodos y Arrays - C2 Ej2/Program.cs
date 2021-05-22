using System;

namespace Metodos_y_Arrays___C2_Ej2
{
    class Mostrarnumerosaleatorios
    {
        public int Rango()
        {
            int a, z;
            Random aleatorio = new Random();
            Console.WriteLine("Desde que numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasta que numero: ");
            z = Convert.ToInt32(Console.ReadLine());
            return aleatorio.Next(a,z);
        }
        static void Main(string[] args)
        {
            Mostrarnumerosaleatorios numero = new Mostrarnumerosaleatorios();
            Console.WriteLine(numero.Rango());
        }
    }
}
