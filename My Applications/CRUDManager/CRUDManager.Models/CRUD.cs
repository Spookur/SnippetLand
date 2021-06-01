using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDManager.Models
{
    public class CRUD
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public CRUD()
        {

        }

        public void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine();

        }

        

    }
}
