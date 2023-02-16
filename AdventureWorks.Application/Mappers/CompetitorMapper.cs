using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.Application.Mappers
{
    public class CompetitorMapper : ICompetitorMapper
    {
        public Competitor MapperDtoToEntity(CompetitorDto competitorDto)
        {
            var competitor = new Competitor()
            {
                IdCompetitor = competitorDto.IdCompetitor,
                Name = competitorDto.Name,
                Gender = competitorDto.Gender,
                AverageTemperature = competitorDto.AverageTemperature,
                Weight = competitorDto.Weight,
                Height = competitorDto.Height,
            };
            return competitor;
        }

        public CompetitorDto MapperEntityToDto(Competitor competitor)
        {
            CompetitorDto competitorDto = new CompetitorDto()
            {
                IdCompetitor = competitor.IdCompetitor,
                Name = competitor.Name,
                Gender = competitor.Gender,
                AverageTemperature = competitor.AverageTemperature,
                Weight = competitor.Weight,
                Height = competitor.Height,
            };
            return competitorDto;
        }

        public IEnumerable<CompetitorDto> ListCompetitorsDto(IEnumerable<Competitor> competitors)
        {
            var dto = competitors.Select(c => new CompetitorDto()
            {
                IdCompetitor = c.IdCompetitor,
                Name = c.Name,
                Gender = c.Gender,
                AverageTemperature = c.AverageTemperature,
                Weight = c.Weight,
                Height = c.Height,
            });
            return dto;
        }
    }
}
