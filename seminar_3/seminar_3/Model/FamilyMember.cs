using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_3.Model
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Gender Gender { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember Mother { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateOfDeath { get; set; }
        public FamilyMember Spouse { get; set; }

        public override string ToString()
        {
            return $"  Name {Name},\n  Surname {SurName},\n  Birthday in {Birthday}\n";

        }
    }
}
