﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum CrudStatus
    {
        Default,
        Update,
        Create,
        Delete,
    }

}
