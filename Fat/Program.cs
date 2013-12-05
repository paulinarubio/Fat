using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = new int[10];
            int[] files = new int[] { 200, 400 };
            int tot = 0;
            int sarchivo = 0;
            sarchivo = files[0];
            for (int i = 0; i < arreglo.Length; i++) { arreglo[i] = 200; }
            foreach (var x in files)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if(arreglo[i] != 200){i++;}

                    else
                    {
                        sarchivo = sarchivo - arreglo[i];
                        arreglo[i] = sarchivo;
                        tot = arreglo[i] + tot;

                    }


                }


            }


            foreach (int y in arreglo)
            {
                Console.WriteLine(y.ToString());
            }
            Console.ReadLine();
        
        
        }
    }

    

}
