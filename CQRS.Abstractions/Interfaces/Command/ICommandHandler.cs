namespace CQRS.Abstractions.Interfaces.Command;

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    void Execute(TCommand command);
    Task ExecuteAsync(TCommand command);
}
