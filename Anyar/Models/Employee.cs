using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Anyar.Models
{
    public class Employee : BaseEntity
    {
        [MaxLength(128),Required]
        public string FullName { get; set; }
        [Required]
        public string JobStatus { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required,NotNull]
        public string SocialMedia {  get; set; }
    }
}
