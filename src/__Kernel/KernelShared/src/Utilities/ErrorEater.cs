namespace KernelShared.Utilities;
public static class ErrorEater
{
    /// <summary>
    /// returns true if there was an error
    /// </summary>
    public static bool IgnoreErrors(Action operation)
    {
        if (operation == null)
            return false;
        try
        {
            operation.Invoke();
        }
        catch
        {
            return true;
        }

        return false;
    }

    public static T IgnoreErrors<T>(Func<T> operation, T defaultValue = default(T))
    {
        if (operation == null)
            return defaultValue;

        T result;
        try
        {
            result = operation.Invoke();
        }
        catch
        {
            result = defaultValue;
        }

        return result;
    }
}

// credit Rick Strahl