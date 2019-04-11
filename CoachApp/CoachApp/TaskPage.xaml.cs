using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoachApp
{
    public partial class TaskPage : ContentPage
    {
        public TaskPage()
        {
            InitializeComponent();
        }
        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            return;
            //File.WriteAllText(_fileName, editor.Text);
        }
        void InvertAllCheck(object sender, EventArgs e)
        {
            return;
            //File.WriteAllText(_fileName, editor.Text);
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            return;
            //File.WriteAllText(_fileName, editor.Text);
        }
        void OnClickTask(object sender, EventArgs e)
        {
            ((Button)sender).Opacity = 0.3;
            ((Button)sender).IsEnabled = false;
            return;
            //File.WriteAllText(_fileName, editor.Text);
        }
    }
}
