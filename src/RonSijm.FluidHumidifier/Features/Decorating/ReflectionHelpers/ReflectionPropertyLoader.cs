namespace RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;

public static class ReflectionPropertyLoader
{
    public static List<PropertyInfo> GetPropertiesOrListPropertiesOf(this PropertyInfo[] properties, Type targetType)
    {
        var matchingProperties = properties.Where(p =>
        {
            var propertyType = p.PropertyType;

            if (!propertyType.IsGenericType)
            {
                return targetType.IsAssignableFrom(propertyType);
            }

            var genericArguments = propertyType.GetGenericArguments();

            if (genericArguments.Length == 1 && targetType.IsAssignableFrom(genericArguments[0]))
            {
                return true;
            }

            return targetType.IsAssignableFrom(propertyType);
        }).ToList();

        return matchingProperties;
    }
}