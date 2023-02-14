using AdventureWorks.Data.Config;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Repository
{
    public class CompetitorRepository : BaseRepository<Competitor>, ICompetitorRepository
    {
        private readonly ContextBase contextBase;

        public CompetitorRepository(ContextBase contextBase)
            : base(contextBase)
        {
            this.contextBase = contextBase;
        }
    }
}
