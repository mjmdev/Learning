// Breadth First Search

public Node<T> BreadthFirstSearch<T>(Node<T> root, T data)
{
    Queue q = new Queue();
    root.Visited = State.Visited;
    q.Enqueue(root);

    while (q.Any())
    {
        Node<T> node = q.Dequeue();
        if (node.Data == data) { return node; }

        foreach (var n in node.Adjacent)
        {
            if (n.Visited == State.NotVisited)
            {
                n.Visited = State.Visited;
                q.Enqueue(n);
            }
        }
    }
    return null;
}

public class Node<T>
{
    public T Data { get; set; }
    public List<Node<T>> Adjacent { get; set; }
    public State state { get; set; }
}

public enum State
{
    NotVisited = 0,
    Visited = 1,
    Visiting = 2
}