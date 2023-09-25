
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLayer
{
    public interface IBuiseneesCode<TEntity> where TEntity : class
    {
        List<TEntity> GetModel();
        TEntity InsertModel(TEntity modelmigration);
        TEntity UpdateModel(TEntity modelmigration);
        TEntity DeleteModel(int id);
    }
}
