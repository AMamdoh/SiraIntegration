using SiraIntegration.Data.Enums;
using SiraIntegration.Helpers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Helpers
{
    public static class EnumHelper
    {
        public static IEnumerable<SelectListItemViewModel> ToSelectableList<T>(params T[] exludedValues)
        {
            return
            (from item in Enum.GetValues(typeof(T)).Cast<T>().Select(x => x).ToList()
             where !exludedValues.Contains(item)
             select new SelectListItemViewModel
             {
                 ID = Convert.ToInt32(item),
                 Name = item.ToString(),
             });
        }

        public static int GetEnumIndexFromName<T>(this string value) where T : struct
        {
            return Enum.TryParse<T>(value, out var result)
                ? Convert.ToInt32(result)
                : -1;
        }
    }

}
