
namespace MapProject.Models
{
    public class Centroid
    {
        public string code { get; }
        public string typeCD { get; }
        public string name { get; }
        public string vkurCD { get; }
        public string vkurType { get; }
        public string std { get; }
        public double coordinateX { get; }
        public double coordinateY { get; }
        public string ddN { get; }
        public string ddE { get; }

        public Centroid(string code, string typeCD, string name, string vkurCD, string vkurType, string std, double coordinateX, double coordinateY, string ddN, string ddE)
        {
            this.code = code;
            this.typeCD = typeCD;
            this.name = name;
            this.vkurCD = vkurCD;
            this.vkurType = vkurType;
            this.std = std;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.ddN = ddN;
            this.ddE = ddE;
        }
    }
}