using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Services.Services
{
    public class RaceHistoryService : BaseService<RaceHistory>, IRaceHistoryService
    {
        private readonly IRaceHistoryRepository repositoryRaceHistory;

        public RaceHistoryService(IRaceHistoryRepository repositoryRaceHistory)
         : base(repositoryRaceHistory)
        {
            this.repositoryRaceHistory = repositoryRaceHistory;
        }
    }
}

