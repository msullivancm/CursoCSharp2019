using System;
using System.Collections.Generic;
using System.Text;

namespace ExStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes); sb.Append(" Likes - "); sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            int n = 1;
            foreach (Comment c in Comments)
            {
                sb.Append($"#{n} - ");  sb.AppendLine(c.Text);
                n++;
            }
            return sb.ToString();
        }
    }
}
