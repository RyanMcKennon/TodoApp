using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoDataAccess
{
    public class EfDataAccess
    {
        private TodoEntities db = new TodoEntities();

        public bool AddItem(string itemName, bool completed)
        {
            List data = new List() {ItemName = itemName, Completed = completed };
            db.Lists.Add(data);
            return db.SaveChanges() > 0;
        }

        public bool DeleteItem(int id)
        {
            var item = db.Lists.Where(x => x.ItemID == id).FirstOrDefault();
            db.Lists.Remove(item);
            return db.SaveChanges() > 0;
        }

        public bool updateList(List list)
        {
            int test = 0;
            var result = db.Lists.SingleOrDefault(b => b.ItemID == list.ItemID);
            if (result != null)
            {
                result.ItemName = list.ItemName;
                result.Completed = list.Completed;
                test = db.SaveChanges();
            }
            return test > 0;
        }


        public bool MarkItemComplete (int id)
        {
            List data = new List() { ItemID = id, Completed = true};
            return updateList(data);
        }

        public List<List> GetList()
        {
            return db.Lists.ToList();
        }

        public List<List> GetCompletedItems()
        {
            return db.Lists.Where(x => x.Completed == true).ToList();
        }

        public List<List> GetUncompletedItems()
        {
            return db.Lists.Where(x => x.Completed == false).ToList();
        }
    }
}
