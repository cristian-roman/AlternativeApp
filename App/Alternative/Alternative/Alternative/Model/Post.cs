using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alternative.Model
{
    public class Post
    {
        //private MemoryStream userDataImage;
        //public MemoryStream UserDataImage { get; set; }

        private string usernameData;
        public string UsernameData
        {
            get
            {
                return usernameData;
            }
            set
            {
                usernameData = value;
            }
        }

        private string topicData;
        public string TopicData
        {
            get
            {
                return topicData;
            }
            set
            {
                topicData = value;
            }
        }

        private string descriptionData;
        public string DescriptionData
        {
            get
            {
                return descriptionData;
            }
            set
            {
                descriptionData = value;
            }
        }

        private string upsData;
        public string UpsData
        {
            get
            {
                return upsData;
            }
            set
            {
                upsData = value;
            }
        }

        private string counterData;
        public string CounterData
        {
            get
            {
                return counterData;
            }
            set
            {
                counterData = value;
            }
        }

        private List<MemoryStream> postImages;
        public List<MemoryStream> PostImages
        {
            get
            {
                return postImages;
            }
            set
            {
                postImages = value;
            }
        }

        public Post()
        {
            postImages = new List<MemoryStream>();
        }

        public Post(string usernameData) : this()
        {
            UsernameData = usernameData;
        }

        public Post(string usernameData, string topicData)
            :this(usernameData)
        {
            TopicData = topicData;
        }

        public Post(string usernameData, string topicData, string descriptionData)
            : this(usernameData, topicData)
        {
            DescriptionData = descriptionData;
        }

        public Post(string usernameData, string topicData, string descriptionData, string counterData)
            :this(usernameData, topicData, descriptionData)
        {
            CounterData = counterData;
        }
    }
}
