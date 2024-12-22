using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDal
{
    public class SettingsService
    {
        private SettingsModel _settings = new();

        public Task<SettingsModel> GetSettingsAsync()
        {
            // Mock returning stored settings
            return Task.FromResult(_settings);
        }

        public Task SaveSettingsAsync(SettingsModel settings)
        {
            _settings = settings;
            // Save settings to database or file (omitted for simplicity)
            return Task.CompletedTask;
        }
    }

}
