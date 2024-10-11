public class Collision
{
    public static void insert (int key, String  [] data, DoublyLinkedList [] myTable) {
		
		int index = hashFunction (key, myTable);
		DoublyLinkedList dll = new DoublyLinkedList();
		//DoublyLinkedList.Node n = new DoublyLinkedList.Node(key, name);
		Node n = new Node(key, data);
		
		if (!collision(index, myTable)) {
			dll.setHead(n);
			myTable [index] = dll;
		}
		else {
			dll = myTable[index];
			dll.insert(n);
		}
	}
	
	public static int hashFunction (int key, DoublyLinkedList [] myTable) {
		int index = key%myTable.Length;
		return index;
	}
	
	public static Boolean collision (int index, DoublyLinkedList [] myTable) {
		Boolean coll = false;
		if (myTable[index]!=null) {
			coll = true;
		}
		return coll;
	} 

	public static void printData (DoublyLinkedList [] myTable) {
		for (int i = 0; i<myTable.Length; i++) {
			Console.WriteLine("Index "+i+" : ");
			if (myTable[i]!=null)
			{
				Console.WriteLine("There are "+myTable[i].length+ " record/s");
				DoublyLinkedList.printNodes(myTable[i]);
			}
			else {
				Console.Write("No record here!");
			}
			
			Console.WriteLine("\n");
		}
	}

	public static void emptyIndex(DoublyLinkedList [] myTable)
	{
		int empty = 0;
		for (int i=0; i<myTable.Length; i++)
		{
			if (myTable[i] == null)
				empty++;
			
		}
		Console.WriteLine("There are "+empty+" empty slots in the hashtable");
	}

	public static void getLongestLinkedListIndex(DoublyLinkedList [] myTable)
	{
		int index = -1;
		int longestDLL = -1;
		for (int i=0; i<myTable.Length; i++)
		{
			if (myTable[i] != null)
			{
				//Console.WriteLine(myTable[i].length);
				if (myTable[i].length>longestDLL)
				{
					index = i;
					longestDLL = myTable[i].length;
					
				}
					
			}
			
		}
		Console.WriteLine("Index with the longest linked list : "+index);
		Console.WriteLine("There are "+myTable[index].length+" nodes in the index");
		DoublyLinkedList.printNodes(myTable[index]);
		

	}
	
	public static Boolean findNode(int key, DoublyLinkedList [] myTable) {
		
		int index = hashFunction(key, myTable);
		Boolean found = false;
		
		DoublyLinkedList n = myTable[index]; //the element in the table is of this class.
		
		if (n!=null) {

			Node head = n.head; //get the node
			if (head.key == key)
			{
				found = true;
			}
			else
			{
				while (head.key != key && head.next !=null) 
				{
					head = head.next;
					if(head.key == key) {
						found = true;
						break;
					}	
				}
			}
		}
		return found;
	}

	public static void Question3 (int key, DoublyLinkedList [] myTable)
	{
		String [] res = null;
		int index = hashFunction(key, myTable);
		bool found = findNode(key, myTable);
		if (found) 
		{
			DoublyLinkedList n = myTable[index];
			Node head = n.head;

			if (head.key == key)
			{
				res = head.data;
			}
			else
			{	
				while(head.key != key && head.next!=null)
				{
					head = head.next;
					if(head.key == key) {
						res = head.data;
						break;
					}	
				}	
			}
		}
		else
		{
			Console.WriteLine("Sorry, no record for the key");
		}

		if (res != null)
		{
			for (int i = 0; i < res.Length; i++)
			{
				Console.WriteLine(res[i]);
			}
		}	
	}
}