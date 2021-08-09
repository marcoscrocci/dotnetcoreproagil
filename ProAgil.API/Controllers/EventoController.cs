using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Data;
using ProAgil.API.Model;
using Microsoft.AspNetCore.Http;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

        // GET api/evento
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _context.Eventos.ToList();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou!");
            }
        }

        //GET api/evento/1
        [HttpGet("{EventoId}")]
        public ActionResult<Evento> Get(int EventoId)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == EventoId);
            /**
            return new Evento[] {
                new Evento {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault(x => x.EventoId == EventoId);
            */
        }

    }
}