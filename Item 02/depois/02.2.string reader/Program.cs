using System;
using System.IO;

namespace _02._2.string_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //======
            //1) Ler sequencialmente a lista de ingredientes
            //linha a linha.
            //2) Cada Linha deve começar com um caracter "•" e um espaço

            //Para suportar o caractere especial "•"
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            //obtendo os ingredientes
            string ingredientes = GetIngredientes();
         
            //garantindo que mesmo se der uma exceção no código, os recursos serão liberados
            using (StringReader stringReader = new StringReader(ingredientes))
            {
                string line;
                //cada vez que você chama o readLine(), uma linha do seu array é pegada
                while ((line = stringReader.ReadLine()) != null)
                {
                    //escrevendo a linha por linha e adicionando nela o "•"
                    Console.WriteLine("• " + line);
                }
            }

            Console.ReadKey();
        }

        private static string GetIngredientes()
        {
return
@"3 cenouras médias raspadas e picadas
3 ovos
1 xícara de óleo
2 xícaras de açúcar
2 xícaras de farinha de trigo
1 colher(sopa) de fermento em pó
1 pitada de sal";
        }
    }
}
