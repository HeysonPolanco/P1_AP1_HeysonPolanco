using Microsoft.EntityFrameworkCore;
using P1_AP1_HeysonPolanco.DAL;
using P1_AP1_HeysonPolanco.Models;

namespace P1_AP1_HeysonPolanco.Services;

public class EntradasGuacalesService
{
    private readonly Context _context;

    public EntradasGuacalesService(Context context)
    {
        _context = context;
    }

    public async Task<List<EntradasGuacales>> GetAllAsync()
    {
        return await _context.EntradasGuacales.ToListAsync();
    }

    public async Task<EntradasGuacales> GetByIdAsync(int id)
    {
        return await _context.EntradasGuacales.FindAsync(id);
    }

    public async Task AddAsync(EntradasGuacales entrada)
    {
        _context.EntradasGuacales.Add(entrada);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(EntradasGuacales entrada)
    {
        _context.EntradasGuacales.Update(entrada);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entrada = await GetByIdAsync(id);
        if (entrada != null)
        {
            _context.EntradasGuacales.Remove(entrada);
            await _context.SaveChangesAsync();
        }
    }
}
