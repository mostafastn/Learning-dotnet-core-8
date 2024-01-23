using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class Human : IHuman
    {
        private readonly MemberDescriptor m_Descriptor;

        public Human(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHaveNameAndCanHaveAge WithName(string name)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Name = name };
            return new HaveNameAndCanHaveAge(clone);
        }

        public IHaveAgeAndCanHaveName WithAge(int age)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Age = age };
            return new HaveAgeAndCanHaveName(clone);
        }
    }
}
