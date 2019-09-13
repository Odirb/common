// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.Common.Utilities;

namespace Nuke.Common.CI.GitHubActions.Configuration
{
    public class GitHubActionsUsingStep : GitHubActionsStep
    {
        public string Using { get; set; }

        public override void Write(CustomFileWriter writer)
        {
            writer.WriteLine($"- uses: {Using}");
        }
    }
}
