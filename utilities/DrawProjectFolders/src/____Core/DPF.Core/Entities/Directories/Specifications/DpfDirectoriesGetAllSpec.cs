namespace Dpf.Core.Entities;
public class DpfDirectoriesGetAllSpec : Specification<DpfDirectory>
{
    public DpfDirectoriesGetAllSpec()
    {
        Query
            .Take(int.MaxValue)
                .Include(rs => rs.DpfFiles)
                .Include(rs => rs.Children);
            
    }
}
