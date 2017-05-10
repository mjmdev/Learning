// Depth First Search

public Node<T> DepthFirstSearch<T>(Node<T> root, T data)
{
    if (root == null) { return; }

    root.State = State.Visited;
    
    foreach (var node in root.Adjacent)
    {
        if (node.State == State.NotVisited)
        {
            if (node.Data == data) { return node; }
            else 
            {
                DepthFirstSearch(node);
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