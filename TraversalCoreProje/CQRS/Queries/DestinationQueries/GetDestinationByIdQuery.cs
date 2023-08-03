namespace TraversalCoreProje.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public int id { get; set; }

        public GetDestinationByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
