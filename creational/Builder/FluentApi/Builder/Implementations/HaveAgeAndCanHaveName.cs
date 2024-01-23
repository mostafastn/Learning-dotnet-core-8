using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class HaveAgeAndCanHaveName : IHaveAgeAndCanHaveName
    {
        private readonly MemberDescriptor m_Descriptor;

        public HaveAgeAndCanHaveName(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasRole WithName(string name)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Name = name };
            return new HasRole(clone);
        }
    }
}
