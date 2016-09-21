using UnityEngine;
using System;
using System.Collections;

public static class ObjectExtension
{
    public static T To<T>(this object o)
    {
        return (T)o;
    }

    public static T ToOrDefault<T>(this object o)
    {
        try {
            return (T)o;
        } catch (Exception) {
            return default(T);
        }
    }

    public static bool In<T>(this T item, params T[]items)
    {
		if(items == null){
			throw new ArgumentNUllException();
		}
		
		return items.Contains(item);
    }
}
