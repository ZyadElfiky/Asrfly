using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Data.SqlServer.Data;


namespace Asrfly.Data.SqlServer.Entities
{
    public class CategoriesEntity : IDataHelper<Categories>
    {
        // ctl m+o

        // Variables
        private AppDbContext _db;
        private Categories _table ;

        // Constructors
        public CategoriesEntity()
        {
            _db = new AppDbContext();
        }

        #region  Methods
        public int Add(Categories table)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    _db.Categories.Add(table);
                    _db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> AddAsync(Categories table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    await _db.Categories.AddAsync(table);
                    await _db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    _table = FindById(Id);
                    _db.Categories.Remove(_table);
                    _db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    _table = await FindByIdAsync(Id);
                    await Task.Run(() => _db.Categories.Remove(_table));
                    await _db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Update(Categories table)
        {

            try
            {
                if (_db.Database.CanConnect())
                {
                    _db = new AppDbContext();
                    _db.Categories.Update(table);
                    _db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateAsync(Categories table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    _db = new AppDbContext();
                    await Task.Run(() => _db.Categories.Update(table));
                    await _db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
        public Categories FindById(int Id)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Categories.Where(x => x.Id == Id).FirstOrDefault();

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Categories> FindByIdAsync(int Id)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Categories.Where(x => x.Id == Id).FirstOrDefault());

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Categories> GetAllData()
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Categories.ToList();

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Categories>> GetAllDataAsync()
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Categories.ToList());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public List<Categories> Search(string ItemName)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Categories.Where(x => x.Id.ToString() == ItemName
                    || x.Name.Contains(ItemName)
                    || x.Details.Contains(ItemName)
                    || x.AddedDate.Date.ToString().Contains(ItemName)
                    || x.Balance.ToString().Contains(ItemName)
                    )
                        .ToList();

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<Categories>> SearchAsync(string ItemName)
        {

            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Categories.Where(x => x.Id.ToString() == ItemName
                   || x.Name.Contains(ItemName)
                    || x.Details.Contains(ItemName)
                    || x.AddedDate.Date.ToString().Contains(ItemName)
                    || x.Balance.ToString().Contains(ItemName)
                    )
                        .ToList());

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
