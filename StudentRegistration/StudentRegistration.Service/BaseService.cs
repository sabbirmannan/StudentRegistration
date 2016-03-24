using StudentRegistration.Model;

namespace StudentRegistration.Service
{
    public class BaseService
    {
        protected BusinessDbContext DbContext;

        public BaseService(BusinessDbContext db)
        {
            DbContext = db;
        }
    }
}