namespace _8_Generic_Interface___Repository_Pattern__2.DataAccess.Abstract
{
    public interface IRepository <TEntity>
    {
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Delete(int id);

    }
}