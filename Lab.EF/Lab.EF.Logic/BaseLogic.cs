﻿using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public abstract class BaseLogic
    {
        protected NorthwindContext _northWindContext;

        protected BaseLogic()
        {
            _northWindContext = new NorthwindContext();
        }
    }
}
