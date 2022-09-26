using System;

namespace Library;

public class  Singleton<T> where T : new()
{
    private Singleton()
    {

    }
    private static T singletonInstance;
    public static T SingletonInstance
    {
        get
        {
            if (singletonInstance == null)
            {
                singletonInstance = new T();
            }

            return singletonInstance;
        }
    }

}