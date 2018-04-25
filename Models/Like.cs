using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlackBelt.Models;
using BlackBelt;

namespace BlackBelt
{
  public class Like : BaseEntity
  {
    [Key]
    public int LikeId {get; set;}

    public int UserId {get; set;}
    public User User {get; set;}

    public int IdeaId {get; set;}
    public Idea Idea {get; set;}
  }
}