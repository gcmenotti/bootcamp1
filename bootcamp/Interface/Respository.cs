using Microsoft.EntityFrameworkCore;

namespace bootcamp.Interface;

public abstract class Repository<T>(DbContext context) : IRepository<T>
    where T : class
{
    private readonly DbSet<T?> _dbSet = context.Set<T>();

    public async Task<IEnumerable<T?>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T? entity)
    {
        await _dbSet.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T? entity)
    {
        _dbSet.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _dbSet.Remove(entity);
        await context.SaveChangesAsync();
    }
}
