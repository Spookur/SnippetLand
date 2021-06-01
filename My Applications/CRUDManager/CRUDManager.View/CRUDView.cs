using CRUDManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDManager.View
{
    public class CRUDView
    {
        private inputOutput io = new inputOutput();

        public CRUD Create()
        {
            CRUD crud = new CRUD();
            

            crud.Id = io.GetInteger();
            crud.Title = io.GetTitle();
            crud.Description = io.GetDescription();
            Console.Clear();
            Console.WriteLine("Good work, human. Your creation will be stored.");
            Console.ReadKey();

            return crud;
        }

        public void DisplayCRUD(CRUD crud)
        {
            crud.Print();
            
            
        }
    }
}
