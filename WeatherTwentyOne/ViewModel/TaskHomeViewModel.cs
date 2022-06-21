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
    public partial class TaskHomeViewModel : ObservableObject
    {
        IConnectivity connectivity;

        [ObservableProperty]
        public ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        public TaskHomeViewModel(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
            Items = new ObservableCollection<string>();
        }


        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                await Shell.Current.DisplayAlert("Error", "Task not empty value!", "OK");
                return;
            }
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Error", "No internet", "OK");
            }

            Items.Add(Text);
            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string text)
        {
            if(Items.Contains(text))
                Items.Remove(text);

        }

        [RelayCommand]
        async Task Detail(string text)
        {
            await Shell.Current.GoToAsync($"{nameof(TaskDetail)}?Text={text}");
        }
    }
}
