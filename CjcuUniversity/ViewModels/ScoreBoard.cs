using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CjcuUniversity.ViewModels
{
    public class ScoreBoard
    {
        public int ID { get; set; }
        public string Sname { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Total { get; set; }
    }

    public class ScoreBoardContext : DbContext
    {
        public DbSet<ScoreBoard> Courses { get; set; }
    }
}