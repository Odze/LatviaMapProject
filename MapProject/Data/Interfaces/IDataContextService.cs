using MapProject.Models;

namespace MapProject.Data.Interfaces
{
    public interface IDataContextService
    {
        List<Centroid> centroids { get; }
        List<Centroid> GetFarthestDirectionalCentroids();
    }
}
