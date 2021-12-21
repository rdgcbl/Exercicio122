using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio122.Entities
{
    internal class Comment
    {
        public string Text { get; set; } //texto

        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
