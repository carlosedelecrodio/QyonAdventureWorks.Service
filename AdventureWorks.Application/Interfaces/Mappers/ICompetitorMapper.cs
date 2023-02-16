using AdventureWorks.Application.Dtos;
using AdventureWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces.Mappers
{
    public interface ICompetitorMapper
    {
        Competitor MapperDtoToEntity(CompetitorDto competitorDto);

        IEnumerable<CompetitorDto> ListCompetitorsDto(IEnumerable<Competitor> competitors);

        CompetitorDto MapperEntityToDto(Competitor competitor);
    }
}
