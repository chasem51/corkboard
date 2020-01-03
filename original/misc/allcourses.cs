using System;

// Structure of a Node 
public class Node
{
	public string data;
	public Node next;
	public Node prev;
}

public class LinkedList : Node, System.IDisposable
{
	public int length;
	public Node head;
	public Node end;
	public LinkedList()
	{
		this.length = 0;
		this.head = null;
	}

	public void Dispose()
	{
		Console.Write("LIST DELETED.");
		Console.Write("\n");
	}


	// insert temp at the end of the linked list
	public void insertEnd(string value)
	{
		// If the list is empty, create a single node
		if (this.head == null)
		{
			Node temp = new Node();
			temp.data = value;
			temp.next = temp.prev = this.head;
			this.head = temp;
			this.length++;
			return;
		}

		// If list is not empty
		Node last = this.end;

		// Create Node
		Node temp = new Node();
		temp.data = value;

		// temp -> next points to head
		temp.next = this.head;

		// head points to temp for doubly linked insertion
		this.head = temp;

		this.length++;
	}

	public void display(Node head)
	{
		// forward iterative print
		Console.Write("Traversal in forward direction:");
		Console.Write("\n");
		while (head != end)
		{
			Console.Write(head.data);
			Console.Write("\n");
			head = head.next;
		}
	}
}