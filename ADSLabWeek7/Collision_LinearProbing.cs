using System.Data;
using System.Net.Mail;

public class Collision_LinearProbing
{
    public static int hashFunction (int key, int table_size) {
		int index = -1;
		// Console.WriteLine(key+" x "+table_size);
		index = key % table_size;	
		return index;
	}
	
	public static void insert (int key, string [] data, string [,] myTable) {
		//get the index to store the name using hash function
		int index = hashFunction(key, myTable.GetLength(0));
		int i = 1;
		while (collision(index, myTable)==true) {
			index = probLinear (key, i, myTable);
			i++;
		}

		for (int j=0; j<data.Length; j++)
		{
			myTable [index,j] = data[j]; 
		}	
	}
	
	public static int probLinear (int key, int i, string [,] myTable) {
		int index = (key+i) % myTable.GetLength(0);
		return index;
	}
	
	public static Boolean collision (int index, string [,] myTable) {
		Boolean col = false;
		// Console.WriteLine(index);
		if (myTable[index,0]!=null) {
			col = true;
		}
		return col;
	}
	
	public static void printData (string [,] myTable) {
		for (int i = 0; i<myTable.GetLength(0); i++) {
			for (int j=0; j<myTable.GetLength(1); j++)
			{
				Console.WriteLine(myTable[i,j]);
				Console.WriteLine();
			}
		}
	}
}