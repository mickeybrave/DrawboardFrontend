using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class DummyDataRepository : IDataRepository<Project>
    {
        public Task<DataResult<IEnumerable<Project>>> GetAll()
        {
            return Task.Run(() => new DataResult<IEnumerable<Project>>(new List<Project>
            {
                new Project{ Name="Project 1", Description="My project 1 description"},
                new Project{ Name="Project 2", Description="My project 2 description"},
                new Project{ Name="Project 3", Description="My project 3 description"},
                new Project{ Name="Project 4", Description="My project 4 description"},
                new Project{ Name="Project 5", Description="My project 5 description"},
                new Project{ Name="Project 6", Description="My project 6 description"},
                new Project{ Name="Project 7", Description="My project 7 description"},
                new Project{ Name="Project 8", Description="My project 8 description"},
                new Project{ Name="Project 9", Description="My project 9 description"},
                new Project{ Name="Project 10", Description="My project 10 description"},
                new Project{ Name="Project 11", Description="My project 11 description"},
                new Project{ Name="Project 12", Description="My project 12 description"},
                new Project{ Name="Project 13", Description="My project 13 description"},
                new Project{ Name="Project 14", Description="My project 14 description"},
                new Project{ Name="Project 15", Description="My project 15 description"},
                new Project{ Name="Project 16", Description="My project 16 description"},
                new Project{ Name="Project 17", Description="My project 17 description"},
                new Project{ Name="Project 18", Description="My project 18 description"},
                new Project{ Name="Project 19", Description="My project 19 description"},
            }, new ComplexResult { Message = null, ResultType = ResultType.OK }));
        }
    }
}
