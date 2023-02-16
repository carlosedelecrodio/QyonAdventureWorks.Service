using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace QyonAdventureWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly IApplicationServiceCompetitor applicationServiceCompetitor;

        public CompetitorController(IApplicationServiceCompetitor applicationServiceCompetitor)
        {
            this.applicationServiceCompetitor = applicationServiceCompetitor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCompetitor.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceCompetitor.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CompetitorDto competitorDto)
        {
            try
            {
                if (competitorDto == null)
                    return NotFound();

                applicationServiceCompetitor.Add(competitorDto);
                return Ok("Competidor Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CompetitorDto competitorDto)
        {
            try
            {
                if (competitorDto == null)
                    return NotFound();

                applicationServiceCompetitor.Update(competitorDto);
                return Ok("Competidor Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] CompetitorDto competitorDto)
        {
            try
            {
                if (competitorDto == null)
                    return NotFound();

                applicationServiceCompetitor.Delete(competitorDto);
                return Ok("Competidor Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
