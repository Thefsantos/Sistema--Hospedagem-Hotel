namespace DesafioProjetoHospedagem.Models;

public class Pessoa 
{
    public Pessoa() { }

    public Pessoa(string nome) // <- Construtor 1
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome) // <- Construtor 2
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}