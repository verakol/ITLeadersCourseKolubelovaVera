namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public interface IWorker : IEmployee
    {
        Task TakeTask(Task task);

        Task CloseTask(Task task);
    }
}
