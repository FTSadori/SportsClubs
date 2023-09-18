using SportsClubsLib.Data;
using SportsClubsLib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubsLib.Commands.Member.Create
{
    public sealed class CreateMemberCommand : ICreateMemberCommand
    {
        private readonly SportsClubsDbContext _context;

        public CreateMemberCommand(SportsClubsDbContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateMemberDto data)
        {
            MemberEntity entity = new MemberEntity(data.Name, data.Surname, data.Patronymic, data.Position, data.ClubId);

            _context.Members.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
