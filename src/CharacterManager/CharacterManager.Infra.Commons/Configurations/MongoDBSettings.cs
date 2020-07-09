using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Infra.Commons.Configurations
{
    public class MongoDBSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
