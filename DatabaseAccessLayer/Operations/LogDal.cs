using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer.Operations
{
    public class LogDal
    {
        public void Log(Log log)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                ctx.Logs.Add(log);
                ctx.SaveChanges();
            }
        }
    }
}
