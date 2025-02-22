using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoldooNET.Domain.Interfaces;
using BoldooNET.Domain.Models;

namespace BoldooNET.Infrastructure.Repositories {
    public class ModelRepository : IModelRepository {

        private readonly DbContext _context;   
        public ModelRepository(DbContext context) {
            _context = context;
        }

        public async Task AddModelAsync(Model model) {
            await _context.Models.AddAsync(model);
            return;
        }

        public async Task DeleteModelByIdAsync(int modelId) {
            var model = await _context.Models.FindAsync(modelId);
            if (model != null) {
                _context.Models.Remove(model);
                await _context.SaveChangesAsync();
            }
            return;
        }

        public async Task<IEnumerable<Model>> GetAllModelsAsync() {
            return await _context.Models.ToListAsync();
        }

        public async Task<Model?> GetModelAsync(int modelId) {
            
            return await _context.Models.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task UpdateModelAsync(Model model) {
            _context.Models.Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
