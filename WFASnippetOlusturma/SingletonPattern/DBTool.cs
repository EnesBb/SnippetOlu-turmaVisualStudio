using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFASnippetOlusturma.SingletonPattern
{
    using Models;
    public class DBTool
    {










       
        private static NorthwindEntities _dbInstance;

         public static NorthwindEntities DBInstance()
        {
            if (_dbInstance==null)
            {
                _dbInstance = new NorthwindEntities();
            }
            return _dbInstance;
        }












    }
}
