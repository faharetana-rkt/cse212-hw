using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    // This set was moved outside the function insert because it was reset each time the function was called
    public HashSet<int> unique = new HashSet<int>();
    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (!unique.Contains(value))
        {
            unique.Add(value);
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
        else
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else
        {
            if (value < Data)
            {
                if (Left == null)
                {
                    return false;
                }
                return Left.Contains(value);
            }
            else
            {
                if (Right == null)
                {
                    return false;
                }
                return Right.Contains(value);
            }
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left == null && Right == null)
        {
            return 1;
        }

        int left;
        if (Left != null)
        {
            left = Left.GetHeight();
        }
        else
        {
            left = 0;
        }

        int right;
        if (Right != null)
        {
            right = Right.GetHeight();
        }
        else
        {
            right = 0;
        }

        return 1 + Math.Max(left, right); // Replace this line with the correct return statement(s)
    }
}