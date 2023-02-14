using AdventureWorks.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces
{
    public interface IApplicationServiceRaceTrack
    {
        RaceTrackDto GetById(int id);

        IEnumerable<RaceTrackDto> GetAll();

        void Add(RaceTrackDto raceTrackDto);

        void Update(RaceTrackDto raceTrackDto);

        void Delete(RaceTrackDto raceTrackDto);
    }
}
