using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;

namespace _02._1.string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma variável do tipo string vazia/empty
            //desse jeito cada concatenação vira um objeto que será armazenado em diferentes regiões da memória 
            string materias1 = string.Empty;
            materias1 += "Português";
            Console.WriteLine(materias1);
            materias1 += ", Matemática";
            Console.WriteLine(materias1);
            materias1 += ", Geografia";
            Console.WriteLine(materias1);

            //desse jeito a concatenação acontece, porém de uma forma mais eficiente
            //pois stringBuilder, a cada concatenação ele, só alarga o espaço na memória e não cria novos objeto na memória
            StringBuilder materias = new StringBuilder();
            materias.Append("Português");
            Console.WriteLine(materias);
            //adicionando mais uma string no array de string
            materias.Append(", Matemática");
            Console.WriteLine(materias);
            materias.Append(", Geografia");
            Console.WriteLine(materias);
            Console.ReadKey();

            ///<image url="$(ProjectDir)/img1.png"/>
        }
    }
}
