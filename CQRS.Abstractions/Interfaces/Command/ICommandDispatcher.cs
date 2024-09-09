namespace CQRS.Abstractions.Interfaces.Command;

public interface ICommandDispatcher
{
    void Execute<TCommand>(TCommand command) where TCommand : ICommand;
    Task ExecuteAsync<TCommand>(TCommand command) where TCommand : ICommand;
}
