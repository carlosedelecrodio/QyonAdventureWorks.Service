using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Application.Mappers
{
    public class RaceTrackMapper : IRaceTrackMapper
    {
        public RaceTrack MapperDtoToEntity(RaceTrackDto raceTrackDto)
        {
            var raceTrack = new RaceTrack()
            {
                IdRaceTrack = raceTrackDto.IdRaceTrack,
                Description = raceTrackDto.Description,
            };
            return raceTrack;
        }

        public RaceTrackDto MapperEntityToDto(RaceTrack raceTrack)
        {
            RaceTrackDto raceTrackDto = new RaceTrackDto()
            {
                IdRaceTrack = raceTrack.IdRaceTrack,
                Description = raceTrack.Description,
            };
            return raceTrackDto;
        }

        public IEnumerable<RaceTrackDto> ListRaceTracksDto(IEnumerable<RaceTrack> raceTracks)
        {
            var dto = raceTracks.Select(rt => new RaceTrackDto()
            {
                IdRaceTrack = rt.IdRaceTrack,
                Description = rt.Description,
            });
            return dto;
        }
    }
}
