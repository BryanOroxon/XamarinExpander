using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace XamarinExpander.Models
{
    public class SpeakerItem : BindableObject
    {
        bool _isDetailVisible;

        public string Speaker { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }

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

        public List<SpeakerDetailItem> Items { get; set; }

    }
    public class SpeakerDetailItem
    {
        
        public string Icon { get; set; }
        public string Red { get; set; }

    }
}
