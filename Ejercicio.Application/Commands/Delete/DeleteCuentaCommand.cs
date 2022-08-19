﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Application.Commands.Delete
{
   public class DeleteCuentaCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}