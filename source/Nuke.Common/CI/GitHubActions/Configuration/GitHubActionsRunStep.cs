// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Common.CI.GitHubActions.Configuration
{
    public class GitHubActionsRunStep : GitHubActionsStep
    {
        public string Command { get; set; }
        public Dictionary<string, string> Imports { get; set; }

        public override void Write(CustomFileWriter writer)
        {
            writer.WriteLine($"- name: Run {Command}");
            writer.WriteLine($"  run: {Command}");

            if (Imports.Count > 0)
            {
                using (writer.Indent())
                {
                    writer.WriteLine("env:");
                    Imports.ForEach(x => writer.WriteLine($"  {x.Key}: {x.Value}"));
                }
            }
        }
    }
}
