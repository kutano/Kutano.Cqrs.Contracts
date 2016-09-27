using System.Threading;
using System.Threading.Tasks;
using Kutano.Cqrs.Contracts.Queries.Exceptions;
using Kutano.Cqrs.Contracts.Queries.Models;

namespace Kutano.Cqrs.Contracts.Queries.Handlers
{
    /// <summary>
    /// Represents an asynchronous query handler with result. 
    /// </summary>
    /// <typeparam name="TQuery">Type of the query to be handled.</typeparam>
    /// <typeparam name="TResult">Type of the result returned after the execution of the query.</typeparam>
    public interface IAsynchronousQueryHandler<in TQuery, TResult> where TQuery : IQuery
    {
        /// <summary>
        /// Handles the specified query and returns the result of the execution
        /// </summary>
        /// <param name="query">The query to be handled.</param>
        /// <returns>The task object representing the asynchronous operation returning the result of the execution of the query.</returns>
        /// <exception cref="HandlingException"></exception>
        Task<TResult> Handle(TQuery query);

        /// <summary>
        /// Handles the specified query and returns the result of the execution
        /// </summary>
        /// <param name="query">The query to be handled.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation returning the  result of the execution of the query.</returns>
        /// <exception cref="HandlingException"></exception>
        Task<TResult> Handle(TQuery query, CancellationToken cancellationToken);
    }
}