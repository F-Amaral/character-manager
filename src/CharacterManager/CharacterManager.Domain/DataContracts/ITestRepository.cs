using CharacterManager.Domain.DataContracts.Shared;
using CharacterManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Domain.DataContracts
{
    public interface ITestRepository : IBaseRepository<Test>
    {
    }
}
