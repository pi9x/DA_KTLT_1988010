﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.DAL
{
    interface IDataWriter
    {
        void Write<T>(List<T> objects);
    }
}