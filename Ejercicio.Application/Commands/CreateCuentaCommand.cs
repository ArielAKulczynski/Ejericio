﻿using Ejercicio.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Commands
{
    public class CreateCuentaCommand: IRequest<CuentaResponse>
	{
	    public int clienteId { get; set; }
		public int numeroCuenta { get; set; }
		public string tipoCuenta { get; set; }
		public int saldoInicial { get; set; }
		public bool estado { get; set; }
	}
}
