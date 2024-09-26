// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class DBClusterParameterGroupFactory(string resourceName = null, Action<Humidifier.Neptune.DBClusterParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.Neptune.DBClusterParameterGroup>(resourceName)
{

    protected override Humidifier.Neptune.DBClusterParameterGroup Create()
    {
        var dBClusterParameterGroupResult = CreateDBClusterParameterGroup();
        factoryAction?.Invoke(dBClusterParameterGroupResult);

        return dBClusterParameterGroupResult;
    }

    private Humidifier.Neptune.DBClusterParameterGroup CreateDBClusterParameterGroup()
    {
        var dBClusterParameterGroupResult = new Humidifier.Neptune.DBClusterParameterGroup
        {
            GivenName = InputResourceName,
        };

        return dBClusterParameterGroupResult;
    }

} // End Of Class

public static class DBClusterParameterGroupFactoryExtensions
{
}
