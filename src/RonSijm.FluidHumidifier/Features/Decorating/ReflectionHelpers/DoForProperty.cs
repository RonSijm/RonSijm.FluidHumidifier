namespace RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;

public static class DoForProperty
{
    public static void DoForAllProperties<T>(this object target, Action<T> action, bool recursive = true)
    {
        DoForProperties(target, action, recursive, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }

    public static void DoForPublicProperties<T>(this object target, Action<T> action, bool recursive = true)
    {
        DoForProperties(target, action, recursive, BindingFlags.Instance | BindingFlags.Public);
        
    }

    public static void DoForProperties<T>(this object target, Action<T> action, bool recursive, BindingFlags bindingFlags)
    {
        var targetType = target.GetType();
        var properties = targetType.GetProperties(bindingFlags);

        var stackProperties = properties.GetPropertiesOrListPropertiesOf(typeof(T));

        foreach (var property in properties)
        {
            var value = property.GetValue(target);

            if (value is T typedItem)
            {
                action.Invoke(typedItem);

                if (recursive)
                {
                    DoForProperties(typedItem, action, true, bindingFlags);
                }
            }

            if (value is not IEnumerable<T> decoratorsEnumerable)
            {
                continue;
            }

            foreach (var childFactory in decoratorsEnumerable)
            {
                action.Invoke(childFactory);

                if (recursive)
                {
                    DoForProperties(childFactory, action, true, bindingFlags);
                }
            }
        }
    }
}