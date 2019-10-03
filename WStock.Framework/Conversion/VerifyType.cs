using System;
using System.Collections.Generic;

namespace WStock.Framework.Conversion
{
    public static class VerifyType
    {
        public static List<Type> GetListTypePrimitive()
        {
            var List = new List<Type>();
            List.Add(typeof(string));
            List.Add(typeof(bool));
            List.Add(typeof(DateTime));
            List.Add(typeof(int));
            List.Add(typeof(long));
            List.Add(typeof(decimal));
            List.Add(typeof(float));
            List.Add(typeof(double));
            List.Add(typeof(byte));
            List.Add(typeof(char));
            List.Add(typeof(sbyte));
            List.Add(typeof(ushort));
            List.Add(typeof(uint));
            List.Add(typeof(ulong));
            return List;
        }      

        public static object ConvertProperty(string property, object value, Type typeObject)
        {
            var typeProperty = typeObject.GetProperty(property).PropertyType;

            if (typeProperty == typeof(string))
            {
                return Convert.ToString(value);
            }
            if (typeProperty == typeof(bool))
            {
                return Convert.ToBoolean(value);
            }
            if (typeProperty == typeof(DateTime))
            {
                return Convert.ToDateTime(value);
            }
            if (typeProperty == typeof(short))
            {
                return Convert.ToInt16(value);
            }
            if (typeProperty == typeof(int))
            {
                return Convert.ToInt32(value);
            }
            if (typeProperty == typeof(long))
            {
                return Convert.ToInt64(value);
            }
            if (typeProperty == typeof(decimal)
                || typeProperty == typeof(float))
            {
                return Convert.ToDecimal(value);
            }
            if (typeProperty == typeof(double))
            {
                return Convert.ToDouble(value);
            }
            if (typeProperty == typeof(byte))
            {
                return Convert.ToByte(value);
            }
            if (typeProperty == typeof(char))
            {
                return Convert.ToChar(value);
            }
            if (typeProperty == typeof(sbyte))
            {
                return Convert.ToSByte(value);
            }
            if (typeProperty == typeof(ushort))
            {
                return Convert.ToUInt16(value);
            }
            if (typeProperty == typeof(uint))
            {
                return Convert.ToUInt32(value);
            }
            if (typeProperty == typeof(ulong))
            {
                return Convert.ToUInt64(value);
            }
            return value;
        }

        public static object ParseStringToPrimitiveType(object obj)
        {            
            try
            {
                var objeto = obj.ToString();
                if (IsNumeric(objeto)) //Verifica se é numerico
                {
                    objeto = objeto.Replace(".", ",");
                    if ((decimal.Parse(objeto) - decimal.Truncate(decimal.Parse(objeto)))>0) //Verifica se é decimal
                    {
                        return decimal.Parse(objeto.ToString());
                    }
                    else //Verifica se é inteiro
                    {
                        return long.Parse(objeto.ToString());
                    }
                }
                else if (IsDateTime(objeto)) //Verifica se é data
                {
                    return DateTime.Parse(objeto.ToString());
                }
                else //Se não for nenhum retorna o objeto que entrou
                {
                    return objeto;
                }
            }
            catch
            {
                return obj;
            }            
        }

        public static bool IsNumeric(string value)
        {
            try
            {
                decimal.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsDateTime(string value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
