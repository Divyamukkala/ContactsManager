using System.ComponentModel.DataAnnotations;

namespace ContactsManager.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
