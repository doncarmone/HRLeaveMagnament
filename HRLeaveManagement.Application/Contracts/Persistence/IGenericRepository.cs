using HRLeaveManagement.Domain.Common;

namespace HRLeaveManagement.Application.Contracts.Persistence;
//as Interface any class can be T Generic where T is a type of class
public interface IGenericRepository<T> where T : BaseEntity
{
  Task<IReadOnlyList<T>> GetAsync();
  Task<T?> GetByIdAsync(int id);
  Task CreateAsync(T entity);
  Task UpdateAsync(T entity);
  Task DeleteAsync(T entity);
}