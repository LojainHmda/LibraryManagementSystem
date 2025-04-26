using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public  AbstractPerson    (int Id, string Name)
        {
         this.Id = Id;this.Name = Name;
        }
        public abstract void DisplayInfo();
    }


}
