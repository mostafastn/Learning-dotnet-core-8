﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Interfaces
{
    public interface IHasRole
    {
        IAmTeaching AsTeacher { get; }
        IAmStudying AsStudent { get; }
    }
}
