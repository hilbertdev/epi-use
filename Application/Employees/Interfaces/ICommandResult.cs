namespace Application.Employees.Interfaces
{
    public interface ICommandResult
    {
     bool Success { get; set; }
     object Data { get; set; }
    }
}