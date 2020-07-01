using System.Collections.ObjectModel;
using XamarinExpander.Models;
using XamarinExpander.Services;
using Xamarin.Forms;
namespace XamarinExpander.ViewModels
{
    public class SpeakerListViewModel : BindableObject
    {
        ObservableCollection<SpeakerItem> _items;

        public SpeakerListViewModel()
        {
            LoadSpeakerList();
        }

        public ObservableCollection<SpeakerItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        void LoadSpeakerList()
        {
            var items = SpeakerService.Instance.GetSpeakerList();
            Items = new ObservableCollection<SpeakerItem>(items);
        }
    }
}
