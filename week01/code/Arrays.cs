public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // First, I will initialize the List of double that will contain all the multiples
        List<double> result = new List<double>();
        // Here, I will use a for loop to loop through all the numbers starting from the number provided to search for the multiples of the given number
        // The condition I will use is the length of the result list less than the length provided
        // i will be incremented by the number provided
        for (double i = number; result.Count < length; i += number)
        {
            // This if statement is used to find the multiple, if the modulo operator doesn't have a remainder, we add the number to our list
            if (i % number == 0)
            {
                result.Add(i);
            }
        }
        // Convert the list to an array befor returning the result
        return result.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // A new list is initialized that will contain the rotated List to the right
        List<int> rotatedRight = new List<int>();
        // We calculate the index that we will use as the starting index for the first GetRange method that will return the right side of the list
        int index1 = data.Count - amount;
        // Here is the range or the number of item that we want to retrieve from the first GetRange method
        int range1 = amount;
        // We add the sublist which is the right side of the list to our rotatedList using the AddRange method
        rotatedRight.AddRange(data.GetRange(index1, range1));
        // The second index is 0 because we want to take the left side of the first list
        int index2 = 0;
        // The range for our second GetRange method is the index from the first GetRange because we need the remaining number left
        int range2 = data.Count - amount;
        // Here we add the leftside to the rotatedRight list
        rotatedRight.AddRange(data.GetRange(index2, range2));
        // Now we need to clear our first list for it to receive the new rotatedList, then we use AddRange to add the items of the rotatedList to our List
        data.Clear();
        data.AddRange(rotatedRight);
    }
}
