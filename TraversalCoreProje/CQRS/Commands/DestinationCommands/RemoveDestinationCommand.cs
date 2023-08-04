namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int Id { get; set; }

        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }
    }
}
