namespace TPL.Application.Interfaces;

public partial interface IDataService {
    Task<List<LibraryViewModel>> LibrariesGetAllAsync(LibrariesGetAllQuery qry);
}