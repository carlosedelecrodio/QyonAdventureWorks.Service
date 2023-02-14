using AdventureWorks.Data.Config;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Repository
{
    public class RaceTrackRepository : BaseRepository<RaceTrack>, IRaceTrackRepository
    {
        private readonly ContextBase contextBase;

        public RaceTrackRepository(ContextBase contextBase)
            : base(contextBase) 
        {
            this.contextBase = contextBase;
        }
    }
}
