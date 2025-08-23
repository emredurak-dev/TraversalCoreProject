namespace TraversalCoreProject.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    {
        public int destinationid { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
    }
}
