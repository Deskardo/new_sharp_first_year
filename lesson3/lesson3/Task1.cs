using System.Runtime.InteropServices.JavaScript;

public class SomeClass
{
    private readonly int Number = 0;
    public SomeClass(int number)
    {
        this.Number = number;
    }

    public int pow2
    {
        get { return Number * Number; }
    }
    public int pow3
    {
        get { return Number * Number * Number; }
    }
    public int pow4
    {
        get { return Number * Number * Number * Number; }
    }
}

public class AdultAge
{
    private int age;

    public int Age
    {
        get { return age; }
        set{
            if (value < 18)
            {
                age = 18;
            }
            else
            {
                age = value;
            }
        }
    }

}

public class Today
{
    public string Day => DateTime.Now.DayOfWeek.ToString();
}

public class DataClass
{
    public required string Day;
}

/*
 var someClass = new SomeClass(10);

   Console.WriteLine($"{someClass.pow2}, {someClass.pow3}, {someClass.pow4}");
*/

/*
 * var ae = new AdultAge();
   ae.Age = 10;
   Console.WriteLine($"{ae.Age}");
 */
