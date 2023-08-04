using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
