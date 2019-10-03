using System;

namespace WStock.Framework.Bases
{
    [Serializable]
    public abstract class BaseModel
    {
        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();
    }
}
