using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        const string PREFERENCE_PROJECT_ID = "Project_Id";
        const string PREFERENCE_PROJECT_NAME = "Project_Name";
        const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> preferences;

        public FakePreferenceRepository()
        {
            if (preferences == null)
            {
                preferences = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> userPreferences = new Dictionary<string, string>();
            string preference = "";

            if(preferences.TryGetValue(UserName, out userPreferences)){
                userPreferences.TryGetValue(PreferenceName, out preference);
            }
            return preference;
        }

        // This should probably remove the previous preference idk...
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, string> userPreferences = new Dictionary<string, string>();

            if (preferences.TryGetValue(UserName, out userPreferences))
            {
                userPreferences.Add(PreferenceName, Value);
            }

            return NO_ERROR;
        }
    }
}
