using Microsoft.VisualBasic.FileIO;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    Dictionary<string, int> degrees = new Dictionary<string, int>();

    public void ReadFile()
    {
        using var reader = new TextFieldParser("census.txt");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        while(!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var degree = fields[3];
            if(degrees.ContainsKey(degree))
                degrees[degree] += 1;
            else
                degrees[degree] = 1;
        }
    }

}