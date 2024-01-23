﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Interfaces
{
    public interface IHuman
    {
        IHaveAgeAndCanHaveName WithAge(int age);
        IHaveNameAndCanHaveAge WithName(string name);
    }
}