// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Common.CI.GitHubActions.Configuration
{
    public class GitHubActionsVcsTrigger : GitHubActionsTrigger
    {
        public GitHubActionsOn Kind { get; set; }
        public string[] Branches { get; set; }
        public string[] Tags { get; set; }
        public string[] IncludePaths { get; set; }
        public string[] ExcludePaths { get; set; }

        public override void Write(CustomFileWriter writer)
        {
            writer.WriteLine(ConvertToString(Kind));

            using (writer.Indent())
            {
                if (Branches != null)
                {
                    writer.WriteLine("branches:");
                    Branches.ForEach(x => writer.WriteLine($"  - {x}"));
                }

                if (Tags != null)
                {
                    writer.WriteLine("tags:");
                    Tags.ForEach(x => writer.WriteLine($"  - {x}"));
                }

                if (IncludePaths != null || ExcludePaths != null)
                {
                    writer.WriteLine("paths:");
                    (IncludePaths ?? new string[0]).ForEach(x => writer.WriteLine($"  - {x}"));
                    (ExcludePaths ?? new string[0]).ForEach(x => writer.WriteLine($"  - !{x}"));
                }
            }
        }
    }
}
