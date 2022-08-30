using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer.Operations
{
    public class VideoDal
    {
        public List<Video> GetVideos()
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                return context.Videos.ToList();
            }
        }

        public void Update(Video video)
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                var entity = context.Entry(video);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Video GetById()
        {
            using (TravelDBContext context = new TravelDBContext())
            {
                return context.Videos.Where(p => p.Id == 1).FirstOrDefault();
            }
        }
    }

}
