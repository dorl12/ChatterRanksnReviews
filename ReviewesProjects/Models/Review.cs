using System.ComponentModel.DataAnnotations;

namespace RankingPages.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Reviewer { get; set; }

        [Range(1, 5)]
        public int Ranking { get; set; }

        public DateTime Created { get; set; }
    }
}
