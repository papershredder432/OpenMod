﻿using System.Collections.Generic;
using System.Linq;
using OpenMod.API.Permissions;
using OpenMod.Core.Permissions.Data;

namespace OpenMod.Core.Permissions
{
    public sealed class PermissionGroup : IPermissionGroup
    {
        public PermissionGroup()
        {
            Parents = new List<string>();
            Data = new Dictionary<string, object>();
        }
        public PermissionGroup(PermissionGroupData data)
        {
            Id = data.Id;
            Priority = data.Priority;
            DisplayName = data.DisplayName;
            Parents = data.Parents;
            Data = data.Data;
            IsAutoAssigned = data.IsAutoAssigned;
            Permissions = data.Permissions;
        }

        public static implicit operator PermissionGroup(PermissionGroupData data)
        {
            return new PermissionGroup(data);
        }

        public static implicit operator PermissionGroupData(PermissionGroup group)
        {
            return new PermissionGroupData
            {
                Id = group.Id,
                Priority = group.Priority,
                DisplayName = group.DisplayName,
                Parents = (List<string>) @group.Parents,
                Data = group.Data,
                IsAutoAssigned = group.IsAutoAssigned,
                Permissions = group.Permissions
            };
        }

        public string Id { get; }
        public int Priority { get; set; }
        public string DisplayName { get; }
        public ICollection<string> Parents { get; }
        public List<string> Permissions { get; }
        public bool IsAutoAssigned { get; set; }
        public Dictionary<string, object> Data { get; }
        public string Type { get; } = "group";
    }
}