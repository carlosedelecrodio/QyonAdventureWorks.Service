using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace QyonAdventureWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceTrackController : ControllerBase
    {
        private readonly IApplicationServiceRaceTrack applicationServiceRaceTrack;

        public RaceTrackController(IApplicationServiceRaceTrack applicationServiceRaceTrack)
        {
            this.applicationServiceRaceTrack = applicationServiceRaceTrack;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceRaceTrack.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceRaceTrack.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] RaceTrackDto raceTrackDto)
        {
            try
            {
                if (raceTrackDto == null)
                    return NotFound();

                applicationServiceRaceTrack.Add(raceTrackDto);
                return Ok("Pista de corrida Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] RaceTrackDto raceTrackDto)
        {
            try
            {
                if (raceTrackDto == null)
                    return NotFound();

                applicationServiceRaceTrack.Update(raceTrackDto);
                return Ok("Pista de corrida Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] RaceTrackDto raceTrackDto)
        {
            try
            {
                if (raceTrackDto == null)
                    return NotFound();

                applicationServiceRaceTrack.Delete(raceTrackDto);
                return Ok("Pista de corrida Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
