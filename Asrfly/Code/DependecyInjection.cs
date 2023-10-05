using Asrfly.Core.Entities;
using Asrfly.Data.SqlServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Code
{
    public static class DependecyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigurationObjectManager.Register("Categories", new CategoriesEntity());
            ConfigurationObjectManager.Register("SystemRecords", new SystemRecordsEntity());
        }
    }
}
