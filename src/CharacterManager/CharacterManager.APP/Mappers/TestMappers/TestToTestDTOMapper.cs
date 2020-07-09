using CharacterManager.APP.DTOs;
using CharacterManager.APP.Mappers.Shared;
using CharacterManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterManager.APP.Mappers.TestMappers
{
    public class TestToTestDTOMapper : BaseMapper<Test, TestDTO>
    {
        public override TestDTO Map(Test entry)
        {
            return new TestDTO()
            {
                Id = entry.Id,
                Name = entry.Name
            };
        }
    }
}
