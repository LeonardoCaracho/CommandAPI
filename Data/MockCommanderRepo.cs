using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command> {
                new Command{Id=0, HowTo="Fry", Line="podias", Platform="yaaaj"},
                new Command{Id=1, HowTo="Fry", Line="podias", Platform="yaaaj"},
                new Command{Id=2, HowTo="Fry", Line="podias", Platform="yaaaj"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Fry", Line="podias", Platform="yaaaj"};
        }
    }
}