using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoTreino.Entities
{
     class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set;}
        public DateTime DatadeNascimento { get; set; }


        public Cliente ()
        {

        }

        public Cliente(string nome, string email, DateTime datadeNascimento)
        {
            Nome = nome;
            Email = email;
            DatadeNascimento = datadeNascimento;
        }

        public override string ToString()
        {
            return $"{Nome}  ({DatadeNascimento.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
