namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int destinationid { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
    }
}
