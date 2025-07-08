using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class UpdateTeamPageCommandHandler : IRequestHandler<UpdateTeamPageCommand, Unit>
    {
        private readonly Tatawwa3DbContext  _context;
        IMapper _mapper;

        public UpdateTeamPageCommandHandler(Tatawwa3DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        
        }

        //public async Task<Unit> Handle(UpdateTeamPageCommand request, CancellationToken cancellationToken)
        //{
            //var dto = request.Dto;

            //var team = await _context.Teams.FindAsync(dto.Id);
            //if (team == null)

            //throw new KeyNotFoundException("Team not found");


            //Console.WriteLine($"IsDeleted: {team.IsDeleted}");

            //_mapper.Map(dto, team);
            //Console.WriteLine("تم حفظ التحديث: " + team.City + " - " + team.MaxMembers);
            //await _context.SaveChangesAsync(cancellationToken);

            //return Unit.Value;


            public async Task<Unit> Handle(UpdateTeamPageCommand request, CancellationToken cancellationToken)
        {
            var dto = request.Dto;

            var team = await _context.Teams.FindAsync(dto.Id);
            if (team == null)
                throw new KeyNotFoundException("Team not found");

            Console.WriteLine($"قبل التحديث: {team.Name}, {team.City}");

            _mapper.Map(dto, team);
            Console.WriteLine($"بعد التحديث: {team.Name}, {team.City}");

            _context.Entry(team).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                Console.WriteLine("تم الحفظ بنجاح");
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ أثناء الحفظ: " + ex.Message);
            }

            return Unit.Value;
        }
    }
    }

