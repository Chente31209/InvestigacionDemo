using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Security
{
    public class BaseDB
    {
        protected SecurityDbContext db;
        public BaseDB(SecurityDbContext db)
        {
            this.db = db;
        }

    }
}
