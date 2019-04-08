using System;

using Xamarin.Forms;

namespace TodoList.Views
{
    public class TodoItemPageCS : ContentPage
    {
        public TodoItemPageCS()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

