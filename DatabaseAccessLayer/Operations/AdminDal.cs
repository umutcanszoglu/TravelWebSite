using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public Picture GetPictureById(int id)
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                return context.Pictures.Where(p => p.Id == id).First();
            }
        }

        public void ImageAdd(Picture picture)
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                context.Pictures.Add(picture);
                context.SaveChanges();
            }
        }

        public void ImageDelete(Picture picture)
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                var entity = context.Entry(picture);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
