using System.Collections.Generic;

namespace P6
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        private const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string,string>> _Preferences = new Dictionary<string, Dictionary<string,string>>();

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if (_Preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            return value;
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> NameValuePair;
            // Does the user have preferences defined?
            if (_Preferences.TryGetValue(UserName, out NameValuePair))
            {
                // If so, is there an entry for this preference name?
                if (NameValuePair.ContainsKey(PreferenceName))
                {
                    NameValuePair[PreferenceName] = Value;
                }
                else
                {
                    // no entry for this preference name
                    // Add an entry for this preference name
                    NameValuePair.Add(PreferenceName, Value);
                }
                _Preferences[UserName] = NameValuePair;
            }
            else
            {
                // no preference yet for this user
                // Add user and preference
                NameValuePair = new Dictionary<string, string>(); 
                NameValuePair.Add(PreferenceName, Value);
                _Preferences.Add(UserName, NameValuePair);
            }            
            return NO_ERROR;
        }
    }
}
