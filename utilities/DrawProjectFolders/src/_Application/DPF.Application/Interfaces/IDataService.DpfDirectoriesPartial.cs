namespace Dpf.Application.Interfaces;

public partial interface IDataService {
    Task<DpfDirectoryViewModel> DpfDirectoryAddAsync(DpfDirectoryAddCommand cmd);
    Task<List<DpfDirectoryViewModel>> DpfDirectoriesGetAllAsync(DpfDirectoriesGetAllQuery qry);
}