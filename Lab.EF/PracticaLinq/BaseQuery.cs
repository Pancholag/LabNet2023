﻿using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    public abstract class BaseQuery
    {
        protected NorthwindContext northwindContext = new NorthwindContext();
    }
}
