using OOPAssignment.Interfaces;

namespace OOPAssignment.Entities
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
        }
        public void ExecuteCommand(string commandObject)
        {
            throw new NotImplementedException();
        }
    }
}