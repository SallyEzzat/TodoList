using System;

using Xamarin.Forms;

namespace TodoList.Views
{
    public class TodoListPageCS : ContentPage
    {
        public TodoListPageCS()
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

