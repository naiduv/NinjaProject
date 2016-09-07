using System;
using System.Collections.Generic;
using System.ComponentModel;
using NinjaDomain.Classes.Interfaces;

namespace NinjaDomain.Classes
{
    public class Post:IModificationHistory
    {
        public Post()
        {
        }
        public int PostId { get; set; }
        public int TopicId { get; set; }
        public string UserIp { get; set; }
        public string PostText { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
       
    }
}