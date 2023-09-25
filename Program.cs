// THREE BASIC ARRAYS
int[]    NumArray  = {0,1,2,3,4,5,6,7,8,9};
string[] StrArray  = {"Tim", "Martin", "Nikki", "Sara"};
bool[]   BoolArray = new bool[10];

for (int i = 0; i < BoolArray.Length; i++)
{
    BoolArray[i] = i % 2 == 0;
}

foreach (bool val in BoolArray)
{
    Console.WriteLine(val);
}


// Separator
Console.WriteLine("\n*************************\n");


// LIST OF FLAVORS
List<string> IceCreamList = new() {"Vanilla", "Chocolate", "Strawberry", "Coffee", "Pistachio"};
Console.WriteLine(IceCreamList.Count);
Console.WriteLine(IceCreamList[2]);
IceCreamList.RemoveAt(2);
Console.WriteLine(IceCreamList.Count);


// Separator
Console.WriteLine("\n*************************\n");


// USER DICTIONARY
Dictionary<string,string> Users = new();
Random num = new();
for (int i = 0; i < StrArray.Length; i++)
{
    Users.Add(StrArray[i], IceCreamList[num.Next(IceCreamList.Count)]);
}

foreach (KeyValuePair<string,string> user in Users)
{
    Console.WriteLine($"{user.Key} - {user.Value}");
}
