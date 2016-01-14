using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dao
{
    class ContextFactory
    {
        private static DatabaseContext Context { get; set; }

        public DatabaseContext GetContext()
        {
            if (Context == null)
            {
                Context = new DatabaseContext();
            }
            return Context;
        }
    }
}
