using Frontend.Infra;
using System.Collections.Generic;

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
