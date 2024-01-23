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
    public class HasStudyingSchedule : IHasStudyingSchedule
    {
        public readonly StudentDescriptor m_Descriptor;

        public HasStudyingSchedule(StudentDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public ICanBeBuilt WithSchedule(params SubjectSchedule[] subjectsSchedules)
        {
            if (m_Descriptor.Subjects.Any(s => !subjectsSchedules.Select(ss => ss.Subject).Contains(s)))
            {
                throw new ArgumentException("Some of the registered subjects are not scheduled.");
            }

            if (subjectsSchedules.Select(ss => ss.Subject).Any(s => !m_Descriptor.Subjects.Contains(s)))
            {
                throw new ArgumentException("Some of the scheduled subjects are not registered.");
            }

            var clone = new StudentDescriptor(m_Descriptor)
            {
                SubjectsSchedules = subjectsSchedules.AsEnumerable().Clone().ToList()
            };

            return new CanBeBuilt(clone);
        }
    }
}
