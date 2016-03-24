using StudentRegistration.Model;

namespace StudentRegistration.Repository
{
    public abstract class BaseRepository
    {
        public BusinessDbContext Db { get; set; }

        protected BaseRepository(BusinessDbContext db)
        {
            this.Db = db;
        }
    }
}