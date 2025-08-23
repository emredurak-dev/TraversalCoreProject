using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery
            query)
        {
            var value = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                destinationid = value.DestinationId,
                city = value.City,
                daynight = value.DayNight,
                price = value.Price

            };
        }
    }
}
