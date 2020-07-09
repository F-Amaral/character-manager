using CharacterManager.Domain.DataContracts;
using CharacterManager.Domain.Models;
using CharacterManager.Domain.Mongo.Repositories.Shared;
using CharacterManager.Infra.Commons.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Domain.Mongo.Repositories
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(MongoDBSettings settings) : base(settings)
        {
        }
    }
}
