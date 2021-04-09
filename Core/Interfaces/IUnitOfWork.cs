namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
         IGenericRopository<T> Entity {get;}
         void Save();
    }
}