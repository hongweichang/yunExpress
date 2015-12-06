﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LighTake.Infrastructure.Data
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
