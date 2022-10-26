namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Repository<T> : IRepository<T>
    {
      //  DBContext _db;
        public void Delete(T entity)
        {
         //   _db.Delete(entity); 
        }
        public T GetById(int id)
        {
            return default(T);
        }
        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
