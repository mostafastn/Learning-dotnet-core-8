using FluentApi.Builder.Dtos.Descriptors;
using FluentApi.Builder.Dtos;
using FluentApi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Builder.Implementations
{
    public class HasRole : IHasRole
    {
        private readonly MemberDescriptor m_Descriptor;

        public HasRole(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IAmTeaching AsTeacher =>
            new AmTeaching(new TeacherDescriptor(m_Descriptor) { Role = MemberRole.Teacher });

        public IAmStudying AsStudent =>
            new AmStudying(new StudentDescriptor(m_Descriptor) { Role = MemberRole.Student });
    }
}
