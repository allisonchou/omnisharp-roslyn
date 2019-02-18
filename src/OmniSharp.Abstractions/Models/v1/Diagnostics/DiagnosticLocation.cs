﻿using System.Collections.Generic;

namespace OmniSharp.Models.Diagnostics
{
    public class DiagnosticLocation : QuickFix
    {
        public string LogLevel { get; set; }
        public string Id { get; set; }
        public string[] Tags { get; set; }
    }
}
