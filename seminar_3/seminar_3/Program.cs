using seminar_3.Model;
using System.Xml.Linq;
using seminar_3.Services;
using System;

namespace seminar_3
{
    internal class Program
    {
        static void Main()
        {
            var person5 = new FamilyMember()
            {
                Name = "Petr", 
                SurName = "Ivanov", 
                Birthday = DateTime.Parse("07.04.1960"), 
                Gender = Gender.Male
            };
            var person6 = new FamilyMember()
            {
                Name = "Varvara",
                SurName = "Ivanova",
                Birthday = DateTime.Parse("06.01.1962"),
                Gender = Gender.Female
            };
            person5.Spouse = person6;
            person6.Spouse = person5;

            var person7 = new FamilyMember()
            {
                Name = "Sergey", 
                SurName = "Titov", 
                Birthday = DateTime.Parse("07.04.1954"), 
                Gender = Gender.Male
            };
            var person8 = new FamilyMember()
            {
                Name = "Nadeghda",
                SurName = "Titova",
                Birthday = DateTime.Parse("06.01.1960"),
                Gender = Gender.Female
            };
            person7.Spouse = person8;
            person8.Spouse = person7;
            var person1 = new FamilyMember()
            {
                Name = "Ivan",
                SurName = "Ivanov",
                Birthday = DateTime.Parse("07.04.1987"),
                Gender = Gender.Male,
                Father = person5,
                Mother = person6
            };
            var person2 = new FamilyMember()
            {
                Name = "Maria",
                SurName = "Ivanova",
                Birthday = DateTime.Parse("06.01.1989"),
                Gender = Gender.Female,
                Father = person7,
                Mother = person8
            };
            person1.Spouse = person2;
            person2.Spouse = person1;
            var person3 = new FamilyMember()
            {
                Name = "Alex",
                SurName = "Ivanov",
                Birthday = DateTime.Parse("07.01.2010"),
                Mother = person2,
                Father = person1,
                Gender = Gender.Male
            };
            var person4 = new FamilyMember()
            {
                Name = "Vera",
                SurName = "Ivanova",
                Birthday = DateTime.Parse("06.07.2020"),
                Mother = person2,
                Father = person1,
                Gender = Gender.Male,

            };

            var service = new FamilyMemberService();
            service.AddPerson(person1, person2, person3, person4, person5, person6, person7, person8);

            

            foreach (var person in service.Family)
            {
                service.GetGrandFathers(person);
                service.GetGrandMothers(person);
            }

            var oldman = service.OldMember(service.Family);


/*            Console.WriteLine(service.OldMember(service.Family));

            foreach (var child in service.GetChild(oldman))
            {
                Console.WriteLine($"Потомок {child.ToString()}");
            }*/

            // service.GetSpouse(person1);
            service.GetSpouseParent(person2);
        }
    }
}