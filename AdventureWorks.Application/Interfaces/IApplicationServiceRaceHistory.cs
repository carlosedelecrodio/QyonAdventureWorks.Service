using AdventureWorks.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces
{
    public interface IApplicationServiceRaceHistory
    {
        RaceHistoryDto GetById(int id);

        IEnumerable<RaceHistoryDto> GetAll();

        void Add(RaceHistoryDto raceHistoryDto);

        void Update(RaceHistoryDto raceHistoryDto);

        void Delete(RaceHistoryDto raceHistoryDto);
    }
}
