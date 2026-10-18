// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class DBParameterGroupFactory(string resourceName = null, Action<Humidifier.Neptune.DBParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.Neptune.DBParameterGroup>(resourceName)
{

    protected override Humidifier.Neptune.DBParameterGroup Create()
    {
        var dBParameterGroupResult = CreateDBParameterGroup();
        factoryAction?.Invoke(dBParameterGroupResult);

        return dBParameterGroupResult;
    }

    private Humidifier.Neptune.DBParameterGroup CreateDBParameterGroup()
    {
        var dBParameterGroupResult = new Humidifier.Neptune.DBParameterGroup
        {
            GivenName = InputResourceName,
        };

        return dBParameterGroupResult;
    }

} // End Of Class

public static class DBParameterGroupFactoryExtensions
{
}
