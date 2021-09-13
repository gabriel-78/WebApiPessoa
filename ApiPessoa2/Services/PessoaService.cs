using ApiPessoa2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPessoa2.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly PessoaContext _context;

        public PessoaService(PessoaContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Pessoa> GetPessoas()
        {
            var result = _context.Pessoas.ToList();
            return result;
        }

        public Pessoa GetPessoa(int id)
        {
            var result = _context.Pessoas.FirstOrDefault(m => m.Id == id);
            return result;
        }

        public void AddPessoa(Pessoa item)
        {
            var result = _context.Pessoas.FirstOrDefault(m => m.Cpf == item.Cpf);

            if (result == null)
            {
                _context.Add(item);
                _context.SaveChanges();
            }
        }

        public void UpdatePessoa(Pessoa item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void DeletePessoa(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        public bool PessoaExist(int id)
        {
            return _context.Pessoas.Any(e => e.Id == id);
        }
    }
}
