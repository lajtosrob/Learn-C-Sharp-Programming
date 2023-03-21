using System;

namespace chapter_04
{
   class Project
   {
      v8.Employee owner;

      public string Name { get; private set; }

      public Project(string name, v8.Employee owner)
      {
            int szam = 12;
         Name = name;
         this.owner = owner;
      }

      public ref v8.Employee GetOwner()
      {
         return ref owner;
      }

      public override string ToString() => $"{Name} (Owner={owner.FirstName} {owner.LastName})";
   }
}
