// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class DBClusterParameterGroupFactory(string resourceName = null, Action<Humidifier.DocDB.DBClusterParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.DocDB.DBClusterParameterGroup>(resourceName)
{

    protected override Humidifier.DocDB.DBClusterParameterGroup Create()
    {
        var dBClusterParameterGroupResult = CreateDBClusterParameterGroup();
        factoryAction?.Invoke(dBClusterParameterGroupResult);

        return dBClusterParameterGroupResult;
    }

    private Humidifier.DocDB.DBClusterParameterGroup CreateDBClusterParameterGroup()
    {
        var dBClusterParameterGroupResult = new Humidifier.DocDB.DBClusterParameterGroup
        {
            GivenName = InputResourceName,
        };

        return dBClusterParameterGroupResult;
    }

} // End Of Class

public static class DBClusterParameterGroupFactoryExtensions
{
}
