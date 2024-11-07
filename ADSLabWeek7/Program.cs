// See https://aka.ms/new-console-template for more information

//PART 1

// string [,] data =  ReadFile.readCSV();
// Console.WriteLine("Col : "+data.GetLength(1));
// ReadFile.printArray(data);


// Tutorial 7: Linear Probing
// Console.WriteLine("::Linear Hashing::");
// string [] myTable = new String [5];

// Collision_LinearProbing.insert(5, "Mazwan", myTable);
// Collision_LinearProbing.insert(12, "Jilani", myTable);
// Collision_LinearProbing.insert(9, "Zairul", myTable);
// Collision_LinearProbing.insert(15, "Rania", myTable);
// Collision_LinearProbing.insert(11, "Mehmet", myTable);
	
// Collision_LinearProbing.printData(myTable);	

//Solution Tutorial 7: Linear Probing

string [,] dataset = ReadFile.readCSV();
// ReadFile.printArray(dataset);

string [,] linearHS = new string[242,5];
for (int i=0; i<dataset.GetLength(0); i++)
{
  //  Console.WriteLine(dataset[i,3]);
   int key = Int32.Parse(dataset[i,3]); //this is the key for the index i.e num_code
   string [] row = new string [dataset.GetLength(1)];

   row[0] = dataset[i,0];
   row[1] = dataset[i,1];
   row[2] = dataset[i,2];
   row[3] = dataset[i,3];
   row[4] = dataset[i,4];

  Collision_LinearProbing.insert(key, row, linearHS);
}

ReadFile.printArray(linearHS);
Console.WriteLine("Solution for the storing countries using Linear Probing");
Console.WriteLine("1.	Which country is stored in the first position of the array?");
Console.WriteLine(linearHS[0,0]);

Console.WriteLine("2.	Which country is stored in the last position of the array?");
Console.WriteLine(linearHS[linearHS.GetLength(0)-1,0]);

Console.WriteLine("3.	Which country is stored in the 53rd position of the array?");
Console.WriteLine(linearHS[52,0]);

Console.WriteLine("4.	What is United Kingdom position in the array?");
string uk = "United Kingdom";
for (int i=0; i<linearHS.GetLength(0); i++)
{
  if (linearHS[i,0] == uk)
    Console.WriteLine("Index : "+i);
}


//Double Hashing
// Console.WriteLine("::Double Hashing::");
// string [] myTable2 = new String [5];
// Collision_DoubleHashing.insert(9, "Zairul", myTable2); //9%5 = 4
// Collision_DoubleHashing.insert(5, "Mazwan", myTable2); //5%5 = 0
// Collision_DoubleHashing.insert(12, "Jilani", myTable2); //12%5 = 2
// Collision_DoubleHashing.insert(15, "Rania", myTable2);//iter 0 : 15%5 = 0, iter 1 :  (1*3)%5 = 3
// Collision_DoubleHashing.insert(23, "Mehmet", myTable2); //iter 0 : 23%5 = 3, iter 1: (4*1)%5 = 4, iter 2 : (5*1)%5 = 0, iter 3 : (6*1)%5 = 1, iter 4: (7*1)%5 = 2
		
// Collision_DoubleHashing.printData(myTable2);	


//Solution for the storing countries using double hashing
Console.WriteLine("Solution for the storing countries using double hashing");
string [,] doubleHS = new string[242,5];

for (int i=0; i<dataset.GetLength(0); i++)
{
    int key = Int32.Parse(dataset[i,3]); //this is the key for the index i.e num_code
    string [] row = new string [dataset.GetLength(1)]; //since our data is an array, we create a 1D array to extract from dataset and insert into hashtable

    row[0] = dataset[i,0];
    row[1] = dataset[i,1];
    row[2] = dataset[i,2];
    row[3] = dataset[i,3];
    row[4] = dataset[i,4];

  Collision_DoubleHashing.insert(key, row, doubleHS);
}


Console.WriteLine("1.	Which country is stored in the first position of the array?");
Console.WriteLine(doubleHS[0,0]);

Console.WriteLine("2.	Which country is stored in the last position of the array?");
Console.WriteLine(doubleHS[doubleHS.GetLength(0)-1,0]);

Console.WriteLine("3.	Which country is stored in the 53rd position of the array?");
Console.WriteLine(doubleHS[52,0]);

Console.WriteLine("4.	What is United Kingdom position in the array?");
for (int i=0; i<doubleHS.GetLength(0); i++)
{
  if (doubleHS[i,0] == uk)
    Console.WriteLine("Index : "+i);
}



//------------------------------------------------------------------------
//PART 2

// DoublyLinkedList [] myTable = new DoublyLinkedList [5];
// Collision.insert(9, "Zairul", myTable); 
// Collision.insert(5, "Mazwan", myTable);  
// Collision.insert(15, "Rania", myTable);
// Collision.insert(16, "John", myTable);
// Collision.insert(21, "Mariam", myTable);
		
// Collision.printData (myTable);
// Console.WriteLine("\nFind a user with id 21 "+Collision.findNode(21, myTable));


//Solution Tutorial 7: Doubly Linked List 
DoublyLinkedList [] myTable = new DoublyLinkedList [100];
for (int i=0; i<dataset.GetLength(0); i++)
{
    int key = Int32.Parse(dataset[i,3]); //this is the key for the index i.e num_code
    string [] row = new string [dataset.GetLength(1)];

    row[0] = dataset[i,0];
    row[1] = dataset[i,1];
    row[2] = dataset[i,2];
    row[3] = dataset[i,3];
    row[4] = dataset[i,4];

    Collision.insert(key, row, myTable);
}

Collision.printData(myTable);
Collision.emptyIndex(myTable);
Console.WriteLine(myTable[0].head.data[0]);
Console.WriteLine(myTable[0].length);
Collision.getLongestLinkedListIndex(myTable);
Console.WriteLine("\nGet the information for key 688 ");
Collision.Question3(688,myTable);
