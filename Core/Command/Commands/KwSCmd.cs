using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commands
{
    [Command(Name = "kwscli", OptionsComparison = StringComparison.InvariantCultureIgnoreCase)]
    [VersionOptionFromMember("--version", MemberName = nameof(GetVersion))]
    public class KwSCmd
    {
    }
}
