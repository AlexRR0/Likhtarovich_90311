﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Likhtarovich_90311.Blazor.Data
{
    public class CounterModel
    {
        [DataType("int")]
        [Range(0, int.MaxValue)]
        public int CounterValue { get; set; }
    }
}
