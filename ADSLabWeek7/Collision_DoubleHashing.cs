public class Collision_DoubleHashing
{
    public static void insert (int key, string [] data, string [,] myTable) {
		
		int i = 0;
		int index = hashFunction(key, i, myTable); 
		
		while (collision(index, myTable)==true) {
			i++;//increment the i for the next interation if there is collision
			index = hashFunction(key, i, myTable); //get the first hash with i incremented
			index += doubleHash (key); //get the second hash and product with the first hash
			index %= myTable.GetLength(0); 
			//Console.WriteLine("i: "+i);
			
		}
		for (int j=0; j<data.Length; j++)
		{
			myTable[index,j] = data[j];
		}
		
	}
	
	public static int hashFunction (int key, int i, string [,] myTable) {
		int index = (key%myTable.GetLength(0))+i;
		return index;
	}
	
	public static int doubleHash (int key) {
		 int index = 7 - (key%7);
		 return index;
	}
	
	public static Boolean collision (int index, string [,] myTable) {
		Boolean col = false;
		//Console.WriteLine(index);
		if (myTable[index,0]!=null) {
			col = true;
		}
		return col;
	}
	
	public static void printData (string [,] myTable) {
		for (int i = 0; i<myTable.GetLength(0); i++) {
			for (int j=0; j<myTable.GetLength(1); j++)
			{
				Console.Write(myTable[i,j]+" ");
				
			}
			Console.WriteLine();
		}
	}

}