public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: This would enqueue three items with different priorities and then dequeue them.
        // Expected Result: after running d item would be dequeued in order of priority, HighPriority, MediumPriority, LowPriority..
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("LowPriority", 1);
        priorityQueue.Enqueue("MediumPriority", 2);
        priorityQueue.Enqueue("HighPriority", 3);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueues three items with d same priority and then dequeue them.
        // Expected Result: The items would be dequeued in FIFO order, First, Second, Third.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: this would add and then attempt to dequeue from an empty queue.
        // Expected Result: An error message, The queue is empty is displayed
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: nonee

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Enqueue items with varying priorities after running the highest priority item would be dequeued first, 
        // followed by the next highest.
        // Expected Result: The items should be dequeued in correct priority order. dat is B, C, A, D
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 4);
        priorityQueue.Enqueue("C", 3);
        priorityQueue.Enqueue("D", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 
        Console.WriteLine("---------");
    }
}
