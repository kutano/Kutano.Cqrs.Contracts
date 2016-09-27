using Kutano.Cqrs.Contracts.Queries.Exceptions;
using Kutano.Cqrs.Contracts.Queries.Models;

namespace Kutano.Cqrs.Contracts.Queries.Handlers
{
    /// <summary>
    /// Represents an synchronous query handler with result. 
    /// </summary>
    /// <typeparam name="TQuery">Type of the query to be handled.</typeparam>
    /// <typeparam name="TResult">Type of the result returned after the execution of the query.</typeparam>
    public interface ISynchronousQueryHandler<in TQuery, out TResult> where TQuery : IQuery
    {
        /// <summary>
        /// Handles the specified query and returns the result of the execution
        /// </summary>
        /// <param name="query">The query to be handled.</param>
        /// <returns>The result of the execution of the query.</returns>
        /// <exception cref="HandlingException"></exception>
        TResult Handle(TQuery query);
    }
}