using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer.Operations
{
    public class ApplicationFormDal
    {
        public List<ApplicationForm> getForms()
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                return ctx.ApplicationForms.ToList();
            }
        }

        public ApplicationForm getbyEmail(ApplicationForm user)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                return ctx.ApplicationForms.Where(p => p.Email == user.Email).FirstOrDefault();
            }
        }

        public void Add(ApplicationForm form)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                ctx.ApplicationForms.Add(form);
                ctx.SaveChanges();
            }
        }
    }
}
