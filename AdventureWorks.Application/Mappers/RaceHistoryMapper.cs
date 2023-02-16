using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Application.Mappers
{
    public class RaceHistoryMapper : IRaceHistoryMapper
    {
        public RaceHistory MapperDtoToEntity(RaceHistoryDto raceHistoryDto)
        {
            var raceHistory = new RaceHistory()
            {
                IdRaceHistory = raceHistoryDto.IdRaceHistory,
                IdCompetitor = raceHistoryDto.IdCompetitor,
                IdRaceTrack = raceHistoryDto.IdRaceTrack,
                RaceDate = raceHistoryDto.RaceDate,
                TimeSpent = raceHistoryDto.TimeSpent,
            };
            return raceHistory;
        }

        public RaceHistoryDto MapperEntityToDto(RaceHistory raceHistory)
        {
            RaceHistoryDto raceHistoryDto = new RaceHistoryDto()
            {
                IdRaceHistory = raceHistory.IdRaceHistory,
                IdCompetitor = raceHistory.IdCompetitor,
                IdRaceTrack = raceHistory.IdRaceTrack,
                RaceDate = raceHistory.RaceDate,
                TimeSpent = raceHistory.TimeSpent,
            };
            return raceHistoryDto;
        }

        public IEnumerable<RaceHistoryDto> ListRaceHistorysDto(IEnumerable<RaceHistory> raceHistorys)
        {
            var dto = raceHistorys.Select(rh => new RaceHistoryDto()
            {
                IdRaceHistory = rh.IdRaceHistory,
                IdCompetitor = rh.IdCompetitor,
                IdRaceTrack = rh.IdRaceTrack,
                RaceDate = rh.RaceDate,
                TimeSpent = rh.TimeSpent,
            });
            return dto;
        }
    }
}
