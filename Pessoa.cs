using System;

namespace ProgramacaoOrientadaObjeto.Cadastros{

 public class Pessoa{

     //Essas são as propriedades. Os nomes de propriedades podem ser qualquer nome
public int Codigo { get; set; }
public String? Nome { get; set; }
public String? Sobrenome { get; set; }
public DateTime DataNascimento { get; set; }

//Esse é o método construtor. Método construtor tem o mesmo nome da classe
public Pessoa(){}
//essa é a sobrecarga do método construtor. Quando usamos o método com mesmo nome e parâmetros diferentes
public Pessoa(String Nome, String Sobrenome, DateTime dataNascimento){

//this acessa os membros de dentro da própria classe
this.Nome = Nome;
this.Sobrenome = Sobrenome;
this.DataNascimento = dataNascimento;
}
public String CalculaIdade(){
    int anos = DateTime.Now.Year - this.DataNascimento.Year;
    if (this.DataNascimento.Month > DateTime.Now.Month)
    anos--;

    return $"{this.Nome} têm {anos} anos de idade";

}
 }   
}