using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._6_formatar
{
    class Program
    {
        //variável modelo que contém lacunas que serão substituidas
        private const string MODELO = @"CONTRATO INDIVIDUAL DE TRABALHO TEMPORÁRIO
            EMPREGADOR: {0} 
            EMPREGADO: {1}
Pelo presente instrumento particular de contrato individual de trabalho,
fica justo e contratado o seguinte:
 Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de 
{2:d} e assinatura deste instrumento, seus trabalhos 
exercendo a função de {3}, prestando pessoalmente o 
labor diário no período compreendido entre {4:t} e {5:t}, 
e intervalo de 1 hora para almoço;
            Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo 
prestado a compensação de horário semanal;
            Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a 
título de salário a importância de {6:C3}, com os 
descontos previstos por lei;

São Paulo, {7:D}
_______________________________________________________
{0}
______________________________________________________
{1}
_______________________________________________________
(Nome, R.G, Testemunha)
_______________________________________________________
(Nome, R.G, Testemunha)";

        static void Main(string[] args)
        {
            var contrato = new
            {
                Empresa = "Alura Serviços Hidráulicos Ltda.",
                Funcionario = "Mario Mario",
                Inicio = new DateTime(2019, 1, 1),
                Cargo = "encanador",
                Salario = 3108.45,
                InicioJornada = new DateTime(2018, 1, 10, 9, 0, 0),
                FimJornada = new DateTime(2018, 1, 10, 18, 0, 0)
            };

            //inserindo as variáveis nas lacunas da variável modelo
            string documento = string.Format(
                MODELO
                , contrato.Empresa//{0}
                , contrato.Funcionario//{1}
                , contrato.Inicio//{2}
                , contrato.Cargo//{3}
                , contrato.InicioJornada//{4}
                , contrato.FimJornada//{5}
                , contrato.Salario//{6}
                , DateTime.Today);//{7}

            Console.WriteLine(documento);
            Console.ReadKey();
        }
    }
}
