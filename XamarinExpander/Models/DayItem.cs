using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace XamarinExpander.Models
{
    public class DayItem : BindableObject
    {
        bool _isDetailVisible;

        public string Day { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Color Color { get; set; }

        public bool IsDetailVisible
        {
            get { return _isDetailVisible; }
            set
            {
                Task.Run(async () =>
                {
                    await Task.Delay(value ? 0 : 250);
                    _isDetailVisible = value;
                    OnPropertyChanged();
                });
            }
        }

        public List<DayDetailItem> Items { get; set; }
    }

    public class DayDetailItem
    {
        public string Day { get; set; }
        public string Name { get; set; }
        public string Hour { get; set; }
        public string Speaker { get; set; }
        public string Imagen { get; set; }
        public Color Color { get; set; }
        public bool Done { get; set; }
        public bool IsLatest { get; set; }
    }
}
