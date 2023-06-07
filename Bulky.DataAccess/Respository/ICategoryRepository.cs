using Bulky.Entities.Models;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Respository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
