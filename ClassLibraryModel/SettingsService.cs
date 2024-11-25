using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel;

public class SettingsService
{
    private SystemSettings settings = new SystemSettings(); // Replace with actual initialization

    public SystemSettings GetSettings()
    {
        // Logic to fetch settings
        return settings;
    }

    public void SaveSettings(SystemSettings updatedSettings)
    {
        // Logic to save settings
        settings = updatedSettings;
    }
}

