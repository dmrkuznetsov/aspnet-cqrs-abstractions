namespace CQRS.Abstractions.Interfaces.Query;

public interface IQueryDispatcher
{
    TResult Execute<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    Task<TResult> ExecuteAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
}
