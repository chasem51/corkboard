using System;

public static class GlobalMembers
{


// finds results matching an input value from start, store in second 'skipped' list start2

	public static bool search(string value, LinkedList list1, LinkedList list2)
	{
		Console.Write("Searching for: ");
		Console.Write(value);
		Console.Write("\n");

		while (list1.head != null)
		{
			if (list1.head.data.IndexOf(value) != -1) // if temp -> data is equal to the value
			{
				list2.insertEnd(value);

				if (list1.head == list1.end)
				{
					list2.display(list2.head);
					Console.Write("Number of courses matching the search: ");
					Console.Write(list2.length);
					Console.Write("\n");
					return false;
				}
			}
			else if (list1.head == list1.end && list1.head.data.IndexOf(value) == -1) // if temp -> next is equal to start and temp -> data isn't equal to the value, search concluded
			{
				list1.end = null;
				Console.Write("Search returned no results.");
				Console.Write("\n");
				return false;
			}
			list1.head = list1.head.next; // iterate until value search is resolved
		}
	}





	static int Main()
	{
		/* Initialize empty list */
		LinkedList list = new LinkedList();

		/* Initialize empty list */
		LinkedList list2 = new LinkedList();

		list.insertEnd("CAS, PY212, SI II, Quantitiative Reasoning Two, CT, T/C");

		list.insertEnd("CAS, PY211, SI I, Quantitiative Reasoning One, CT, T/C");

		Console.Write("Circular doubly linked list & its elements constructed.");
		Console.Write("\n");

		list.display(list.head);

		Console.Write("Number of courses: ");
		Console.Write(list.length);
		Console.Write("\n");

		search("Quantitiative Reasoning", list, list2);

		if (list != null)
		{
		list.Dispose();
		}
		if (list2 != null)
		{
		list2.Dispose();
		}

		return 0;
	}


}