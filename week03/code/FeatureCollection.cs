using System.Text.Json.Serialization;
using Microsoft.VisualBasic.FileIO;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    // public Metadata Data { get; set; }
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("mag")]
    public double Mag { get; set; }
    [JsonPropertyName("place")]
    public string Place { get; set; }
}

// public class Metadata
// {
//     public long Generated { get; set; }
//     public string Url { get; set; }
//     public string Title { get; set; }
//     public int Status { get; set; }
//     public string Api { get; set; }
//     public int Count { get; set; }
// }