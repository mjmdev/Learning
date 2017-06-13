// Binary tree (unbalanced)
// Method to find deepest node in Binary Tree (node in lowest level)

public class Node<T> 
{
    public Node(T data)
    {
        this.Data = data;
    }

    public T Data { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public int Depth { get; set; }
}

// Find deepest node in Binary Tree using Depth-First Search
public Node<T> FindDeepestNode<T>(Node<T> root)
{
    if (root == null)
    {
        Node<T> node = new Node<T>()
        {
            Data = null,
            Depth = 0
        };

        return node;
    }

    Node<T> left = FindDeepestNode(root.Left);
    Node<T> right = FindDeepestNode(root.Right);

    Node<T> deepestNode = left.Depth < right.Depth ? right : left;
    deepestNode.Depth += 1;

    // Case when base case returns
    if (deepestNode.Data == null)
    {
        deepestNode = root;
        deepestNode.Depth = 1;
    }

    return deepestNode;
}

// Find deepest node in Binary Tree using Breadth-First Search
public Node<T> FindDeepestNodeQ<T>(Node<T> root)
{
    if (root == null)
    {
        return null;
    }

    Queue<Node<T>> q = new Queue<Node<T>>();
    q.Enqueue(root);

    Node<T> current = null;

    while (q.Any())
    {
        int size = q.Count;
        for (int i = 0; i < size; i++)
        {
            current = q.Dequeue();
            if (current.Left != null)
            {
                q.Enqueue(current.Left);
            }
            if (current.Right != null)
            {
                q.Enqueue(current.Right);
            }
        }
    }

    return current;
}