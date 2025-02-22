using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoldooNET.Domain.Models;

namespace BoldooNET.Domain.Interfaces {
    public interface IModelRepository {
        Task<Model?> GetModelAsync(int modelId);
        Task<IEnumerable<Model>> GetAllModelsAsync();
        Task AddModelAsync(Model model);
        Task UpdateModelAsync(Model model);
        Task DeleteModelByIdAsync(int modelId);
    }
}
