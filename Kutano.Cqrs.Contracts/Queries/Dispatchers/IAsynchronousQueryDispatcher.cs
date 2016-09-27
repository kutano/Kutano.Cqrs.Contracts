using System.Threading;
using System.Threading.Tasks;
using Kutano.Cqrs.Contracts.Queries.Exceptions;
using Kutano.Cqrs.Contracts.Queries.Models;

namespace Kutano.Cqrs.Contracts.Queries.Dispatchers
{
    /// <summary>
    /// Represents an asynchronous query dispatcher. 
    /// </summary>
    public interface IAsynchronousQueryDispatcher
    {
        /// <summary>
        /// Dispatches the query and returns the associated result.
        /// </summary>
        /// <typeparam name="TQuery">Type of the query transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TReadModel">Type of the expected result.</typeparam>
        /// <param name="query">Query of type <see cref="TQuery"/> to be processed</param>
        /// <returns>The task object representing the asynchronous operation returning the result of type <see cref="TReadModel"/> resulting of the processing of the query.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task<TReadModel> Dispatch<TQuery, TReadModel>(TQuery query) where TQuery : IQuery;

        /// <summary>
        /// Dispatches the query and returns the associated result.
        /// </summary>
        /// <typeparam name="TQuery">Type of the query transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TReadModel">Type of the expected result.</typeparam>
        /// <param name="query">Query of type <see cref="TQuery"/> to be processed</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation returning the result of type <see cref="TReadModel"/> resulting of the processing of the query.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task<TReadModel> Dispatch<TQuery, TReadModel>(TQuery query, CancellationToken cancellationToken) where TQuery : IQuery;
    }
}
