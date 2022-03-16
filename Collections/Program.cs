using Collections.src.Models.List;

var list = new Lista<int>();

list.Add(1);
list.Add(5);
list.Add(3);
list.Add(9);
list.Add(0);


list.ShowAll();
Console.WriteLine("Size: " + list.Count());
Console.WriteLine("ByIndex: " + list.GetByIndex(1));
Console.WriteLine("Contains: " + list.Contains(4));
Console.WriteLine("Remove: " + list.Remove(0));
list.ShowAll();
