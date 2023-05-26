namespace MapProject.Models
{
    public class HomeDataContainer
    {
        public List<Centroid> centroids { get; }
        public List<Centroid> farthestDirectionalCentroids { get; }

        public HomeDataContainer(List<Centroid> centroids, List<Centroid> farthestDirectionalCentroids) 
        {
            this.centroids = centroids;
            this.farthestDirectionalCentroids = farthestDirectionalCentroids;
        }
    }
}