﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class BronQabalaModel
    {
        public BronInfo BronInfo { get; set; }

        public List<SimiliarTour> SimiliarTours { get; set; }
    }
}
