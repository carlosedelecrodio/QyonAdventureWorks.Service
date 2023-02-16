using AdventureWorks.Application.Dtos;
using AdventureWorks.Application.Interfaces;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Application.Mappers;
using AdventureWorks.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Application
{
    public class ApplicationServiceRaceTrack : IApplicationServiceRaceTrack
    {
        private readonly IRaceTrackService raceTrackService;
        private IRaceTrackMapper raceTrackMapper;
        private IApplicationValidations applicationValidations;
        private readonly IRaceHistoryService raceHistoryService;

        public ApplicationServiceRaceTrack(IRaceTrackService raceTrackService, IRaceTrackMapper raceTrackMapper, IApplicationValidations applicationValidations)
        {
            this.raceTrackService = raceTrackService;
            this.raceTrackMapper = raceTrackMapper;
            this.applicationValidations = applicationValidations;
        }

        public void Add(RaceTrackDto raceTrackDto)
        {
            var raceTrack = raceTrackMapper.MapperDtoToEntity(raceTrackDto);
            raceTrackService.Add(raceTrack);
        }

        public void Delete(RaceTrackDto raceTrackDto)
        {
            var raceTrack = raceTrackMapper.MapperDtoToEntity(raceTrackDto);
            raceTrackService.Delete(raceTrack);
        }

        public IEnumerable<RaceTrackDto> GetAll()
        {
            var raceTracks = raceTrackService.GetAll();
            var raceHistory = raceHistoryService.GetAll();

            var raceTrackWithRace = raceTracks.Where(c1 => raceHistory.Any(c2 => c2.IdRaceTrack == c1.IdRaceTrack));

            var raceTracksDto = raceTrackMapper.ListRaceTracksDto(raceTrackWithRace);

            return raceTracksDto;
        }

        public RaceTrackDto GetById(int id)
        {
            var raceHistory = raceTrackService.GetById(id);
            var raceHistoryDto = raceTrackMapper.MapperEntityToDto(raceHistory);

            return raceHistoryDto;
        }

        public void Update(RaceTrackDto raceTrackDto)
        {
            var raceTrack = raceTrackMapper.MapperDtoToEntity(raceTrackDto);
            raceTrackService.Update(raceTrack);
        }
    }
}
