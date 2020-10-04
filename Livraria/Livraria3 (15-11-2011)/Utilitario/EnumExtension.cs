using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace Livraria.Utilitario
{
    public class EnumItem
    {
        public string Description { get; set; }
        public string Value { get; set; }
    }

    public static class ExtendedMethods
    {
        public static string ObterDescricao(this Enum enumvalue)
        {
            Type type = enumvalue.GetType();

            MemberInfo[] memInfo = type.GetMember(enumvalue.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {

                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute),false);

                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;

            }

            return enumvalue.ToString();
        }

        public static List<EnumItem> ObterDescricoes(this Enum enumeracao)
        {
            Type enumType = enumeracao.GetType();
            Array enumValues = Enum.GetValues(enumType);

            List<EnumItem> enumItems = new List<EnumItem>();
            for (int i = 0; i < enumValues.Length; i++)
            {
                enumItems.Add(new EnumItem()
                {
                    Value = enumValues.GetValue(i).ToString(),
                    Description = ObterDescricao((Enum)enumValues.GetValue(i)),
                });
            }

            return enumItems;
        }
    }
}
