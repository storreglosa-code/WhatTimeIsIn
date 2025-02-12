using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTimeIsIn
{
    public class TimeZoneService
    {
        public DateTime GetLocalDateById(string Id)
        {
            var tZone = TimeZoneInfo.FindSystemTimeZoneById(Id);
            return TimeZoneInfo.ConvertTime(DateTime.Now, tZone);
        }
    }
}
