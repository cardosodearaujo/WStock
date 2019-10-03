using System;

namespace WStock.Framework.Enums
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class EnumDescription : Attribute
    {
        public Type ResourceType { get; private set; }

        public EnumDescription(Type resourceType)
        {
            this.ResourceType = resourceType;
        }
    }
}
