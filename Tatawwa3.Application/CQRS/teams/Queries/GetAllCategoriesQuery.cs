﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CaregoriesDto>>
    {

    }
}
