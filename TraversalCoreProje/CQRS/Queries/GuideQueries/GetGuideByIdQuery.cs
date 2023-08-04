using MediatR;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery :IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
