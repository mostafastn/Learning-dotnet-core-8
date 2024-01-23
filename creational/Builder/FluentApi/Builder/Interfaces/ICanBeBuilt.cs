using FluentApi.Builder.Dtos.Descriptors;

namespace FluentApi.Builder.Interfaces
{
    public interface ICanBeBuilt
    {
        public MemberDescriptor Build();
    }
}
