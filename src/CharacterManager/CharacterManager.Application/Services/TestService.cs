using CharacterManager.Application.Interfaces;
using CharacterManager.Application.Services.Shared;
using CharacterManager.Domain.DataContracts;
using CharacterManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Application.Services
{
    public class TestService : BaseService<Test, ITestRepository>, ITestService
    {
        public TestService(ITestRepository repository) : base(repository)
        {
        }
    }
}
