using Ejercicio.Application.Commands;
using Ejercicio.Application.Commands.Delete;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task <IActionResult>CreatePersona([FromBody]CreateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> UptatePersona(int id)
        {
            return Ok(await _mediator.Send(new DeleteClientCommand { Id = id }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(int id)
        {
            return Ok(await _mediator.Send(new DeleteClientCommand { Id = id }));
        }
    }
}
