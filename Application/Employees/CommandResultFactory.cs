using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Employees.Interfaces;

namespace Application.Employees
{
    public static class CommandResultFactory
    {
        public static ICommandResult CreateSuccessResult(object data)
        {
             return new CreateSuccessResult(data);
        }
    }
}