using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.categoriies.Queries;
using Tatawwa3.Application.Dtos.CategoryDto;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;

namespace Tatawwa3.Application.CQRS.categoriies.Handelrs
{
    public class getcatnamesHandlers : IRequestHandler<getcategorynameQuery, List<categorynames>>
    {
        protected ICategoryRepository Category;
        private readonly IMapper _mapper;
        public getcatnamesHandlers(ICategoryRepository category,IMapper mapper)
        {
            Category = category;
            _mapper = mapper;
        }

        public async Task<List<categorynames>> Handle(getcategorynameQuery request, CancellationToken cancellationToken)
        {
            var categories =  Category.GetAll();
            var result = _mapper.Map<List<categorynames>>(categories);
            return result;

        }
    }
}
