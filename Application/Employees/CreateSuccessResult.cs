using Application.Employees.Interfaces;

namespace Application.Employees
{
    internal class CreateSuccessResult : ICommandResult
    {
        private object data;

        public CreateSuccessResult(object data)
        {
            this.Success = true;
            this.data = data;
        }

        public bool Success {get; set;}
        public object Data {get; set;}
    }
}