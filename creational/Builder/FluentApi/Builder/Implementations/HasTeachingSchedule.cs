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
    public class HasTeachingSchedule : IHasTeachingSchedule
    {
        private readonly TeacherDescriptor m_Descriptor;

        public HasTeachingSchedule(TeacherDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public ICanBeBuilt WithSchedule(params Schedule[] schedules)
        {
            var clone = new TeacherDescriptor(m_Descriptor)
            {
                Schedules = schedules.AsEnumerable().Clone().ToList()
            };

            return new CanBeBuilt(clone);
        }
    }
}
