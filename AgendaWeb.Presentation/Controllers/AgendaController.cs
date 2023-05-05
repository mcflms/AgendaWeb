﻿using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
   
     public class AgendaController : Controller
    {

        //atributo 
        private readonly IEventoRepository _eventoRepository;

        //construtor para inicializar o atributo
        public AgendaController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //Annotation indica que o método será executado no SUBMIT 
        public IActionResult Cadastro(EventoCadastroViewModel model)
        {
            //VERIFICAR SE TODOS OS CAMPOS PASSARAM NA REGRAS DE VALIDAÇÃO
            if (ModelState.IsValid)
            {

                try
                {
                     var evento = new Evento
                    {
                        Id = Guid.NewGuid(),
                        Nome = model.Nome,
                        Data = Convert.ToDateTime(model.Data),
                        Hora = TimeSpan.Parse(model.Hora),
                        Descricao = model.Descricao,
                        Prioridade = Convert.ToInt32(model.Prioridade),
                        DataInclusao = DateTime.Now,    
                        DataAlteracao = DateTime.Now,   
                    };



                    //gravando no banco dew dados 
                    _eventoRepository.Create(evento);

                    TempData["Mensagem"] = $"Evento{evento.Nome},Cadastrado com Sucesso.";
                    ModelState.Clear(); // Limpando os campos do formulario (model)

                }
                catch (Exception e) 
                {
                    TempData["Mensagem"] = e.Message;
                }

            }
            return View();
        }      

          

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost]  //Annotation indica que o método será executado no SUBMIT 
        public IActionResult Consulta(EventoConsultaViewModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        public IActionResult Edicao()
        {
            return View();
        }

        public IActionResult Relatorio() 
        {
            return View();
        }
     }
}
