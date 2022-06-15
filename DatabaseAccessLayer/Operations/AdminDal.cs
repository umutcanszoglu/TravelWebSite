using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer.Operations
{
    public class AdminDal
    {
        public Admin GetAdmin()
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                return context.Admins.FirstOrDefault();
            }
        }
    }
}
