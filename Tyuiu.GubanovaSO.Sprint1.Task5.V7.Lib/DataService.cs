﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GubanovaSO.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            return Convert.ToInt32(Math.Floor((f / 30)));
        }
    }
}
