// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class ConnectionAliasFactory(string resourceName = null, Action<Humidifier.WorkSpaces.ConnectionAlias> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.ConnectionAlias>(resourceName)
{

    protected override Humidifier.WorkSpaces.ConnectionAlias Create()
    {
        var connectionAliasResult = CreateConnectionAlias();
        factoryAction?.Invoke(connectionAliasResult);

        return connectionAliasResult;
    }

    private Humidifier.WorkSpaces.ConnectionAlias CreateConnectionAlias()
    {
        var connectionAliasResult = new Humidifier.WorkSpaces.ConnectionAlias
        {
            GivenName = InputResourceName,
        };

        return connectionAliasResult;
    }

} // End Of Class

public static class ConnectionAliasFactoryExtensions
{
}
