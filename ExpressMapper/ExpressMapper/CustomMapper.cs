namespace ExpressMapper
{
    public class CustomMapper : ICustomTypeMapper<Employee, CommunicationsViewModel>
    {
        public CommunicationsViewModel Map(IMappingContext<Employee, CommunicationsViewModel> context)
        {
            return new CommunicationsViewModel() {Id = context.Source.Id, Name = context.Source.Name};
        }
    }
}