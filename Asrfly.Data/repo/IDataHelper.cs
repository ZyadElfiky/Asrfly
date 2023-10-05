using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Data.repo
{
    public interface IDataHelper<Table>
    {

        // Read Operations

        /// <summary>Gets all data.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Searched Data</returns>
        List<Table> Search(string SearchItem);
        /// <summary>Finds Row in Tale by ID.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table</returns>
        Table FindById(int Id);

        // Write Operations 

        /// <summary>Adds row to the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when Task Completed successfully, 0 When Task Faild</returns>
        int Add(Table table);
        /// <summary>Updates the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when Task Completed successfully, 0 When Task Faild</returns>
        int Update(Table table);
        /// <summary>Deletes row by specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 when Task Completed successfully, 0 When Task Faild</returns>
        int Delete(int Id);

        // Read Operations Async

        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>List of table data</returns>
        Task<List<Table>> GetAllDataAsync();
        /// <summary>Searches the specified search item asynchronous.</summary>
        /// <param name="ItemName">Name of the item.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<List<Table>> SearchAsync(string ItemName);
        /// <summary>Finds the by identifier asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<Table> FindByIdAsync(int Id);

        // Write Operations Async

        /// <summary>Adds row to the specified table asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<int> AddAsync(Table table);
        /// <summary>Updates the specified table asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<int> UpdateAsync(Table table);
        /// <summary>Deletes row by specified identifier asynchronousy.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<int> DeleteAsync(int Id);
    }
}
