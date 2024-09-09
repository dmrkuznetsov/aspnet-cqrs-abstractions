namespace CQRS.Abstractions.Interfaces.Query;

public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult> 
{
    TResult Execute(TQuery query);
    Task<TResult> ExecuteAsync(TQuery query);
}
