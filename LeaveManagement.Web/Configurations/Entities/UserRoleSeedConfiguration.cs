using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ce0ea342-61d0-4cd4-d790-d11210b6acb5",  
                    UserId = "ee0e28ef-86e5-4091-af27-d7ef29661605"  // admin@localhost.com
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cf0ea942-7df0-42c5-9d10-c18919b6a8d7",  
                    UserId = "c9f52f7c-70c5-4830-b39a-44c5e5f297a1"   // admin@test.com
                }
           );
        }
    }
}