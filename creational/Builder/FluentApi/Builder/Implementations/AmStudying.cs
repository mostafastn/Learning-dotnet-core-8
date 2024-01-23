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
    public class AmStudying : IAmStudying
    {
        private readonly StudentDescriptor m_Descriptor;

        public AmStudying(StudentDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasStudyingSchedule Studying(params Subject[] subjects)
        {
            var clone = new StudentDescriptor(m_Descriptor) { Subjects = subjects.AsEnumerable().Clone().ToList() };
            return new HasStudyingSchedule(clone);
        }
    }
}
