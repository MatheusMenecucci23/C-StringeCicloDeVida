using System;
using System.Diagnostics;

namespace _01._3.Finalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }
            //chamando o forçadamente o coletor de lixo 
            GC.Collect();

            Console.ReadKey();
        }
    }

    class Livro
    {
        static int UltimoId = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            UltimoId++;
            Id = UltimoId;
            //Trace.WriteLine("Livro " + Id + " está sendo criado");
        }


        //Declarando um finalizador com o ~
        //~Livro()
        //{
        //    //LIBERAR SOMENTE OS RECURSOS NÃO-GERENCIADOS


        //    Trace.WriteLine("Livro " + Id + " está sendo finalizado");
        //}
    }
}
