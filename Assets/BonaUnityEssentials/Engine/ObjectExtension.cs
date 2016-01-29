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
}
