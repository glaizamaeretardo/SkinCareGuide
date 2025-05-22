using SCG_DataLogic;

namespace SCG_BusinessLogic
{
    public static class SCGProcess
    {
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

            return 4; //if combination skin
        }
        
        public static string GetSkinTypeName(int skinType)
        {
            return skinType switch
            {
                1 => "Oily",
                2 => "Dry",
                3 => "Sensitive",
                4 => "Combination (Oily + Dry)",
                5 => "Normal",
                _ => "Unknown"
            };
        }
    }
}