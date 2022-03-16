using Collections.src.Models.List;

var list = new Lista<int>();

list.Add(1);
list.Add(5);
list.Add(3);

list.ShowAll();
Console.WriteLine("Size: " + list.Count());
Console.WriteLine("ByIndex: " + list.GetByIndex(1));
Console.WriteLine("Contains: " + list.Contains(4));