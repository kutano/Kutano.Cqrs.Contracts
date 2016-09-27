using System.Threading;
using System.Threading.Tasks;
using Kutano.Cqrs.Contracts.Commands.Exceptions;
using Kutano.Cqrs.Contracts.Commands.Models;

namespace Kutano.Cqrs.Contracts.Commands.Handlers
{
    /// <summary>
    /// Represents an asynchronous command handler with result. 
    /// </summary>
    /// <typeparam name="TCommand">Type of the command to be handled.</typeparam>
    /// <typeparam name="TResult">Type of the result returned after the execution of the command.</typeparam>
    public interface IAsynchronousCommandHandler<in TCommand, TResult> where TCommand : ICommand
    {
        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <returns>The task object representing the asynchronous operation returning the result of the execution of the command.</returns>
        /// <exception cref="HandlingException"></exception>
        Task<TResult> Handle(TCommand command);

        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation returning the  result of the execution of the command.</returns>
        /// <exception cref="HandlingException"></exception>
        Task<TResult> Handle(TCommand command, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Represents an asynchronous command handler without result. 
    /// </summary>
    /// <typeparam name="TCommand">Type of the command to be handled.</typeparam>
    public interface IAsynchronousCommandHandler<in TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="HandlingException"></exception>
        Task Handle(TCommand command);

        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that will be assigned to the new task.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="HandlingException"></exception>
        Task Handle(TCommand command, CancellationToken cancellationToken);
    }
}