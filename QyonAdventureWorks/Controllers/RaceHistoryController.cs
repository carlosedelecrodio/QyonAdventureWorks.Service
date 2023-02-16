using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace QyonAdventureWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceHistoryController : ControllerBase
    {
        private readonly IApplicationServiceRaceHistory applicationServiceRaceHistory;

        public RaceHistoryController(IApplicationServiceRaceHistory applicationServiceRaceHistory)
        {
            this.applicationServiceRaceHistory = applicationServiceRaceHistory;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceRaceHistory.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceRaceHistory.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] RaceHistoryDto raceHistoryDto)
        {
            try
            {
                if (raceHistoryDto == null)
                    return NotFound();

                applicationServiceRaceHistory.Add(raceHistoryDto);
                return Ok("Histórico de corrida Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] RaceHistoryDto raceHistoryDto)
        {
            try
            {
                if (raceHistoryDto == null)
                    return NotFound();

                applicationServiceRaceHistory.Update(raceHistoryDto);
                return Ok("Histórico de corrida Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] RaceHistoryDto raceHistoryDto)
        {
            try
            {
                if (raceHistoryDto == null)
                    return NotFound();

                applicationServiceRaceHistory.Delete(raceHistoryDto);
                return Ok("Histórico de corrida Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
