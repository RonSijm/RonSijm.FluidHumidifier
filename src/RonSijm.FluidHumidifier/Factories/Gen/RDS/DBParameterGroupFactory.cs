// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBParameterGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBParameterGroup>(resourceName)
{

    protected override Humidifier.RDS.DBParameterGroup Create()
    {
        var dBParameterGroupResult = CreateDBParameterGroup();
        factoryAction?.Invoke(dBParameterGroupResult);

        return dBParameterGroupResult;
    }

    private Humidifier.RDS.DBParameterGroup CreateDBParameterGroup()
    {
        var dBParameterGroupResult = new Humidifier.RDS.DBParameterGroup
        {
            GivenName = InputResourceName,
        };

        return dBParameterGroupResult;
    }

} // End Of Class

public static class DBParameterGroupFactoryExtensions
{
}
