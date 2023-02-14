using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Repositories;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Services.Services
{
    public class RaceTrackService : BaseService<RaceTrack>, IRaceTrackService
    {
        private readonly IRaceTrackRepository repositoryRaceTrack;

        public RaceTrackService(IRaceTrackRepository repositoryRaceTrack)
            : base(repositoryRaceTrack)
        {
            this.repositoryRaceTrack = repositoryRaceTrack;
        }
    }
}
