using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Code
{
    public static class ConfigurationObjectManager
    {
        private static Dictionary<string,object> objectList = new Dictionary<string,object>();

        public static void Register(string objectName,Object objectVlaue)
        {
           
                objectList.Add(objectName, objectVlaue);
            
        }

        public static Object GetObject(string objectName)
        {
            return objectList[objectName];
        }
    }
}
