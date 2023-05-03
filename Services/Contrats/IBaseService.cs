using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAllService(bool trackChanges);
        T GetByIDService(int id, bool trackChanges);
        T CreateService(T entity);
        void UpdateService(T entity, int id, bool trackChanges);
        void DeleteService(int id, bool trackChanges);
    }
}
