using AdventureWorks.Application.Dtos;
using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces.Mappers
{
    public interface IRaceTrackMapper
    {
        RaceTrack MapperDtoToEntity(RaceTrackDto raceTrackDto);

        IEnumerable<RaceTrackDto> ListRaceTracksDto(IEnumerable<RaceTrack> raceTracks);

        RaceTrackDto MapperEntityToDto(RaceTrack raceTrack);
    }
}
