namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
       
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
       
    }
}
