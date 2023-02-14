using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Services.Services
{
    public class CompetitorService : BaseService<Competitor>, ICompetitorService
    {
        private readonly ICompetitorRepository competitorRepository;

        public CompetitorService(ICompetitorRepository competitorRepository)
            : base(competitorRepository)
        {
            this.competitorRepository = competitorRepository;
        }
    }
}
