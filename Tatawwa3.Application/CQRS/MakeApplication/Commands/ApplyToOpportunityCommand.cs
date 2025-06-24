using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.ApplicationDtos;


namespace Tatawwa3.Application.CQRS.MakeApplication.Commands
{
  public class ApplyToOpportunityCommand:IRequest<string>
    {
       public addApplicationDto addapplication { get; set; }
    }
}
