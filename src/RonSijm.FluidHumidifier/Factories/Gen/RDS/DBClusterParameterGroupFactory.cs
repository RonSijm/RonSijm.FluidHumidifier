// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBClusterParameterGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBClusterParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBClusterParameterGroup>(resourceName)
{

    protected override Humidifier.RDS.DBClusterParameterGroup Create()
    {
        var dBClusterParameterGroupResult = CreateDBClusterParameterGroup();
        factoryAction?.Invoke(dBClusterParameterGroupResult);

        return dBClusterParameterGroupResult;
    }

    private Humidifier.RDS.DBClusterParameterGroup CreateDBClusterParameterGroup()
    {
        var dBClusterParameterGroupResult = new Humidifier.RDS.DBClusterParameterGroup
        {
            GivenName = InputResourceName,
        };

        return dBClusterParameterGroupResult;
    }

} // End Of Class

public static class DBClusterParameterGroupFactoryExtensions
{
}
