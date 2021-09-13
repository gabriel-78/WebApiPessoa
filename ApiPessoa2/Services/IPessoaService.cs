using ApiPessoa2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPessoa2.Services
{
    public interface IPessoaService : IDisposable
    {
        List<Pessoa> GetPessoas();
        Pessoa GetPessoa(int id);
        void AddPessoa(Pessoa item);
        void UpdatePessoa(Pessoa item);
        void DeletePessoa(int id);
        bool PessoaExist(int id);
    }
}
