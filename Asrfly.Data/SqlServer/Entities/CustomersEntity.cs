using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Data.SqlServer.Data;


namespace Asrfly.Data.SqlServer.Entities
{
    public class CustomersEntity : IDataHelper<Customers>
    {
        // ctl m+o
        // Variables
        private AppDbContext _db;
        private Customers _table ;

        // Constructors
        public CustomersEntity()
        {
            _db = new AppDbContext();
        }

        #region  Methods
        public int Add(Customers table)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    _db.Customers.Add(table);
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

        public async Task<int> AddAsync(Customers table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    await _db.Customers.AddAsync(table);
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
                    _db.Customers.Remove(_table);
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
                    await Task.Run(() => _db.Customers.Remove(_table));
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

        public int Update(Customers table)
        {

            try
            {
                if (_db.Database.CanConnect())
                {
                    _db = new AppDbContext();
                    _db.Customers.Update(table);
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

        public async Task<int> UpdateAsync(Customers table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    _db = new AppDbContext();
                    await Task.Run(() => _db.Customers.Update(table));
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
        public Customers FindById(int Id)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Customers.Where(x => x.Id == Id).FirstOrDefault();

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

        public async Task<Customers> FindByIdAsync(int Id)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Customers.Where(x => x.Id == Id).FirstOrDefault());

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

        public List<Customers> GetAllData()
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Customers.ToList();

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

        public async Task<List<Customers>> GetAllDataAsync()
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Customers.ToList());
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
        public List<Customers> Search(string ItemName)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.Customers.Where(x => x.Id.ToString() == ItemName
                    || x.Name.Contains(ItemName)
                    || x.Email.Contains(ItemName)
                    || x.PhoneNumber.Contains(ItemName)
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
        public async Task<List<Customers>> SearchAsync(string ItemName)
        {

            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.Customers.Where(x => x.Id.ToString() == ItemName
                    || x.Name.Contains(ItemName)
                    || x.Email.Contains(ItemName)
                    || x.PhoneNumber.Contains(ItemName)
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
