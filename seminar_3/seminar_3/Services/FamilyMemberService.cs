using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seminar_3.Model;

namespace seminar_3.Services
{
    internal class FamilyMemberService
    {
        public List<FamilyMember> Family { get; private set; }

        public FamilyMemberService()
        {
            Family = new List<FamilyMember>();
        }

        public void AddPerson(params FamilyMember[] member)
        {
            if (member != null && member.Length > 0)
            {
                Family.AddRange(member);
            }
        }

        public List<FamilyMember> grandFathers = new List<FamilyMember>();

        public List<FamilyMember> GetGrandFathers(FamilyMember member)
        {
            if (member.Mother != null && member.Mother.Father != null)
            {
                grandFathers.Add(member.Mother.Father);
            }

            if (member.Father != null && member.Father.Father != null)
            {
                grandFathers.Add(member.Father.Father);
            }

            return grandFathers;
        }

        List<FamilyMember> grandMothers = new List<FamilyMember>();

        public List<FamilyMember> GetGrandMothers(FamilyMember member)
        {
            if (member.Mother != null && member.Mother.Mother != null)
            {
                grandMothers.Add(member.Mother.Father);
            }

            if (member.Father != null && member.Father.Mother != null)
            {
                grandMothers.Add(member.Father.Father);
            }

            return grandMothers;
        }

        public FamilyMember OldMember(List<FamilyMember> member)
        {
            var maxAgeMember = member[0];
            foreach (var person in member)
            {
                if (DateTime.Now - person.Birthday > DateTime.Now - maxAgeMember.Birthday)
                {
                    maxAgeMember = person;
                }
            }

            return maxAgeMember;
        }

        public List<FamilyMember> GetChild(FamilyMember member)
        {
            List<FamilyMember> child = new List<FamilyMember>();
            foreach (var person in Family)
            {
                if (person.Father == member || person.Mother == member)
                {
                    child.Add(person);
                }
            }

            return child;
        }

        public FamilyMember GetSpouse(FamilyMember member)
        {
            if (member.Spouse != null)
            {
                Console.WriteLine($"Супругом {member.Name}, \nявляется: \n{member.Spouse.ToString()} ");
                return member.Spouse;
            }
            else
            {
                Console.WriteLine($"{member.Name}, еще не является супругом");
                return null;
            }
        }

        public void GetSpouseParent(FamilyMember member)
        {
            var spouse = GetSpouse(member);
            if (spouse != null)
            {
                Console.WriteLine($"Родителями {spouse.Name}\n" + $"являются: \n" + $"Отец: \n{spouse.Father}\n" +
                                  $"Мать: \n{spouse.Mother}");
            }
        }
    }
}