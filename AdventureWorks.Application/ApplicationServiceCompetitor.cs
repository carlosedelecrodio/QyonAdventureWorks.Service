using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Application
{
    public class ApplicationServiceCompetitor : IApplicationServiceCompetitor
    {
        private readonly ICompetitorService competitorService;
        private ICompetitorMapper competitorMapper;
        private IApplicationValidations validations;
        private readonly IRaceHistoryService raceHistoryService;

        public ApplicationServiceCompetitor(ICompetitorService competitorService, ICompetitorMapper competitorMapper, IApplicationValidations validations, IRaceHistoryService raceHistoryService)
        {
            this.competitorService = competitorService;
            this.competitorMapper = competitorMapper;
            this.validations = validations;
            this.raceHistoryService= raceHistoryService;
        }

        public void Add(CompetitorDto competitorDto)
        {
            var temperatureIsValid = validations.TemperatureIsValid(competitorDto.AverageTemperature);
            var weightIsValid = validations.WeightIsValid(competitorDto.Weight);
            var heightIsValid = validations.HeightIsValid(competitorDto.Height);
            var genderIsValid = validations.GenderIsValid(competitorDto.Gender);

            var competitor = competitorMapper.MapperDtoToEntity(competitorDto); 

            if (temperatureIsValid && weightIsValid && heightIsValid && genderIsValid)
            {
                competitorService.Add(competitor);
            }
        }

        public void Delete(CompetitorDto competitorDto)
        {
            var competitor = competitorMapper.MapperDtoToEntity(competitorDto);
            competitorService.Delete(competitor);
        }

        public IEnumerable<CompetitorDto> GetAll()
        {
            var competitors = competitorService.GetAll();
            var raceHistorys = raceHistoryService.GetAll();
            
            var competitorWithoutRace = competitors.Where(c1 => !raceHistorys.Any(c2 => c2.IdCompetitor == c1.IdCompetitor));

            var competitorsDto = competitorMapper.ListCompetitorsDto(competitorWithoutRace);

            return competitorsDto;
        }

        public CompetitorDto GetById(int id)
        {
            var competitor = competitorService.GetById(id);
            var competitorDto = competitorMapper.MapperEntityToDto(competitor);

            return competitorDto;
        }

        public void Update(CompetitorDto competitorDto)
        {
            var competitor = competitorMapper.MapperDtoToEntity(competitorDto);
            competitorService.Update(competitor);
        }
    }
}
