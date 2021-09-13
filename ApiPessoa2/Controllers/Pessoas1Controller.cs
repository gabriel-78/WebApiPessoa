using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiPessoa2.Models;
using ApiPessoa2.Services;

namespace ApiPessoa2.Controllers
{
    public class Pessoas1Controller : Controller
    {
        private readonly IPessoaService _service;

        public Pessoas1Controller(IPessoaService service)
        {
            _service = service;
        }

        // GET: Pessoas1
        public IActionResult Index()
        {
            return View(_service.GetPessoas());
        }

        public IActionResult Get()
        {
            return new JsonResult(_service.GetPessoas());
        }

        public IActionResult GetById(int? id)
        {
            if (id == null) return NotFound();

            var result = _service.GetPessoa(id.Value);

            if (result == null) return NotFound();

            return View(result);
        }

        // GET: Pessoas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pessoas1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Cpf,Nome,Sobrenome,Email")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _service.AddPessoa(pessoa);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        // GET: Pessoas1/Update
        public IActionResult Update(int? id)
        {
            if (_service.PessoaExist(id.Value))
            {
                return View(_service.GetPessoa(id.Value));
            }
            
            return NotFound();
        }

        // POST: Pessoas1/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int? id, [Bind("Id,Cpf,Nome,Sobrenome,Email")] Pessoa pessoa)
        {
            _service.UpdatePessoa(pessoa);
            return RedirectToAction("Index");
        }

        // GET: Pessoas1/Delete
        public IActionResult Delete(int id)
        {
            return View(_service.GetPessoa(id));
        }

        // POST: Pessoas1/Delete
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            _service.DeletePessoa(id.Value);
            return RedirectToAction("Index");
        }
    }
}
