using Microsoft.AspNetCore.Http;
using Shared.RequestFeatures;

namespace Entities.LinksModels;

public record LinkParameters(EmployeeParameters EmployeeParameters, HttpContext Context)
{
}
