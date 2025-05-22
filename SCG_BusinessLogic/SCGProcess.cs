using SCG_Common;
using SCG_DataLogic;

namespace SCG_BusinessLogic
{
    public static class SCGProcess
    {
        public static int FindOutSkinType(bool oilySkin, bool drySkin, bool sensitiveSkin, bool normalSkin)
        {
            if (oilySkin && !drySkin && !sensitiveSkin)
                return (int) SkinType.Oily;
            if (!oilySkin && drySkin && !sensitiveSkin)
                return (int) SkinType.Dry;
            if (sensitiveSkin)
                return (int) SkinType.Sensitive;
            if (normalSkin)
                return (int) SkinType.Normal;

            return (int) SkinType.Combination; //if combination skin
        }
        
        public static string GetSkinTypeName(int skinType)
        {
            if(Enum.IsDefined(typeof(SkinType), skinType))
            {
                return ((SkinType)skinType).ToString();
            }
            return "Unknown";
        }
    }
}