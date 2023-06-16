using System.ComponentModel;
namespace TPL.Infrastructure.CommandQuery;
public class DpfDirectoryAddCommandHandler : IRequestHandler<DpfDirectoryAddCommand, DpfDirectory>
{
    private readonly IRepository<DpfDirectory> _repository;
    public DpfDirectoryAddCommandHandler(IRepository<DpfDirectory> repository)
    {
        _repository = repository;
    }
    public async Task<DpfDirectory> Handle(DpfDirectoryAddCommand cmd, CancellationToken cancellationToken)
    {
        var dpfDirectory = new DpfDirectory(cmd.Name, cmd.FullName);
        return await _repository.AddAsync(dpfDirectory, cancellationToken);
    }
}
