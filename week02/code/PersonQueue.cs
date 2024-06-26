/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue {
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person) {
        // _queue.Insert(0, person); //breaks the FIFO data structure, tries to add to the start of the list instead of end of the list
        _queue.Add(person); // Adds to the end or back
    }

    public Person Dequeue() {
        if (_queue.Count == 0) throw new InvalidOperationException("The queue is empty."); // addedan exception in case queuee is empty to end gracefully
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty() {
        return Length == 0;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}