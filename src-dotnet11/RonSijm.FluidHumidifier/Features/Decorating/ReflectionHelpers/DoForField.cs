namespace RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;

public static class DoForField
{
    public static void DoForAllFields<T>(this object target, Action<T> action, bool recursive = true)
    {
        DoForFields(target, action, recursive, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }

    public static void DoForPublicFields<T>(this object target, Action<T> action, bool recursive = true)
    {
        DoForFields(target, action, recursive, BindingFlags.Instance | BindingFlags.Public);
    }

    public static void DoForFields<T>(this object target, Action<T> action, bool recursive, BindingFlags bindingFlags)
    {
        var targetType = target.GetType();
        var fields = targetType.GetFields(bindingFlags);

        foreach (var field in fields)
        {
            var value = field.GetValue(target); // Directly use field value

            if (value is T typedItem)
            {
                action.Invoke(typedItem);

                if (recursive)
                {
                    DoForFields(typedItem, action, true, bindingFlags);
                }
            }

            if (value is not IEnumerable<T> decoratorsEnumerable)
            {
                continue;
            }

            foreach (var childItem in decoratorsEnumerable)
            {
                action.Invoke(childItem);

                if (recursive)
                {
                    DoForFields(childItem, action, true, bindingFlags);
                }
            }
        }
    }
}