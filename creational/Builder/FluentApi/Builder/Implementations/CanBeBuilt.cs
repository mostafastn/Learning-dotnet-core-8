using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class CanBeBuilt : ICanBeBuilt
    {
        private readonly MemberDescriptor m_Descriptor;

        public CanBeBuilt(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public MemberDescriptor Build()
        {
            return m_Descriptor.Clone();
        }
    }
}
