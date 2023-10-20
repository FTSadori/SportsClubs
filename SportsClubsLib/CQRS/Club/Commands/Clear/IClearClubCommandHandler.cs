using SportsClubsLib.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.CQRS.Club.Commands.Clear
{
    public interface IClearClubCommandHandler : ICommandHandler<ClearClubCommand>
    {
    }
}
