using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDal
{
     public class SystemSettingsService
    {
        private SystemSettings _settings;

        public SystemSettingsService()
        {
            _settings = new SystemSettings();
        }
        public SystemSettings GetSettings()
        {
            return _settings;
        }
        public void SaveSettings(SystemSettings settings)
        {
            _settings = settings;
        }
    }
}
