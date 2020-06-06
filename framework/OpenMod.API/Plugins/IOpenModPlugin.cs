﻿using System.Threading.Tasks;
using Semver;

namespace OpenMod.API.Plugins
{
    public interface IOpenModPlugin : IOpenModComponent
    {
        string DisplayName { get; }

        string Author { get; }

        SemVersion Version { get; }

        Task LoadAsync();

        Task UnloadAsync();
    }
}