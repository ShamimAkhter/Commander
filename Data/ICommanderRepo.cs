using System.Collections.Generic;
using MvcRestApiCore3_Commander.Models;

namespace MvcRestApiCore3_Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
