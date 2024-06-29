public class FeatureCollection
{
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    // will contains list of earthquake features
    public List<Feature> Features { get; set; }

    public class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        public string Id { get; set; }
        public string Place { get; set; }
        public double Mag { get; set; }
        public long Time { get; set; }
    }
}