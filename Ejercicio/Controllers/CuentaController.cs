using Ejercicio.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio.Controllers
{
    public class CuentaController : Controller
    {
        private readonly IMediator _mediator;
        public CuentaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCuenta([FromBody] CreateCuentaCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
