namespace Day05.Quis
{
    public interface IRepository<T>
    {
        public void Save(List<T> entityList, T entity);
        public void Update(List<T> entityList, T entity, int id);
        public void Delete(List<T> entity, int id);
        public void FindAll(List<T> entity);
        public void FindById(List<T> entity, int id);
    }
}
