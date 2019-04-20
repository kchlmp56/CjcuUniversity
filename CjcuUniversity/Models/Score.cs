using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CjcuUniversity.Models
{
    public class Score
    {
        public int ID { get; set; }
        public string Sname { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
    }

    public class ScoreContext : DbContext
    {
        public DbSet<Score> Courses { get; set; }
    }
}