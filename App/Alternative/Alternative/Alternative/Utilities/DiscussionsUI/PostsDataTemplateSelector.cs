using Alternative.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Alternative.Utilities.DiscussionsUI
{
    public class PostsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OnePhotoPost { get; set; }
        public DataTemplate TwoPhotosPost { get; set; }
        public DataTemplate MorePhotosPost { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var post = item as Post;

            //if(post.PostImages.Count == 0)
            //{
            //    return NoPhotosPost;
            //}else

            if (post.PostImages.Count == 1)
            {
                return OnePhotoPost;
            }
            else if (post.PostImages.Count == 2)
            {
                return TwoPhotosPost;
            }
            else
            {
                return MorePhotosPost;
            }
        }
    }
}
