// See https://aka.ms/new-console-template for more information
using System;

public class Node
{
	public int data;
	public Node left, right;

	public Node(int item)
	{
		data = item;
		left = right = null;
	}
}


public class BinaryTree
{
	public Node root;

	
	public virtual int size()
	{
		return size(root);
	}

	
	public virtual int size(Node node)
	{
		if (node == null)
		{
			return 0;
		}
		else
		{
			return (size(node.left) + 1 + size(node.right));
		}
	}

	public static void Main(string[] args)
	{
		/* creating a binary tree and entering the nodes */
		BinaryTree tree = new BinaryTree();
		tree.root = new Node(56);
		tree.root.left = new Node(30);
		tree.root.right = new Node(70);
		tree.root.left.left = new Node(22);
		tree.root.left.right = new Node(40);

		Console.WriteLine("The size of binary tree is : " + tree.size());
	}
}


