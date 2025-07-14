using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add 3 new person Bob 5, Tim 3, Sue 1 and dequeuing
    // Expected Result: dequeue should result in Bob being dequeued as he has the highest priority
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("bob", 5);
        priorityQueue.Enqueue("tim", 1);
        priorityQueue.Enqueue("sue", 3);
        var person = priorityQueue.Dequeue();
        Assert.AreEqual(person, "bob");
    }

    [TestMethod]
    // Scenario: dequeuing an empty queue
    // Expected Result: should return an error
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        } 
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }


    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: queuing 3 new person with two person with the same priority index
    // Expected Result: dequeue should result in tim being dequeued as he has the highest priority with the lowest index
    // Defect(s) Found: the dequeued high priority wasn't being removed so added a code to remove it from the queue, the logic on the loop didn't check the last item from the queue so deleted the -1
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("bob", 2);
        priorityQueue.Enqueue("tim", 3);
        priorityQueue.Enqueue("sue", 3);
        string[] expectedResult = {"tim", "sue", "bob"};
        for (int i = 0; i < 3; i++) {
            var person = priorityQueue.Dequeue();
            Debug.WriteLine(person);
            Assert.AreEqual(expectedResult[i], person);
        }
    }
}