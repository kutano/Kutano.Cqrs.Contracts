using Kutano.Cqrs.Contracts.Commands.Exceptions;
using Kutano.Cqrs.Contracts.Commands.Models;

namespace Kutano.Cqrs.Contracts.Commands.Handlers
{
    /// <summary>
    /// Represents an synchronous command handler with result. 
    /// </summary>
    /// <typeparam name="TCommand">Type of the command to be handled.</typeparam>
    /// <typeparam name="TResult">Type of the result returned after the execution of the command.</typeparam>
    public interface ISynchronousCommandHandler<in TCommand, out TResult> where TCommand : ICommand
    {
        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <returns>The result of the execution of the command.</returns>
        /// <exception cref="HandlingException"></exception>
        TResult Handle(TCommand command);
    }

    /// <summary>
    /// Represents an synchronous command handler without result. 
    /// </summary>
    /// <typeparam name="TCommand">Type of the command to be handled.</typeparam>
    public interface ISynchronousCommandHandler<in TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Handles the specified command and returns the result of the execution
        /// </summary>
        /// <param name="command">The command to be handled.</param>
        /// <exception cref="HandlingException"></exception>
        void Handle(TCommand command);
    }
}