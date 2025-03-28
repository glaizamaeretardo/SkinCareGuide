using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinCareGuide_BDLogic
{
    public class SCGProcess
    {
        public static void SaveUserDetails(Dictionary<string, string> savedReference, string name, int skinType)
        {
            string STCategory = GetSkinTypeName(skinType);
            savedReference[name] = STCategory;
        }

        public static string GetSkinTypeName(int skinType)
        {
            return skinType switch
            {
                1 => "OILY",
                2 => "DRY",
                3 => "SENSITIVE",
                4 => "COMBINATION",
                5 => "NORMAL",
                _ => "UNKNOWN SKIN TYPE"
            };
        }

        public static int FindOutSkinType(bool oilySkin, bool drySkin, bool sensitiveSkin, bool normalSkin)
        {
            if (oilySkin && !drySkin && !sensitiveSkin)
                return 1;
            if (!oilySkin && drySkin && !sensitiveSkin)
                return 2;
            if (sensitiveSkin)
                return 3;
            if (normalSkin)
                return 5;
            return 4; //for combination
        }
    }
}