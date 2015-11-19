using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapolnYlitkoi
{
    class Program
    {
        public void create(int[,] mass)
        {
            int i = 0;
            int j = 0;
            int numCol = mass.GetLength(0);
            int numRow = mass.GetLength(1);
            Random rnd = new Random();
         
        
            int x = mass.GetLength(0) * mass.GetLength(1);
            int check = 0;
            do
            {
                for (j = j; j < numRow-1; j++)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                
                for (i = i; i < numCol-1; i++)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                numRow--;
                numCol--;

                for (j = j; j >= mass.GetLength(1) - numRow; j--)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }

                for (i = i; i > mass.GetLength(0)-numCol-1; i--)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }

                i++;
                j++;
            } while (check != x);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] mass = new int[n,m];
            Program t = new Program();
            t.create(mass);
       
            Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
            Console.ReadLine();
        }
    }
}
