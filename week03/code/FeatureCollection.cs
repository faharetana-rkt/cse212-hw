using Microsoft.VisualBasic.FileIO;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    Dictionary<string, int> degrees = new Dictionary<string, int>();

    public void ReadFile()
    {
        using var reader = new TextFieldParser("census.txt");
    }

}