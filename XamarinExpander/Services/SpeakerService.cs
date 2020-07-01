using System.Collections.Generic;
using XamarinExpander.Models;
using Xamarin.Forms;

namespace XamarinExpander.Services
{
    public class SpeakerService
    {
        static SpeakerService _instance;

        public static SpeakerService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SpeakerService();
                return _instance;
            }
        }

        public List<SpeakerItem> GetSpeakerList()
        {
            return new List<SpeakerItem>
            {
                new SpeakerItem {
                    Speaker = "Alejandro Ruiz",
                    Titulo = "Microsoft MVP",
                    EndColor = Color.FromHex("#228F93"),
                    StartColor = Color.FromHex("#4BE9E4"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/AlejandroRuiz-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "StaticResource IconBlogger", Red= "http://alejandroruizvarela.blogspot.mx/",},
                        new SpeakerDetailItem { Icon = "StaticResource IconTwitter", Red= "https://twitter.com/alejandroruizva", },
                        new SpeakerDetailItem { Icon = "StaticResource IconGithub", Red= "https://github.com/AlejandroRuiz", },
                    } },
                new SpeakerItem {
                    Speaker = "Humberto Jaimes",
                    Titulo = "Microsoft MVP",
                    EndColor = Color.FromHex("#F5307F"),
                    StartColor = Color.FromHex("#FF7C6F"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/HumbertoJaimes-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "StaticResource IconYoutube", Red= "https://youtube.com/c/humbertojaimes",},
                        new SpeakerDetailItem { Icon = "StaticResource IconWordpress", Red= "http://www.humbertojaimes.net/", },
                        new SpeakerDetailItem { Icon = "StaticResource IconGithub", Red= "https://github.com/humbertojaimes",},
                        new SpeakerDetailItem { Icon = "StaticResource IconLinkedin", Red= "https://mx.linkedin.com/in/humbertoj",},
                        new SpeakerDetailItem { Icon = "StaticResource IconTwitter", Red= "https://twitter.com/HJaimesDev", },
                    } },
                new SpeakerItem {
                    Speaker = "Jesús Gil",
                    Titulo ="Microsoft MVP",
                    EndColor = Color.FromHex("#8739E5"),
                    StartColor = Color.FromHex("#5396FF"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/04/JesusGil-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "{StaticResource IconYoutube}", Red= "https://www.youtube.com/channel/UCakBvWMvQVPuSoE5AiO6JBw",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconWordpress}", Red= "https://jesusgilv.wordpress.com/about/", },
                        new SpeakerDetailItem { Icon = "{StaticResource IconLinkedin}", Red= "https://mx.linkedin.com/in/jesusgilv",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconTwitter}", Red= "https://twitter.com/sql_rudo", },
                    } },
                new SpeakerItem {
                    Speaker= "Luis Beltrán",
                    Titulo="Microsoft MVP",
                    EndColor = Color.FromHex("#932239"),
                    StartColor = Color.FromHex("#E94B81"),
                    Imagen="https://www.humbertojaimes.net/wp-content/uploads/2020/04/LuisBeltran-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "{StaticResource IconYoutube}", Red= "https://youtube.com/c/darkicebeam",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconBlogger}", Red= "http://icebeamwp.blogspot.cz/", },
                        new SpeakerDetailItem { Icon = "{StaticResource IconDonate}", Red= "https://luisbeltran.mx/", },
                        new SpeakerDetailItem { Icon = "{StaticResource IconGithub}", Red= "https://github.com/icebeam7",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconLinkedin}", Red= "https://cz.linkedin.com/in/luisantoniobeltran",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconTwitter}", Red= "https://twitter.com/darkicebeam", },
                    } },
                new SpeakerItem {
                    Speaker = "Juan Carlos Ricalde",
                    Titulo = "Software Architect",
                    EndColor = Color.FromHex("#932239"),
                    StartColor = Color.FromHex("#E94B81"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/JuanCarlos.jpg",
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "{StaticResource IconBlogger}", Red= "http://jucaripo.com/", },
                        new SpeakerDetailItem { Icon = "{StaticResource IconGithub}", Red= "https://github.com/jucaripo",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconLinkedin}", Red= "https://mx.linkedin.com/in/jucaripo",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconTwitter}", Red= "https://twitter.com/jucaripo", },
                    } },
                new SpeakerItem {
                    Speaker = "Benjamín Romero",
                    Titulo = "Software Developer",
                    EndColor = Color.FromHex("#439322"),
                    StartColor = Color.FromHex("#A6E94B"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/BejaminRomero-300x300.jpg",
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "{StaticResource IconBlogger}", Red= "http://www.sysne.com.mx", },
                        new SpeakerDetailItem { Icon = "{StaticResource IconGithub}", Red= "https://github.com/BRomeroT",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconLinkedin}", Red= "https://mx.linkedin.com/in/bromerot",},
                        new SpeakerDetailItem { Icon = "{StaticResource IconTwitter}", Red= "https://twitter.com/bromerot", }
                    } },
                new SpeakerItem {
                    Speaker = "Bryan Oroxón",
                    Titulo = "Software Developer",
                    EndColor = Color.FromHex("#439322"),
                    StartColor = Color.FromHex("#A6E94B"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/BryanOroxon-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "&#xf19a;", Red= "https://bryanoroxon.wordpress.com", },
                        new SpeakerDetailItem { Icon = "&#xf113;", Red= "https://github.com/BryanOroxon",},
                        new SpeakerDetailItem { Icon = "&#xf318;", Red= "https://www.linkedin.com/in/bryan-oroxon",},
                        new SpeakerDetailItem { Icon = "&#xf309;", Red= "https://twitter.com/bryanoroxon", },
                    } },
                new SpeakerItem {
                    Speaker = "Cristian González",
                    Titulo = "Software Developer",
                    EndColor = Color.FromHex("#229357"),
                    StartColor = Color.FromHex("#4BE9C3"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/04/CristianGonzalez-300x300.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "&#xf113", Red= "https://github.com/DarryStonem",},
                        new SpeakerDetailItem { Icon = "&#xf318;", Red= "https://mx.linkedin.com/in/cristiangonzalez10",},
                        new SpeakerDetailItem { Icon = "&#xf309;", Red= "https://twitter.com/DarryStonem", },
                    } },
                new SpeakerItem {
                    Speaker = "Gustavo Barrientos",
                    Titulo = "Software Developer",
                    EndColor = Color.FromHex("#E66337"),
                    StartColor = Color.FromHex("#FFDF3F"),
                    Imagen = "https://www.humbertojaimes.net/wp-content/uploads/2020/06/GustavoBarrientos.jpg" ,
                    Items = new List<SpeakerDetailItem>
                    {
                        new SpeakerDetailItem { Icon = "StaticResource Github", Red= "https://github.com/tavobarrientos",},
                        new SpeakerDetailItem { Icon = "StaticResource Linkedin", Red= "https://mx.linkedin.com/in/gustavobarrientos",},
                    } },

            };
        }
    }
}