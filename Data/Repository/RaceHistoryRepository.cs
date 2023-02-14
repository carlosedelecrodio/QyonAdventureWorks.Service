using AdventureWorks.Data.Config;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Repository
{
    public class RaceHistoryRepository : BaseRepository<RaceHistory>, IRaceHistoryRepository
    {
        private readonly ContextBase contextBase;

        public RaceHistoryRepository(ContextBase contextBase)
            : base(contextBase)
        {
            this.contextBase = contextBase; 
        }
    }
}
