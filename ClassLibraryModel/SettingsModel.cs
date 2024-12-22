using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
        public class SettingsModel
        {
            public string Theme { get; set; } = "Light";
            public string Language { get; set; } = "en-US";
            public int ItemsPerPage { get; set; } = 10;
            public bool EnableAutoSave { get; set; } = true;
            public int AutoSaveInterval { get; set; } = 30;
            public bool EmailNotifications { get; set; } = true;
            public bool PushNotifications { get; set; } = true;
        }
    }

