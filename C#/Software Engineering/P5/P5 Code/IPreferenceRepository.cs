using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public interface IPreferenceRepository
    {
        string GetPreference(string UserName, string PreferenceName);
        string SetPreference(string UserName, string PreferenceName, string Value);
    }
}
