using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Data.SqlServer.Data;


namespace Asrfly.Data.SqlServer.Entities
{
    public class SystemRecordsEntity : IDataHelper<SystemRecords>
    {
        // ctl m+o

        // Variables
        private AppDbContext _db;
        private SystemRecords _table ;

        // Constructors
        public SystemRecordsEntity()
        {
            _db = new AppDbContext();
        }

        #region  Methods
        public int Add(SystemRecords table)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    _db.SystemRecords.Add(table);
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

        public async Task<int> AddAsync(SystemRecords table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    await _db.SystemRecords.AddAsync(table);
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
                    _db.SystemRecords.Remove(_table);
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
                    await Task.Run(() => _db.SystemRecords.Remove(_table));
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

        public int Update(SystemRecords table)
        {

            try
            {
                if (_db.Database.CanConnect())
                {
                    _db = new AppDbContext();
                    _db.SystemRecords.Update(table);
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

        public async Task<int> UpdateAsync(SystemRecords table)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    _db = new AppDbContext();
                    await Task.Run(() => _db.SystemRecords.Update(table));
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
        public SystemRecords FindById(int Id)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.SystemRecords.Where(x => x.Id == Id).FirstOrDefault();

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

        public async Task<SystemRecords> FindByIdAsync(int Id)
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.SystemRecords.Where(x => x.Id == Id).FirstOrDefault());

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

        public List<SystemRecords> GetAllData()
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.SystemRecords.ToList();

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

        public async Task<List<SystemRecords>> GetAllDataAsync()
        {
            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.SystemRecords.ToList());
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

        public List<SystemRecords> Search(string ItemName)
        {
            try
            {
                if (_db.Database.CanConnect())
                {
                    return _db.SystemRecords.Where(x => x.Id.ToString() == ItemName
                     || x.UserName.Contains(ItemName)
                    || x.Details.Contains(ItemName)
                    || x.AddedDate.Date.ToString().Contains(ItemName)
                    || x.Title.ToString().Contains(ItemName)
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

        public async Task<List<SystemRecords>> SearchAsync(string ItemName)
        {

            try
            {
                if (await _db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _db.SystemRecords.Where(x => x.Id.ToString() == ItemName
                    || x.UserName.Contains(ItemName)
                    || x.Details.Contains(ItemName)
                    || x.AddedDate.Date.ToString().Contains(ItemName)
                    || x.Title.ToString().Contains(ItemName)
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
