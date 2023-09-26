using QueryBuilder.Models;

namespace QueryBuilder.Models
{
    public interface IClassModel
    {
        public int Id { get; set; }
    }
}
public interface IRepository<T> where T : IClassModel
{
    // Create
    void Create(T item);

    // Read
    T Read(int id);

    // Read All
    IEnumerable<T> ReadAll();

    // Update
    void Update(T item);

    // Delete
    void Delete(int id);
}
