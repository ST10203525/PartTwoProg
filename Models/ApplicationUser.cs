﻿using Microsoft.AspNetCore.Identity;

namespace PartTwoProg.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
