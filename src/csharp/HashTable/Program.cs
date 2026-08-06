using System.Collections;

// what is problem with ArrayList (to get the data i have to remember the index position)
ArrayList al = new ArrayList();

al.Add(1001);
al.Add("James");
al.Add("Manager");
al.Add(3500);
al.Add("Mumbai");
al.Add("IT");
al.Add("a@a.com");

for(int i = 0; i< al.Count; i++)
{
    Console.WriteLine($"al[{i}] = {al[i]}");
}

