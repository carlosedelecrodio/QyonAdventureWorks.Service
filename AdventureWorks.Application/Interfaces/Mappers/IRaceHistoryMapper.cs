using AdventureWorks.Application.Dtos;
using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces.Mappers
{
    public interface IRaceHistoryMapper
    {
        RaceHistory MapperDtoToEntity(RaceHistoryDto raceHistoryDto);

        IEnumerable<RaceHistoryDto> ListRaceHistorysDto(IEnumerable<RaceHistory> raceHistorys);

        RaceHistoryDto MapperEntityToDto(RaceHistory raceHistory);
    }
}
