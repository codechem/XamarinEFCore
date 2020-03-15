using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ListItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string RandomGuid { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}