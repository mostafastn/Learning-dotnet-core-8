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
    internal class AmTeaching : IAmTeaching
    {
        private readonly TeacherDescriptor m_Descriptor;

        public AmTeaching(TeacherDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasTeachingSchedule Teaching(Subject subject)
        {
            var clone = new TeacherDescriptor(m_Descriptor) { Subject = new Subject(subject) };
            return new HasTeachingSchedule(clone);
        }
    }
}
