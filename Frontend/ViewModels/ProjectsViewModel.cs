using Frontend.Infra;
using System.Collections.Generic;
using System.Linq;

namespace Frontend
{
    

    public interface IProjectViewModel
    {
    }

    public class ProjectsViewModel : BaseViewModel, IProjectViewModel
    {
        private readonly IDataRepository<Project> _dataRepository;

        private IEnumerable<Project> _projects;
        public IEnumerable<Project> Projects
        {
            get
            {
                return _projects;
            }
            set
            {
                _projects = value;
                OnPropertyChanged();
            }
        }

        private Project _selectedProjects;
        public Project SelectedProject
        {
            get
            {
                return _selectedProjects;
            }
            set
            {
                _selectedProjects = value;
                OnPropertyChanged();
            }
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged();
            }
        }

        public ProjectsViewModel(IDataRepository<Project> dataRepository)
        {
            this._dataRepository = dataRepository;
            Init();
        }

        private async void Init()
        {
            this.IsBusy = true;

            var result = await _dataRepository.GetAll();
            switch (result.ComplexResult.ResultType)
            {
                case ResultType.OK:
                    this.Projects = result.Result;
                    if (this.Projects.Any())
                    {
                        SelectedIndex = 0;
                    }
                    break;
                case ResultType.Error:
                    this.HasError = true;
                    this.ErrorText = result.ComplexResult.Message;
                    break;
            }
           
            this.IsBusy = false;
        }
    }


}
