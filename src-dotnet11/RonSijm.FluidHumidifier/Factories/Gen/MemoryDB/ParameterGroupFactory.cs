// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class ParameterGroupFactory(string resourceName = null, Action<Humidifier.MemoryDB.ParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.ParameterGroup>(resourceName)
{

    protected override Humidifier.MemoryDB.ParameterGroup Create()
    {
        var parameterGroupResult = CreateParameterGroup();
        factoryAction?.Invoke(parameterGroupResult);

        return parameterGroupResult;
    }

    private Humidifier.MemoryDB.ParameterGroup CreateParameterGroup()
    {
        var parameterGroupResult = new Humidifier.MemoryDB.ParameterGroup
        {
            GivenName = InputResourceName,
        };

        return parameterGroupResult;
    }

} // End Of Class

public static class ParameterGroupFactoryExtensions
{
}
