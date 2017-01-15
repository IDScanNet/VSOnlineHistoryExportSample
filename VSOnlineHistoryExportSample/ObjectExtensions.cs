using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VSOnlineHistoryExportSample
{
    public static class ObjectExtensions
    {
        public static Dictionary<string, object> ToDictionary(this object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            var dictionary = new Dictionary<string, object>();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(obj))
            {
                object value = propertyDescriptor.GetValue(obj);
                dictionary.Add(propertyDescriptor.Name, value);
            }
            return dictionary;
        }
    }
}