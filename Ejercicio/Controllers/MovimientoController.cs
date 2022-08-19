using Ejercicio.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio.Controllers
{
    public class MovimientoController : Controller
    {
        private readonly IMediator _mediator;
        public MovimientoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovimiento([FromBody] CreateMovimientoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
