using Facturosaurus.Forms.api;
using Facturosaurus.Forms.dtos;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.SubbClases
{
    internal class UserRolesComboBox
    {
        FacturosaurusApi api;
        private List<Role> rolesList = new List<Role>();

        public UserRolesComboBox()
        {
            api = new FacturosaurusApi();
            if (api.HasConnection)
            {
                var rolesDto = api.GetRolesList();
                rolesList = GetRoleFromDto(rolesDto);
            }
        }

        public List<Role> getRolesList()
        {
            return rolesList;
        }

        public Role getDefaultRole()
        {
            return rolesList.FirstOrDefault();
        }

        public Role getRole(int id)
        {
            return rolesList.Where(x => x.Id == id).FirstOrDefault();
        }

        public Role getRole(string name)
        {
            var role = rolesList.FirstOrDefault(x => x.Name == name);
            var aa = rolesList.Where(x => x.Name == name).FirstOrDefault();
            return rolesList.Where(x => x.Name == name).FirstOrDefault();
        }

        private List<Role> GetRoleFromDto(List<RoleDto> rolesDto)
        {
            var roles = new List<Role>();

            foreach (var role in rolesDto)
            {
                roles.Add(new Role() { Id = role.Id, Name = role.Name });
            }
            return roles;
        }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
