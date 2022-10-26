namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Save(T entity);    
        void Delete(T entity);
    }
}
