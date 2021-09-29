using System.Collections.Generic;
using System.Linq;

namespace Abstraction.OldestFamilyMember
{
  class Family
  {
    public List<Person> Members;

    public Family()
    {
      Members = new List<Person>();
    }

    public void AddMember(Person member)
    {
      Members.Add(member);
    }

    public Person GetOldestFamilyMember()
    {
      var result = Members.FirstOrDefault(m => m.Age == Members.Max(t => t.Age));
      return result;
    }
  }
}
