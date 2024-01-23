using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class HaveNameAndCanHaveAge : IHaveNameAndCanHaveAge
    {
        private readonly MemberDescriptor m_Descriptor;

        public HaveNameAndCanHaveAge(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasRole WithAge(int age)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Age = age };
            return new HasRole(clone);
        }
    }
}
