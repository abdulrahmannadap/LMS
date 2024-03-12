namespace LMS.DAL.Repository.Interface
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
    }
}
