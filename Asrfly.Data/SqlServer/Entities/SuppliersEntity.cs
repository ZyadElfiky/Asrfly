using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Data.SqlServer.Data;


namespace Asrfly.Data.SqlServer.Entities
{
    public class SuppliersEntity : IDataHelper<Suppliers>
    {
        // ctl m+o

        // Variables
        private AppDbContext _db;
        private Suppliers _table ;

        // Constructors
        public SuppliersEntity()
        {
            _db = new AppDbContext();
        }

        #region  Methods
        public int Add(Suppliers table)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    _db.Suppliers.Add(table);
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

        public async Task<int> AddAsync(Suppliers table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    await _db.Suppliers.AddAsync(table);
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
                    _db.Suppliers.Remove(_table);
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
                    await Task.Run(() => _db.Suppliers.Remove(_table));
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

        public int Update(Suppliers table)
        {

            try
            {
                if (_db.Database.CanConnect())
                {
                    _db = new AppDbContext();
                    _db.Suppliers.Update(table);
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

        public async Task<int> UpdateAsync(Suppliers table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    _db = new AppDbContext();
                    await Task.Run(() => _db.Suppliers.Update(table));
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
        public Suppliers FindById(int Id)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Suppliers.Where(x => x.Id == Id).FirstOrDefault();

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

        public async Task<Suppliers> FindByIdAsync(int Id)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Suppliers.Where(x => x.Id == Id).FirstOrDefault());

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

        public List<Suppliers> GetAllData()
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Suppliers.ToList();

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

        public async Task<List<Suppliers>> GetAllDataAsync()
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Suppliers.ToList());
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
        public List<Suppliers> Search(string ItemName)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Suppliers.Where(x => x.Id.ToString() == ItemName
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
        public async Task<List<Suppliers>> SearchAsync(string ItemName)
        {

            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Suppliers.Where(x => x.Id.ToString() == ItemName
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
