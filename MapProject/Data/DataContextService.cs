using MapProject.Data.Interfaces;
using MapProject.Extensions;
using MapProject.Models;

namespace MapProject.Data
{
    public class DataContextService : IDataContextService
    {
        public List<Centroid> centroids { get ; }

        public DataContextService()
        {
            List<char> charsToRemove = new List<char>() { '#' };
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\content\\csv\\AW_VIETU_CENTROIDI.CSV");
            centroids = new List<Centroid>();
            var firstLine = false;

            using (var reader = new StreamReader(path))
            {
                 while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!firstLine || line == null)
                    {
                        firstLine = true;
                        continue;
                    }

                    var values = line.Split(';');
                    var centroid = new Centroid(
                        values[0].Filter(charsToRemove),
                        values[1].Filter(charsToRemove),
                        values[2].Filter(charsToRemove),
                        values[3].Filter(charsToRemove),
                        values[4].Filter(charsToRemove),
                        values[5].Filter(charsToRemove),
                        double.Parse(values[6].Filter(charsToRemove)),
                        double.Parse(values[7].Filter(charsToRemove)),
                        values[8].Filter(charsToRemove),
                        values[9].Filter(charsToRemove)
                        );

                    centroids.Add(centroid);
                }
            }
        }

        public List<Centroid> GetFarthestDirectionalCentroids()
        {
            var centroids = new List<Centroid>
            {
                GetFarthestWestCentroid(),
                GetFarthestSouthCentroid(),
                GetFarthestEastCentroid(),
                GetFarthestNorhCentroid()
            };

            return centroids;
        }

        private Centroid GetFarthestNorhCentroid()
        {
            return centroids.OrderByDescending(c => c.ddN).First();
        }

        private Centroid GetFarthestEastCentroid()
        {
            return centroids.OrderByDescending(c => c.ddE).First();
        }

        private Centroid GetFarthestSouthCentroid()
        {
            return centroids.OrderByDescending(c => c.ddN).Last();
        }

        private Centroid GetFarthestWestCentroid()
        {
            return centroids.OrderByDescending(c => c.ddE).Last();
        }
    }
}
