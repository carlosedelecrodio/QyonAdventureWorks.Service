using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Application.Mappers;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Application
{
    public class ApplicationServiceRaceHistory : IApplicationServiceRaceHistory
    {
        private readonly IRaceHistoryService raceHistoryService;
        private IRaceHistoryMapper raceHistoryMapper;
        private IApplicationValidations validations;

        public ApplicationServiceRaceHistory(IRaceHistoryService raceHistoryService, IRaceHistoryMapper raceHistoryMapper, IApplicationValidations validations)
        {
            this.raceHistoryService = raceHistoryService;
            this.raceHistoryMapper = raceHistoryMapper;
            this.validations = validations;
        }

        public void Add(RaceHistoryDto raceHistoryDto)
        {
            var dateIsNotFuture = validations.DateIsNotFuture(raceHistoryDto.RaceDate);

            var raceHistory = raceHistoryMapper.MapperDtoToEntity(raceHistoryDto);

            if (dateIsNotFuture)
            {
                raceHistoryService.Add(raceHistory);
            }
        }

        public void Delete(RaceHistoryDto raceHistoryDto)
        {
            var raceHistory = raceHistoryMapper.MapperDtoToEntity(raceHistoryDto);
            raceHistoryService.Delete(raceHistory);
        }

        public IEnumerable<RaceHistoryDto> GetAll()
        {
            var raceHistorys = raceHistoryService.GetAll();

            IEnumerable<RaceHistory> competitorTimeSpent = (IEnumerable<RaceHistory>)raceHistorys
                .GroupBy(r => r.IdCompetitor)
                .Select(g => new
                {
                    IdCompetitor = g.Key,
                    AverageTimeSpent = g.Average(r => r.TimeSpent)
                });


            var listCompetitorTimeSpent = raceHistoryMapper.ListRaceHistorysDto(competitorTimeSpent);

            return listCompetitorTimeSpent;
        }


        public RaceHistoryDto GetById(int id)
        {
            var raceHistory = raceHistoryService.GetById(id);
            var raceHistoryDto= raceHistoryMapper.MapperEntityToDto(raceHistory);

            return raceHistoryDto;
        }

        public void Update(RaceHistoryDto raceHistoryDto)
        {
            var raceHistory = raceHistoryMapper.MapperDtoToEntity(raceHistoryDto);
            raceHistoryService.Update(raceHistory);
        }

    }
}
