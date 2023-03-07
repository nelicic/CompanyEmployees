using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public EmployeeService(IRepositoryManager repository, ILoggerManager logger)
    {
        _logger = logger;
        _repository = repository;
    }
}