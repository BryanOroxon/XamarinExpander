using System.Collections.ObjectModel;
using XamarinExpander.Models;
using XamarinExpander.Services;
using Xamarin.Forms;
namespace XamarinExpander.ViewModels
{
    public class DayListViewModel : BindableObject
    {
        ObservableCollection<DayItem> _items;

        public DayListViewModel()
        {
            LoadDayList();
        }

        public ObservableCollection<DayItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        void LoadDayList()
        {
            var items = DayService.Instance.GetDayList();
            Items = new ObservableCollection<DayItem>(items);
        }
    }
}
