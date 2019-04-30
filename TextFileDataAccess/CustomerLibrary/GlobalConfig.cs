using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataAccess> Access { get; private set; }

        public static void InitialiseConnections(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO: Create
            }

            if(textFiles)
            {
                //TODO: create txtfiles
                TextConnector text = new TextConnector();
                Access.Add(text);
            }
        }
    }
}
