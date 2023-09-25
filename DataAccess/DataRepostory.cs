using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataRepostory<TEntity> : IDataRepostory<TEntity> where TEntity : class
    {
        public List<TEntity>GetModel()
        {
            DataContext _dataContext = new DataContext();
            return _dataContext.Set<TEntity>().ToList<TEntity>();

        }
        public TEntity InsertModel(TEntity modelmigration)
        {
            DataContext _dataContext = new DataContext();
            _dataContext.Add<TEntity>(modelmigration);
            _dataContext.SaveChanges();
            return modelmigration;
        }
        public TEntity UpdateModel(TEntity modelmigration)
        {
            DataContext _dataContext = new DataContext();
           _dataContext.Models.AsNoTracking();
            var modelEntity = _dataContext.Find<TEntity>(modelmigration);
            if (modelEntity != null)
            {
                _dataContext.Update<TEntity>(modelmigration);
                _dataContext.SaveChanges();
                return modelmigration;
            }
            return modelmigration;

        }
        public TEntity DeleteModel(int id)
        {
            DataContext _dataContext = new DataContext();
            var model = _dataContext.Find<TEntity>(id);
            if (model != null)
            {
                _dataContext.Remove<TEntity>(model);
                _dataContext.SaveChanges();
            }
            return model;
        }
    }
}
