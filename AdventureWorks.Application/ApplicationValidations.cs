using AdventureWorks.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Application
{
    public class ApplicationValidations : IApplicationValidations
    {
        public bool TemperatureIsValid(double temperature)
        {
            if (temperature > 36 && temperature < 38)
            {
                return true;
            }
            return false;
        }

        public bool WeightIsValid(double weight)
        {
            if (weight > 0)
            {
                return true;
            }
            return false;
        }

        public bool HeightIsValid(double height)
        {
            if (height > 0)
            {
                return true;
            }
            return false;
        }

        public bool GenderIsValid(char gender)
        {
            if (gender == 'M' || gender == 'F' || gender == 'O')
            {
                return true;
            }
            return false;
        }

        public bool DateIsNotFuture(DateTime dateTime)
        {
            if (dateTime <= DateTime.Now)
            {
                return true;
            }
            return false;
        }

    }
}
