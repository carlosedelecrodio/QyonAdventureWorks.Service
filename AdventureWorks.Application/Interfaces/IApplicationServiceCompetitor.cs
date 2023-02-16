using AdventureWorks.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces
{
    public interface IApplicationServiceCompetitor
    {
        CompetitorDto GetById(int id);

        IEnumerable<CompetitorDto> GetAll();

        void Add(CompetitorDto competitorDto);

        void Update(CompetitorDto competitorDto);

        void Delete(CompetitorDto competitorDto);
    }
}
