using System;
using System.Linq;
using System.Resources;
using System.Threading;

namespace WStock.Framework.Enums
{
    public static class EnumUtility
        {
            private const Int16 ENUM_LENGTH = 1;
            private const Int16 ENUM_POSITION = 0;

            public static String GetDescription(this Enum item)
            {
                EnumDescription[] description = (EnumDescription[])item.GetType().GetCustomAttributes(typeof(EnumDescription), false);

                if (description.Length == ENUM_LENGTH)
                {
                    ResourceManager resourceManager = new ResourceManager(description[ENUM_POSITION].ResourceType);
                    String message = resourceManager.GetString(item.ToString(), Thread.CurrentThread.CurrentCulture);
                    return (!String.IsNullOrEmpty(message) ? message : String.Empty);
                }

                return String.Empty;
            }

           
            public static object GetValue(this Enum item)
            {
                EnumValue[] enumValue = (EnumValue[])item.GetType().GetField(item.ToString()).GetCustomAttributes(typeof(EnumValue), false);

                if (enumValue.Length == ENUM_LENGTH)
                {
                    return enumValue[ENUM_POSITION].Value;
                }

                return null;
            }

            
            public static Enum GetEnumByValue<T>(String value)
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                var enumTexts = typeof(T).GetEnumValues();

                foreach (var enumText in enumTexts)
                {
                    var enumValue = (EnumValue[])enumText.GetType().GetField(enumText.ToString()).GetCustomAttributes(typeof(EnumValue), false);

                    if (enumValue.Count() > 0 &&
                        enumValue.Where(i => i.Value.ToString() == value).FirstOrDefault() != null)
                    {
                        return (Enum)enumText;
                    }
                }

                return null;
            }
        
           
            public static String GetDescriptionByValue<T>(String value)
            {
                var enumElement = GetEnumByValue<T>(value);

                if (enumElement == null)
                {
                    return null;
                }

                return enumElement.GetDescription();
            }
        }
    
}
