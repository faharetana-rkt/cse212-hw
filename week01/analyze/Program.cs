Console.WriteLine("\n======================\nSorting\n======================");
Sorting.Run();

Console.WriteLine("\n======================\nStandardDeviation\n======================");
StandardDeviation.Run();

Console.WriteLine("\n======================\nSearch\n======================");
Search.Run();

  // var middle = (sortedNumbers.Length / 2);

        // if (sortedNumbers.Length == 0)
        // {
        //     return;
        // }
        // if (sortedNumbers.Length == 1)
        // {
        //     bst.Insert(sortedNumbers[0]);
        //     return;
        // }
        // if (bst.GetHeight() == 0)
        // {
        //     bst.Insert(sortedNumbers[middle]);
        //     var newsorted = sortedNumbers.Where((_, i) => i != middle).ToArray();
        //     InsertMiddle(newsorted, first, last, bst);
        // }
        // if (bst.GetHeight() > 0 && sortedNumbers[middle] > sortedNumbers[first])
        // {
        //     bst.Insert(sortedNumbers[first]);
        //     var newsorted = sortedNumbers.Where((_, i) => i != first).ToArray();
        //     InsertMiddle(newsorted, first, last, bst);
        // }
        // if (bst.GetHeight() > 0 && sortedNumbers[middle] < sortedNumbers[last])
        // {
        //     bst.Insert(sortedNumbers[last - 1]);
        //     var newsorted = sortedNumbers.Where((_, i) => i != last - 1).ToArray();
        //     InsertMiddle(newsorted, first, last, bst);
        // }