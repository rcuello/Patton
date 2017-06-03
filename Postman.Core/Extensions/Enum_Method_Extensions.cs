using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Postman.Core
{
    public static class Enum_Method_Extensions
    {
        public static TAttribute Attribute<TAttribute>(this System.Enum value)
        where TAttribute : Attribute
        {
            TAttribute tAttribute;
            if (!(value.ToString() == "0"))
            {
                TAttribute tAttribute1 = value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(true).OfType<TAttribute>().First<TAttribute>();
                tAttribute = tAttribute1;
            }
            else
            {
                tAttribute = default(TAttribute);
            }
            return tAttribute;
        }

        public static string Display(this System.Enum value)
        {
            string empty;
            if (!(value.ToString() == "0"))
            {
                IEnumerable<DisplayAttribute> displayAttributes = value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(true).OfType<DisplayAttribute>();
                empty = (displayAttributes.Count<DisplayAttribute>() <= 0 ? string.Empty : displayAttributes.First<DisplayAttribute>().Name);
            }
            else
            {
                empty = string.Empty;
            }
            return empty;
        }

        public static TEnum FromInt<TEnum>(int value)
        where TEnum : struct, IConvertible
        {
            return (TEnum)System.Enum.Parse(typeof(TEnum), value.ToString());
        }

        public static TEnum FromString<TEnum>(string value)
        {
            return (TEnum)System.Enum.Parse(typeof(TEnum), value);
        }

        public static string GetEnumDescription(this System.Enum value)
        {
            string str;
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] customAttributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            str = ((customAttributes == null ? true : (int)customAttributes.Length <= 0) ? value.ToString() : customAttributes[0].Description);
            return str;
        }

        public static IEnumerable<dynamic> ToDataSource<TEnum>()
        where TEnum : struct, IConvertible
        {
            IEnumerable<object> objs = System.Enum.GetValues(typeof(TEnum)).Cast<object>();
            IEnumerable<object> objs1 =
                from value in objs
                where value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(true).OfType<IgnoreDataMemberAttribute>().Count<IgnoreDataMemberAttribute>() == 0
                select new { Value = value, Description = value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(true).OfType<DisplayAttribute>().First<DisplayAttribute>().Name };
            return objs1;
        }

        /// <summary>
        /// To the key value pairs.
        /// </summary>
        /// <param name="enumType">Type of the enum defined by GetType.</param>
        /// <returns>A list of Key Value pairs</returns>
        public static List<KeyValuePair<int, string>> ToKeyValuePairs(this System.Enum enumType)
        {
            var pairs = new List<KeyValuePair<int, string>>();

            var names = System.Enum.GetNames(enumType.GetType());
            var values = System.Enum.GetValues(enumType.GetType());
            for (var i = 0; i < values.Length; i++)
            {
                pairs.Add(new KeyValuePair<int, string>((int)values.GetValue(i), names[i]));
            }
            return pairs;
        }

        public static IEnumerable<T> GetValues<T>()
        {
            return System.Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
