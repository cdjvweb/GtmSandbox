//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns;
using Havit.Data.Patterns.DataEntries;
using Havit.Data.Patterns.Repositories;

namespace Havit.NewProjectTemplate.DataLayer.DataEntries.Security
{
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class RoleEntries : DataEntries<Havit.NewProjectTemplate.Model.Security.Role>, IRoleEntries 
	{
		public Havit.NewProjectTemplate.Model.Security.Role SystemAdministrator
        {
            get
            {
				if (systemAdministrator == null)
				{
					systemAdministrator = GetEntry(Havit.NewProjectTemplate.Model.Security.Role.Entry.SystemAdministrator);
				}
				return systemAdministrator;
            }
        }
		private Havit.NewProjectTemplate.Model.Security.Role systemAdministrator;

		public Havit.NewProjectTemplate.Model.Security.Role UserSettingsAdministrator
        {
            get
            {
				if (userSettingsAdministrator == null)
				{
					userSettingsAdministrator = GetEntry(Havit.NewProjectTemplate.Model.Security.Role.Entry.UserSettingsAdministrator);
				}
				return userSettingsAdministrator;
            }
        }
		private Havit.NewProjectTemplate.Model.Security.Role userSettingsAdministrator;

		public RoleEntries(Havit.NewProjectTemplate.DataLayer.Repositories.Security.IRoleRepository repository)
			: base(repository)
		{
		}
	}
}