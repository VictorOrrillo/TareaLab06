using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab06
{
    public class Group : List<Item>
    {
        public string Title { get; set; }

        public Group(string title)
        {
            Title = title;
        }
    }
}