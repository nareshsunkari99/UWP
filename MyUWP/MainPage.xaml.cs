using MyUWP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Person person;
        public MainPage()
        {
            this.InitializeComponent();
            person = Person.GetPerson();
            
            DataContext = person;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //MediaElement  mediaElement = new MediaElement();
            //SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer(); 
            //SpeechSynthesisStream speechSynthesisStream =await speechSynthesizer.SynthesizeTextToStreamAsync(mytextbox.Text);
            //mediaElement.SetSource(speechSynthesisStream, speechSynthesisStream.ContentType);
            //mediaElement.Play();

            //var input = txt_Name.Text;
            //if (!string.IsNullOrEmpty(input))
            //{
            //    txtBlck_Result.Text = $"your input is valid and your input is {input}";
            //}
            //else
            //{
            //    txtBlck_Result.Text = "your input is not valid";
            //}

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var message = $"{person.Name } is a {person.Designation}";
            txtblock.Text=message;  

        }
    }
}
