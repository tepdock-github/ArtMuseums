﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class PaintingForCreationDto
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}
