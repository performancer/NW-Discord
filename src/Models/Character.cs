using System;
using System.ComponentModel.DataAnnotations;

namespace NW.Models
{
    public enum AccessRole
    {
        Player, Counsellor, GameMaster
    }

    public class Character
    {
        Character()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Account needs to be between 1-20 letters")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Name has to be between 1-255 letters")]
        public string Name { get; set; }

        [EnumDataType(typeof(AccessRole))]
        public AccessRole Role { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public Vector3 Location { get; set; }

        public int Score { get; set; }

        public bool IsPlayer()
        {
            return AccountName != null && AccountName.Length > 0;
        }

        public override string ToString()
        {
            return Name + " " + Location;
        }
    }
}