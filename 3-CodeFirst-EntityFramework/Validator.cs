using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_CodeFirst_EntityFramework
{
    public static class Validator
    {
        public static bool  IsNullOrEmpty(TextBox Tbx, string fieldName)
        {
            if (string.IsNullOrEmpty(Tbx.Text?.Trim()))
            {
                MessageBox.Show($" {fieldName} Cannot Be Blank.", "Missing Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
