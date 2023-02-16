using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application.Interfaces
{
    public interface IApplicationValidations
    {
        bool TemperatureIsValid(double temperature);

        bool WeightIsValid(double weight);

        bool HeightIsValid(double height);

        bool GenderIsValid(char gender);

        bool DateIsNotFuture(DateTime raceDate);
    }
}
