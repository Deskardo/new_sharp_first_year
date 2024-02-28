using lesson3;
using System.Runtime.InteropServices.JavaScript;

public abstract class Person : IComparable, IParent, IFamily
{
    public readonly string Name = String.Empty;
    public readonly DateTime Birthday;
    public Person Father = null;
    public Person Mother = null;
    public Person[] Children = null;
    protected abstract string HelloPhrase { get; }
    public Person[] Family;

    public Person this[int index]
    {
        get
        {
            if (index <= 0) return this;
            if (Family is null)
            {
                return null;
            }

            if (Family.Length >= index)
            {
                return Family[index - 1];
            }

            return null;
        }
    }

    public int Count => 1 + (Family?.Length ?? 0);

    public Person(string name, DateTime birthday)
    {
        this.Name = name;
        if (birthday <= DateTime.Now)
            this.Birthday = birthday;
        else
        {
            Console.WriteLine($"Дата {birthday}, не верна! Присваиваем сегодняшнюю");
            this.Birthday = birthday;
        }
    }

    public Person(string name)
    {
        this.Name = name;
        this.Birthday = DateTime.Now;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, BD={Birthday}");
    }

    public bool IsAdult(int adultAge = 18)
    {
        var delta = DateTime.Now.Year - Birthday.Year;
        return delta > adultAge || (delta == adultAge && DateTime.Now.DayOfYear <= Birthday.DayOfYear);
    }

    public void AddFamilyInfo(Person father, Person mother, params Person[] children)
    {
        Father = father;
        Mother = mother;
        Children = children;
        int familyCount = 0;
        familyCount += Father == null ? 0 : 1;
        familyCount += Mother == null ? 0 : 1;
        familyCount += Children.Length;
        if (familyCount > 0)
            Family = new Person[familyCount];
        else
            return;
        int counter = 0;
        if (Father != null)
        {
            Family[counter] = Father;
            counter++;
        }

        if (Mother != null)
        {
            Family[counter] = Mother;
            counter++;
        }

        if (Children != null)
        {
            foreach (var child in children)
            {
                Family[counter] = child;
                counter++;
            }
        }
    }

    public void PrintFamilyInfo()
    {
        if (Father != null)
        {
            Console.WriteLine("Father: ");
            Father.Print();
        }

        if (Mother != null)
        {
            Console.WriteLine("Mother: ");
            Mother.Print();
        }

        if (Children != null && Children.Length > 0)
        {
            Console.WriteLine("Children: ");
            foreach (var child in Children)
            {
                child.Print();
            }
        }
    }

    public bool GetChildren(out Person[] children)
    {
        if (Children != null && Children.Length > 0)
        {
            children = Children;
            return true;
        }
        else
        {
            children = null;
            return true;
        }
    }

    public struct SomeData
    {
        public int data;
    }

    public static void CopyAndModifyData(SomeData someData)
    {
        someData.data = 10;
    }

    public static void ModifyData(ref SomeData someData)
    {
        someData.data = 10;
    }

    public virtual void SayHello()
    {
        Console.WriteLine($"Привет, я - человек. Меня звать - {this.Name}");
    }

    public void SayHelloPhrase()
    {
        Console.WriteLine(this.HelloPhrase);
    }

    public int CompareTo(object? obj)
    {
        if (obj == null) return -1;
        return this.Birthday.CompareTo((obj as Person).Birthday);
    }

    protected abstract void TakeCareImplementation();

    public void TakeCare()
    {
        if (Children != null)
        {
            TakeCareImplementation();
        }
    }
}

/*Person person = new Person();
person.Name = "Ivan";
person.Birthday = DateTime.Parse("07.04.1987");
person.Height = 176;

Person person2 = new();
var person3 = new Person();
var person4 = new Person() { Name = "Fedor", Height = 200, Birthday = DateTime.Now };
Person person5 = new() { Name = "Fedor", Height = 200, Birthday = DateTime.Now };
//Console.WriteLine($"{person.Name}, {person.Birthday}, {person.Height}");*/
/*
 var person = new Person("Alex", DateTime.Now.AddDays(1), 178);
   var person2 = new Person("Alex", DateTime.Now.AddDays(-1), 178);*/
/*//var person = new Person("Alex", DateTime.Now.AddDays(1), 178);
var person = new Person("Alex", DateTime.Parse("07.04.1987"), 178);
var son = new Person("Kosta", DateTime.Parse("27.01.2008"), 165);
var daughter = new Person("Ira", DateTime.Parse("01.08.2012"), 152);
var father = new Person("Viktor", DateTime.Parse("01.10.1965"), 158);
var mother = new Person("Marina", DateTime.Parse("14.09.1966"), 162);

person.AddFamilyInfo(father, mother, daughter, son);
person.PrintFamilyInfo();*/
/*            //var person = new Person("Alex", DateTime.Now.AddDays(1), 178);
   var person = new Person("Alex", DateTime.Parse("07.04.1987"), 178);
   var son = new Person("Kosta", DateTime.Parse("27.01.2008"), 165);
   var daughter = new Person("Ira", DateTime.Parse("01.08.2012"), 152);
   var father = new Person("Viktor", DateTime.Parse("01.10.1965"), 158);
   var mother = new Person("Marina", DateTime.Parse("14.09.1966"), 162);

   person.AddFamilyInfo(father, mother, daughter, son);
   person.PrintFamilyInfo();

   var res = person.GetChildren(out Person[] children);

   if (res == true)
   {
       Console.WriteLine("Have children");
   }
*/
/*            SomeData a = new SomeData();
   SomeData b = new SomeData();
   a.data = 5;
   b.data = 5;

   Person.CopyAndModifyData(a);
   Person.ModifyData(ref b);

   Console.WriteLine(a.data);
   Console.WriteLine(b.data);
*/
/*var woman = new Woman("Anna", DateTime.Parse("08.06.1983"));
var man = new Man("Alex", DateTime.Parse("07.04.1987"));

*/ /*            woman.Print();
            woman.PutMakeup();
            woman.RemoveMakeup();

            man.Print();
            man.Shave();*/ /*

Person[] people = new Person[] { woman, man };

foreach (var p in people)
{
    p.Print();
}*/
/*
 *            Array.Sort(people);

   foreach (var p in people)
   p.Print();
 */
/*
 *             man.AddFamilyInfo(null, null, kid);
            woman.AddFamilyInfo(null, null, kid);

/*            man.TakeCare();
            woman.TakeCare();*/

// TakeCare(man, woman);
/*
IBabySitter babySitter = woman;
IParent mom = woman;
IParent dad = man;
IBabySitter babySitter1 = new BabySitter();

// babySitter.TakeCare();
// mom.TakeCare();
TakeCare(babySitter, babySitter1);
*/

/*
var grandma = new Woman("Anna", DateTime.Parse("01.01.1980"));
var grandpa = new Man("Ivan", DateTime.Parse("01.01.1981"));

var parent = new Woman("Inga", DateTime.Parse("01.01.1999"));
var kid2 = new Man("Igor", DateTime.Parse("01.01.2021"));

parent.AddFamilyInfo(grandpa, grandma, kid2);

for (int i = 0; i < parent.Count; i++)
{
    parent[i].Print();
}
*/

/*        static void TakeCare(params IParent[] parents)
        {
            foreach (var p in parents)
                p.TakeCare();
        }*/

/*
 *         static void TakeCare(params IBabySitter[] sitters)
   {
       foreach (var s in sitters)
       {
           s.TakeCare();
       }
   }
*/

/*var person1 = new Man("Roma");
var person2 = new Man("Alex");
var person3 = new Man("Igor");

var groupOf3 = new { Name1 = person1.Name, Name2 = person2.Name, Name3 = person3.Name };

Console.WriteLine(groupOf3);*/