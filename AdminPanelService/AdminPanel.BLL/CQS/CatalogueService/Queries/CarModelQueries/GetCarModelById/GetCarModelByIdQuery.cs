using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;

public sealed record GetCarModelByIdQuery(Guid Id) : IRequest<CarModel>;