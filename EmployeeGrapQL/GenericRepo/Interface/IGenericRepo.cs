namespace EmployeeGrapQL.GenericRepo.Interface
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<IEnumerable<T>> AddItem(T t);

        public Task<T> UpdateItem(int id,T t);
        public Task<T> DeleteItem(int id);


        //public Task<T> CreateData(T _object);
        //public IEnumerable<T> GetAllData(); 
        //public Task<T> GetDataById(int Id);

    }
}
