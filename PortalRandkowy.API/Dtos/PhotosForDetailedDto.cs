using System;

namespace PortalRandkowy.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; } // Opis
        public DateTime DateAdded { get; set; } // Data dodania
        public bool IsMain { get; set; } // Czy zdjęcie jest główne
        //public string public_id { get; set; }
    }
}