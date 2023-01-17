//receber nome da pessoa -ok
//receber a data de nascimento (calculo de idade) -ok
//receber a altura e peso (calculo do imc) -ok
//receber salário bruto (calculo do desconto clt)
//receber o saldo da conta (calcular valor em dólar)

using System;

//projeto
namespace Pessoa
{
    //classe
    internal class Program 
    {
        //método = ação
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite o seu nome: ");  //captura da ação
            var nomePessoa = Console.ReadLine();  //variável + nome da variável  //=valor  //lê a linha e guarda o valor na variável

            Console.WriteLine("Digite sua data de nascimento: ");
            var dataNascimentoPessoa = Console.ReadLine();
            var dataNascimento = Convert.ToDateTime(dataNascimentoPessoa);   //conversão de dados

            var anoAtual = DateTime.Now.Year;   //ano atual
            var idade = anoAtual - dataNascimento.Year;   //calculo

            Console.WriteLine("Digite sua altura: ");  //com .
            var altura = Convert.ToDecimal(Console.ReadLine());   //conversão de dados
            Console.WriteLine("Digite seu peso: ");
            var peso = Convert.ToDecimal(Console.ReadLine());

            //+ - * /
            var imc = Math.Round((peso / (altura * altura)) * 10000), 2);   //calculo imc + conversão para valor real

            Console.WriteLine("O seu nome é: " + nomePessoa);
            Console.WriteLine("Você tem " + idade + " anos");
            Console.WriteLine("Seu IMC é " + imc);
        }
    }
}
