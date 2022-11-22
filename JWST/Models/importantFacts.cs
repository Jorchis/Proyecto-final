//importantFacts module

using System.ComponentModel.DataAnnotations;

namespace JWST.Models
{
    public class importantFacts
    {
        public int Id { get; set; }
        public string? IFTitle { get; set; }
        public string? IFText { get; set; }
        public string pictureURL { get; set; }
        public int userID { get; set; }
    }
}