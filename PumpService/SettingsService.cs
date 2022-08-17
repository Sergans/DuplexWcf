using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PumpService
{
    public class SettingsService : ISettingsService
    {
        public SettingsService()
        {
            FileName = @"C:\scripts\Sample.script";
        }

        public string FileName { get; set; }
    }
}