namespace TPL.Application.Shared.Interfaces;

public partial interface IDataService {
    Task<List<LibraryViewModel>> LibrariesGetAllAsync(LibrariesGetAllQuery qry);
}