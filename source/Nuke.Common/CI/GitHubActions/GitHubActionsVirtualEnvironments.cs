// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.CI.GitHubActions
{
    [PublicAPI]
    public enum GitHubActionsVirtualEnvironments
    {
        WindowsServer2019,
        WindowsServer2016R2,
        Ubuntu1804,
        Ubuntu1604,
        MacOs1014,
        WindowsLatest = WindowsServer2019,
        UbuntuLatest = Ubuntu1804,
        MacOsLatest = MacOs1014
    }
}
