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
using Caminois.Class;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;

namespace Caminois
{
    public partial class PlayPage : PhoneApplicationPage
    {
        public List<Question> ListQuestions = new List<Question>(); 
        public PlayPage()
        {
            InitializeComponent();
            var resource = Application.GetResourceStream(new Uri("Assets/Question/question.txt", UriKind.Relative));
            StreamReader streamReader = new StreamReader(resource.Stream);
            string data = streamReader.ReadToEnd();
            Root root = JsonConvert.DeserializeObject<Root>(data);
            ListQuestions = root.Questions;
        }
    }
}