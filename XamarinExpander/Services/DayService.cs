using System.Collections.Generic;
using XamarinExpander.Models;
using Xamarin.Forms;

namespace XamarinExpander.Services
{
    public class DayService
    {
        static DayService _instance;

        public static DayService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DayService();
                return _instance;
            }
        }

        public List<DayItem> GetDayList()
        {
            return new List<DayItem>
            {
                new DayItem { Day= "25 de junio 2020", Icon = "c25.png", Color = Color.Lime,
                    Items = new List<DayDetailItem>
                    {
                        new DayDetailItem { Name = "¿Qué debo saber al comenzar con Xamarin?", Speaker= "Humberto Jaimes", Hour="8:00PM", Imagen="https://www.humbertojaimes.net/wp-content/uploads/2020/06/HumbertoJaimes-300x300.jpg" },
                        new DayDetailItem { Name = "MVVM en Xamarin.Forms", Speaker= "Humberto Jaimes", Hour="9:30PM", IsLatest = true },
                    } },
                new DayItem { Day = "26 de junio 2020", Icon = "c26.png", Color = Color.Gold,
                    Items = new List<DayDetailItem>
                    {
                        new DayDetailItem { Name = "Introducción a la creación y consumo de un API .NET Core desde Xamarin", Speaker= "Jesús Gil y Humberto Jaimes", Hour="8:00PM", IsLatest = true },
                    } },
                new DayItem { Day = "27 de junio 2020", Icon = "c27.png", Color = Color.MediumSpringGreen,
                    Items = new List<DayDetailItem>
                    {
                        new DayDetailItem { Name = ".NET MAUI y el futuro de Xamarin.Forms", Speaker= "Humberto Jaimes", Hour="10:00AM" },
                        new DayDetailItem { Name = "Preguntas y respuestas", Speaker= "Humberto Jaimes y Cristian Gonzáles", Hour="11:15AM" },
                        new DayDetailItem { Name = "Azure DevOps: Pipelines 101", Speaker= "Gustavo Barrientos", Hour="12:30PM"},
                        new DayDetailItem { Name = "Interfaces responsivas con VisualStateManager", Speaker= "Benjamín Romero", Hour="2:00PM"},
                        new DayDetailItem { Name = "SwipeView en Xamarin.Forms", Speaker= "Alejandro Ruiz", Hour="3:15PM" },
                        new DayDetailItem { Name = "Introducción a OpenGL/ES en Xamarin con UrhoSharp", Speaker= "Juan Carlos Ricalde", Hour="4:30PM", IsLatest = true },
                    } },
                new DayItem { Day = "29 de junio 2020", Icon = "c29.png", Color = Color.DeepSkyBlue,
                    Items = new List<DayDetailItem>
                    {
                        new DayDetailItem { Name = "CI/CD con Github Bitrise & App Center", Speaker= "Cristian González", Hour="8:00PM", },
                        new DayDetailItem { Name = "Audio y video en Xamarin.Forms con Media Element", Speaker= "Luis Beltrán", Hour="8:00PM", IsLatest = true },
                    } },
                new DayItem { Day = "30 de junio 2020", Icon = "c30.png", Color = Color.Orange,
                    Items = new List<DayDetailItem>
                    {
                        new DayDetailItem { Name = "ExpanderView en Xamarin.Forms", Speaker= "Bryan  Oroxón", Hour="8:00PM", IsLatest = true },

                    } },           
            };
        }
    }
} 