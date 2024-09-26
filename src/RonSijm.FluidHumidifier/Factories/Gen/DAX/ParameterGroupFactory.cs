// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DAX;

public class ParameterGroupFactory(string resourceName = null, Action<Humidifier.DAX.ParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.DAX.ParameterGroup>(resourceName)
{

    protected override Humidifier.DAX.ParameterGroup Create()
    {
        var parameterGroupResult = CreateParameterGroup();
        factoryAction?.Invoke(parameterGroupResult);

        return parameterGroupResult;
    }

    private Humidifier.DAX.ParameterGroup CreateParameterGroup()
    {
        var parameterGroupResult = new Humidifier.DAX.ParameterGroup
        {
            GivenName = InputResourceName,
        };

        return parameterGroupResult;
    }

} // End Of Class

public static class ParameterGroupFactoryExtensions
{
}
