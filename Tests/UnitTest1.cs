using Frontend;
using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProjectsViewModel_OK_Test()
        {
            //arrange
            Mock<IDataRepository<Project>> dataRepository = new Mock<IDataRepository<Project>>();

            IEnumerable<Project> projects = new List<Project> { new Project { Name = "Test" } };

            var res = new DataResult<IEnumerable<Project>>(projects, new ComplexResult { Message = null, ResultType = ResultType.OK });

            dataRepository.Setup(x => x.GetAll()).Returns(Task.Run(() => res));

            //Act
            ProjectsViewModel projectsViewModel = new ProjectsViewModel(dataRepository.Object);

            //Assert

            Assert.False(projectsViewModel.IsBusy);
            Assert.False(projectsViewModel.HasError);
            Assert.True(projectsViewModel.Projects.Any());
            Assert.True(projectsViewModel.SelectedIndex == 0);
        }

        [Test]
        public void ProjectsViewModel_Error_Test()
        {
            //arrange
            Mock<IDataRepository<Project>> dataRepository = new Mock<IDataRepository<Project>>();

            IEnumerable<Project> projects = new List<Project> { new Project { Name = "Test" } };

            var res = new DataResult<IEnumerable<Project>>(projects, new ComplexResult { Message = "Ups..", ResultType = ResultType.Error });
            dataRepository.Setup(x => x.GetAll()).Returns(Task.Run(() => res));

            //Act
            ProjectsViewModel projectsViewModel = new ProjectsViewModel(dataRepository.Object);

            //Assert

            Assert.False(projectsViewModel.IsBusy);
            Assert.True(projectsViewModel.HasError);
            Assert.True(projectsViewModel.ErrorText.Contains("Ups"));
            Assert.Null(projectsViewModel.Projects);
        }
    }
}