using CharacterManager.APP.DTOs;
using CharacterManager.APP.Mappers.Shared;
using CharacterManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterManager.APP.Mappers.TestMappers
{
    public class TestDTOToTestMapper : BaseMapper<TestDTO, Test>
    {
        public override Test Map(TestDTO entry)
        {
            return new Test
            {
                Name = entry.Name
            };
        }
    }
}
