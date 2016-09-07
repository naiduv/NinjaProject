using System.Collections.Generic;
using System;
using NinjaDomain.Classes.Interfaces;

namespace NinjaDomain.Classes
{
  public class Topic : IModificationHistory
  {
    public Topic() {
      Posts = new List<Post>();
    }

    public int TopicId { get; set; }
    public string UserIp { get; set; }
    public string TopicSubject { get; set; }

    public List<Post> Posts { get; set; }

    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    public bool IsDirty { get; set; }
  }
}