using System;

namespace DataTempo.Entities
{
    internal class Cliente
    {
        public string? Nome { get; private set; }
        public int Idade { get; private set; }
        public DateTime DataIngressou { get; private set; }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.DataIngressou = DateTime.Now;
        }

        public override string ToString() 
        {
            return $"Nome: {this.Nome} | Idade: {this.Idade} | Data De Inclusão: {this.DataIngressou}";
        }
    }
}
