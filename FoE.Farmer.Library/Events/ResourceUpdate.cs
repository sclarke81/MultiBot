﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoE.Farmer.Library.Events
{
    public class ResourceUpdateEventArgs : EventArgs
    {
        public (string, int)[] Values { get; set; }
    }
}
