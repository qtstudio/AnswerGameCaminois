using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Windows.ApplicationModel;
using Windows.Storage;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;

namespace Caminois
{
    public partial class PlayPage : PhoneApplicationPage
    {
        public List<Question> LstQuestions; 
        public PlayPage()
        {
            InitializeComponent();
            var resource = Application.GetResourceStream(new Uri("Assets/Question/question.txt", UriKind.Relative));
            StreamReader streamReader = new StreamReader(resource.Stream);
            string data = streamReader.ReadToEnd();
           // Root root = JsonConvert.DeserializeObject<Root>(data);
           
        }
    }

    public class Root
    {
        public Question question { get; set; }
    }
    public class Question
    {
        public string Title { get; set; }
        public string AnwserA { get; set; }
        public string AnwserB { get; set; }
        public string AnwserC { get; set; }
        public string AnwserD { get; set; }
        public string Anwser { get; set; }
    }
}