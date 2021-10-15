using System;

namespace OOPAssignment.Interfaces
{
    public interface IStringCommand : ICommand<string>
    {
        ///
        public new void ExecuteCommand(string commandObject);
        ///
    }
}