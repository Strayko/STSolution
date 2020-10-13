using System.ComponentModel.DataAnnotations;

namespace STSolution.Data.Models
{
    public class FormModel
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}