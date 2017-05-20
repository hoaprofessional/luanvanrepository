using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Common.App_LocalResources;

namespace Common
{
    public class FieldHelper
    {
        public static readonly FieldHelper Instance = new FieldHelper();
        public String GetValueLangRes(String langName)
        {
            dynamic value = typeof(GlobalRes).GetMember(langName).GetValue(0);
            return value.GetValue(null);
        }
    }
}
