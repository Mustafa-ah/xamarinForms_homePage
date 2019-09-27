using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinistryApp.Extentions
{
    public static class GeneralExtentions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this List<T> items)
        {
            var collection = new ObservableCollection<T>();
            foreach (var item in items)
                collection.Add(item);
            return collection;
        }
    }
}
