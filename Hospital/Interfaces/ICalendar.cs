﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface ICalendar
    {
        IEnumerable<IRecord> Records { get; }
    }
}