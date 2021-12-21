using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio122.Entities
{
    internal class Post //publicar
    {
        public DateTime Moment { get; set; }    //data
        public string Title { get; set; }       //titulo
        public string Content { get; set; }     //conteudo
        public int Likes { get; set; }          //gostos

        public List<Comment> Comments { get; set; } = new List<Comment>(); //Comentarios

        public Post() { 
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)         //
        {                                               //
            Comments.Add(comment);                      //  aqui ele adicionou e
        }                                               //
                                                        //  
        public void RemoveComment(Comment comment)      //  removeu um comentario
        {                                               //
            Comments.Remove(comment);                   //
        }                                               //

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) // feito para percorrer a lista (LIST)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
