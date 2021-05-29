using CRUDManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDManager.Data
{
    public class CRUDRepo
    {
        public List<CRUD> data;

        public CRUDRepo()
        {
            data = new List<CRUD>();
        }

        public CRUD Create(CRUD input)
        {
            data.Add(input);
            return input;
        }

        public List<CRUD> ReadAll()
        {
            return data;
        }
    }
}
