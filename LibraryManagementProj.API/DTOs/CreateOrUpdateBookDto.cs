using System;

namespace LibraryManagementProj.API.DTOs
{
    public class CreateOrUpdateBookDto
    {
        public string BookName { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string AuthorName { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }
    }
}
