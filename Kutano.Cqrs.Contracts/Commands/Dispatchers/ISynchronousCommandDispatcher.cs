using System.Threading;
using Kutano.Cqrs.Contracts.Commands.Exceptions;
using Kutano.Cqrs.Contracts.Commands.Models;

namespace Kutano.Cqrs.Contracts.Commands.Dispatchers
{
    /// <summary>
    /// Represents a synchronous command dispatcher. 
    /// </summary>
    public interface ISynchronousCommandDispatcher
    {
        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TResult">Type of the expected result.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <returns>The result of type <see cref="TResult"/> resulting of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        TResult Dispatch<TCommand, TResult>(TCommand command) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        void Dispatch<TCommand>(TCommand command) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <typeparam name="TResult">Type of the expected result.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The result of type <see cref="TResult"/> resulting of the processing of the command.</returns>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        TResult Dispatch<TCommand, TResult>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand;

        /// <summary>
        /// Dispatches the command and returns the associated result.
        /// </summary>
        /// <typeparam name="TCommand">Type of the command transmitted by the dispatcher.</typeparam>
        /// <param name="command">Command of type <see cref="TCommand"/> to be processed</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <exception cref="DispatchException">Throws a dispatch exception when an error occurred during the dispatch.</exception>
        void Dispatch<TCommand>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand;
    }
}