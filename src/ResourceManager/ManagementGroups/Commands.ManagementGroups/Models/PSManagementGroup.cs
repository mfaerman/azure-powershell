﻿using Microsoft.Azure.Management.ManagementGroups.Models;

namespace Microsoft.Azure.Commands.ManagementGroups.Models
{
    public class PSManagementGroup
    {
        public string Id { get; private set; }

        public string Type { get; private set; }

        public string Name { get; private set; }

        public PSManagementGroupProperties Properties { get; private set; }

        public PSManagementGroup()
        {
        }

        public PSManagementGroup(ManagementGroup managementGroup)
        {
            if (managementGroup != null)
            {
                Id = managementGroup.Id;
                Type = managementGroup.Type;
                Name = managementGroup.Name;
                Properties = new PSManagementGroupProperties(managementGroup.Properties);
            }
        }
    }
}
