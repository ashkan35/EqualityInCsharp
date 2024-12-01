var a = new Person();
a.Name = "Arash";
var b = new Person();
b.Name= "Arash";
Console.WriteLine(a==b);

Console.WriteLine(a.Equals(b));
object c =.5;
object d =.5;
Console.WriteLine(c==d);
Console.WriteLine(c.Equals(d));

object x = 10;
object z = 10;
Console.WriteLine(x==z);
Console.WriteLine(x.Equals(z));


public class Person
{
    public string Name { get; set; }
}