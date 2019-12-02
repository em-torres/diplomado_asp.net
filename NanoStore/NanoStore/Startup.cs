using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using NanoStore.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NanoStore.Startup))]

namespace NanoStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        // Creando clase Anónima para guardar los datos --/Nota: Solo se usa para aclaración de Código/--
        class UserDataCt
        {
            public string Email { get; set; }
            public string Pass { get; set; }
            public string Role { get; set; }
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // En Startup creando un Rol Administrador y un usuario para el mismo
            if (!roleManager.RoleExists("Admin"))
            {
                var userAdmin = new UserDataCt { Email = "admin@test.com", Pass = "Aguacate01*", Role = "Administrador" };
                
                CreateRole(context, roleManager, "Administrador");
                CreateUserWithRole(context, userAdmin);
            }

            // Creando el rol de Comprador y un usuario de prueba
            if (!roleManager.RoleExists("Comprador"))
            {
                var userComp = new UserDataCt { Email = "comprador@test.com", Pass = "Aguacate02*", Role = "Comprador" };
                
                CreateRole(context, roleManager, "Comprador");
                CreateUserWithRole(context, userComp);
            }
        }

        private void CreateRole(ApplicationDbContext ct, RoleManager<IdentityRole> rm, string roleName)
        {
            var role = new IdentityRole() { Name = roleName };
            rm.Create(role);
        }

        private void CreateUserWithRole(ApplicationDbContext ct, UserDataCt userData)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ct));

            // Creando el usuario              
            var user = new ApplicationUser() { UserName = userData.Email, Email = userData.Email };
            var chkUser = userManager.Create(user, userData.Pass);

            // Agregar el usuario al rol de Administrador
            if (chkUser.Succeeded)
            {
                userManager.AddToRole(user.Id, userData.Role);
            }
        }
    }
}
