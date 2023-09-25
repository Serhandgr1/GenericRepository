using DataAccess;

namespace BuisenessLayer
{
    public class BuiseneesCode<TEntity> : IBuiseneesCode<TEntity> where TEntity : class
    {
        private readonly IDataRepostory<TEntity> _dataRepostry;
        public BuiseneesCode(IDataRepostory<TEntity> dataRepostory)
        {
            _dataRepostry = dataRepostory;
        }
        public List<TEntity> GetModel()
        {

            return _dataRepostry.GetModel();
        }
        public TEntity InsertModel(TEntity modelmigration)
        {
            return _dataRepostry.InsertModel(modelmigration);
        }

        public TEntity UpdateModel(TEntity modelmigration)
        {
            return _dataRepostry.UpdateModel(modelmigration);
        }

        public TEntity DeleteModel(int id)
        {
            return _dataRepostry.DeleteModel(id);
        }
    }
}

