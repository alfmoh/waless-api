using System;

namespace Waless.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime InscriptionDate { get; set; }

        public Gender Gender { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        public string Picture_Small { get; set; }
        public string Picture_Medium { get; set; }
        public string Picture_Big { get; set; }
        public string Picture_Xl { get; set; }
        public string Country { get; set; }
        public string Lang { get; set; }
        public bool Is_Kid { get; set; }
        public string Tracklist { get; set; }
    }
}