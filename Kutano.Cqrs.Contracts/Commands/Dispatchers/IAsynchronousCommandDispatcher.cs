using System.Threading;
using System.Threading.Tasks;
using Kutano.Cqrs.Contracts.Commands.Exceptions;
using Kutano.Cqrs.Contracts.Commands.Models;

namespace Kutano.Cqrs.Contracts.Commands.Dispatchers
{
    /// <summary>
    /// Represents an asynchronous command dispatcher. 
    /// </summary>
    public interface IAsynchronousCommandDispatcher
    {
        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TResult">Type of the expected result.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <returns>The task object representing the asynchronous operation returning the result of type <see cref="TResult"/> resulting of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task<TResult> Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <returns>The task object representing the asynchronous operation of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task Dispatch<TCommand>(TCommand command) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TResult">Type of the expected result.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation returning the result of type <see cref="TResult"/> resulting of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task<TResult> Dispatch<TCommand, TResult>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        Task Dispatch<TCommand>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand;
    }
}
