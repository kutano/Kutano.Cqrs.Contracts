using System;

namespace Kutano.Cqrs.Contracts.Commands.Exceptions
{
    /// <summary>
    /// Represents an exception who may occur during the dispatch of a command.
    /// </summary>
    public class DispatchException : Exception
    {
    }
}
