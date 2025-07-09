/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Testing the size of the queue by inputting a negative value
        // Expected Result:  we should expect the default length of 10 customer
        Console.WriteLine("Test 1");
        var cs = new CustomerService(-1);
        Console.WriteLine($"Max Size should be 10 here: {cs}");
        // Defect(s) Found: None

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Adding two customer and checking if two customer can be dequeued
        // Expected Result: we should expect customer 1 then customer 2 on the dequeue
        Console.WriteLine("Test 2");
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        Console.WriteLine(cs);
        cs.ServeCustomer();
        cs.ServeCustomer();
        // Defect(s) Found: the serve customer method sequence isn't correct, it removes the customer before it returns the customer
        // We just need to put customer var customer = _queue[0]; before _queue.RemoveAt(0);

        Console.WriteLine("=================");

        // Test 3
        // Scenario: Adding 4 customer to a 3 customer cs queue
        // Expected Result: we should expect an error to be thrown
        Console.WriteLine("Test 3");
        var cs1 = new CustomerService(3);
        cs1.AddNewCustomer();
        cs1.AddNewCustomer();
        cs1.AddNewCustomer();
        cs1.AddNewCustomer();
        Console.WriteLine(cs1);

        // Defects found: the queue doesn't respect the maxsize. So Added >= to maxsize instead of > maxsize

        // Test 4
        // Scenario: Dequeuing 4 customer in a 3 customer queue
        // Expected Result: we should expect an error to be thrown
        Console.WriteLine("Test 4");
        var cs2 = new CustomerService(3);
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        cs2.ServeCustomer();
        cs2.ServeCustomer();
        cs2.ServeCustomer();
        cs2.ServeCustomer();

        // Defects found: there's no error handling for when we try to dequeue more customer than there is on the queue
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count <= 0)
        {
            Console.WriteLine("All customer has been served, Good job!");
            return;
        }
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}