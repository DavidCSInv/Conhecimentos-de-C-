using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Enumarete.Entities
{
     class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> comments { get; set;} = new List<Comment>();


        public Post() 
        {
            
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void RemoveComment(Comment comment) 
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder ();
            Sb.AppendLine(Title);
            Sb.Append(Likes);
            Sb.Append(" Likes - ");
            Sb.AppendLine(Moment.ToString("dd/MM/yyyy  HH:mm:ss"));
            Sb.AppendLine(Content);
            Sb.AppendLine("Comments : ");

            foreach (Comment c in comments) 
            {
                Sb.AppendLine(c.Texto);
            }
            return Sb.ToString();
        }
    }
}
