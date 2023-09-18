using SportsClubsLib.Commands.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Commands.Member.Create
{
    public interface ICreateMemberCommand : INoResponseAsyncCommand<CreateMemberDto>
    {

    }
}
