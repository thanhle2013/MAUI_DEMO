using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class TaskHomeDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        public TaskHomeDetailViewModel()
        {

        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
