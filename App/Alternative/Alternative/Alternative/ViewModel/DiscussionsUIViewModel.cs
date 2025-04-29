using Alternative.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Alternative.ViewModel
{
    public class DiscussionsUIViewModel
    {
        public DiscussionsUIViewModel()
        {
            for(int i = 0; i < 5; i++)
            {
                posts = new List<Post>();

                string username = $"admin{i}";
                string topic = $"topic{i}";
                string description = $"Post description NO. {i}";
                string counterData = "0";
                var post = new Post(username, topic, description, counterData);

                for(int j = 1; j <= i+1; j++)
                post.PostImages.Add(new MemoryStream());

                posts.Add(post);
            }
        }

        #region properties

        private List<Post> posts;
        public List<Post> Posts
        {
            get
            {
                return posts;
            }
            set
            {
                posts = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
