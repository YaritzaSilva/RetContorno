using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrlinhas=0;
            int nrcolunas=0;

            Console.WriteLine("CONTORNO DO RETÂNGULO");
            Console.Write("Linhas: ");
            nrlinhas=Convert.ToInt32(Console.ReadLine());
            Console.Write("Colunas: ");
            nrcolunas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int linhas=0;
            while (linhas<nrlinhas)
            {
                linhas+=1;

                int coluna=0;
                while (coluna<nrcolunas)
                {
                    coluna += 1;

                    if (linhas==1||linhas==nrlinhas)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if (coluna==1||coluna==nrcolunas)
                        {
                            Console.Write("* ");

                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
