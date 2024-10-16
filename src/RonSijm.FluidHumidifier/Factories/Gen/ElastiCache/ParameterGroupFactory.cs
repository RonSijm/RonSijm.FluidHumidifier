// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class ParameterGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.ParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.ParameterGroup>(resourceName)
{

    protected override Humidifier.ElastiCache.ParameterGroup Create()
    {
        var parameterGroupResult = CreateParameterGroup();
        factoryAction?.Invoke(parameterGroupResult);

        return parameterGroupResult;
    }

    private Humidifier.ElastiCache.ParameterGroup CreateParameterGroup()
    {
        var parameterGroupResult = new Humidifier.ElastiCache.ParameterGroup
        {
            GivenName = InputResourceName,
        };

        return parameterGroupResult;
    }

} // End Of Class

public static class ParameterGroupFactoryExtensions
{
}
