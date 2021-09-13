using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPessoa2.Models
{
    public class Pessoa
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
