using System;
//se a outra classe tiver o name space diferente use a linha a baixo para referenciar
using ProgramacaoOrientadaObjeto.Cadastros;

namespace ProgramacaoOrientadaObjeto{
    public class Program    {

        public static void Main(string[] args)        {
            //para criar um objeto digite o nome da classe que você quer referenciar, o nome do objeto, sinal de = e a palavra new();
Pessoa objetoPessoa = new();
objetoPessoa.Nome = "João";
objetoPessoa.Sobrenome = "Silva";
Console.WriteLine($"o nome da pessoa é {objetoPessoa.Nome} {objetoPessoa.Sobrenome}");

//passando parâmetro da sobrecarga do construtor
Console.WriteLine("digite a sua data de nascimento (dd/MM/aaaa)");
String? textoDataNascimento = Console.ReadLine();
int ano = Convert.ToInt32(textoDataNascimento?.Substring(6, 4));
int mes = Convert.ToInt32(textoDataNascimento?.Substring(3, 2));
int dia = Convert.ToInt32(textoDataNascimento?.Substring(0, 2));
Pessoa novoObjetoPessoa = new("Maria", "Silva", new DateTime(ano, mes, dia));
Console.WriteLine($"o nome da pessoa do novo objeto é {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()}");
}
}
}