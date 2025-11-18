using BuscaminasPortable.Models;
using CommunityToolkit.Mvvm.Input;

namespace BuscaminasPortable.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}