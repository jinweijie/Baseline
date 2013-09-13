using Baseline.DomainModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace Baseline.Core
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<EFContext>
    {
        public static void SeedContext(EFContext context)
        {
            // test data
            var entry = ConfigurationManager.AppSettings["db:CreateTestDataOnInitialization"];

            if (entry != null)
            {
                if (entry.ToLowerInvariant() == "true")
                {
                    using (var ctx = new EFContext())
                    {
                        //initial data

                        var user = new User
                        {
                            UserName = "jinweijie",
                            FirstName = "Weijie",
                            LastName = "JIN",
                            Email = "jinweijie@gmail.com",
                            Addresses = new List<Address>
                            {
                                new Address{
                                    AddressLine1 = "Pudong",
                                    AddressLine2 = "Shanghai, China",
                                }
                            },
                            Roles = new List<Role>
                            {
                                new Role{
                                    Name = "User",
                                
                                },
                                new Role{
                                    Name = "Adminitrator"
                                }
                            }
                        };

                        ctx.Users.Add(user);

                        ctx.SaveChanges();
                    }
                }
            }
        }

        protected override void Seed(EFContext context)
        {
            SeedContext(context);
            base.Seed(context);
        }
    }
}

