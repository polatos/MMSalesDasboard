using System;
using Microsoft.AspNetCore.Identity;

namespace MMSalesBoard.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(string fullName)
        {
            FullName = fullName;

        }

        public ApplicationUser()
        {

        }

        public string FullName { get; set; }
        public string OrgUnitId { get; set; }
        public string Modifier { get; set; }
        public DateTime ModifiedDateTime { get; set; }

    }
}
