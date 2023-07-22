namespace YmiCore.Entities;
public class GameGetByIdSpec : Specification<Game>, ISingleResultSpecification
{
    public GameGetByIdSpec(Guid id)
    {
        Query
            .Include(rs => rs.Player)
                .ThenInclude(rs => rs.StorageContainers)
                    .ThenInclude(rs => rs.StorageItems)
            .Include(rs => rs.CurrentCity)
            .Include(rs => rs.LocationRegions)
            .Include(rs => rs.LostItemsStorageContainers)
            .Where(rs => rs.Id == id);
    }
}
