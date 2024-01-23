using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class MemberBuilder : IMemberBuilder
    {
        public IHuman New => new Human(new MemberDescriptor());
    }
}
