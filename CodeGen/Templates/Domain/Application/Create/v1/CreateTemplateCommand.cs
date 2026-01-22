using System.ComponentModel;
using MediatR;
using Mapster;
namespace [Root_Namespace].[Module_Namespace].[Module].Application.[EntitySet].Create.v1;

public sealed record Create[Entity]Command(
  [CreatePropertyConstructor]
    ) : IRequest<Create[Entity]Response>;
