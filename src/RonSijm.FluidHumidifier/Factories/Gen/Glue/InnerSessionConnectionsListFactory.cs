// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSessionConnectionsListFactory(Action<Humidifier.Glue.SessionTypes.ConnectionsList> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SessionTypes.ConnectionsList>
{

    protected override Humidifier.Glue.SessionTypes.ConnectionsList Create()
    {
        var connectionsListResult = CreateConnectionsList();
        factoryAction?.Invoke(connectionsListResult);

        return connectionsListResult;
    }

    private Humidifier.Glue.SessionTypes.ConnectionsList CreateConnectionsList()
    {
        var connectionsListResult = new Humidifier.Glue.SessionTypes.ConnectionsList();

        return connectionsListResult;
    }

} // End Of Class

public static class InnerSessionConnectionsListFactoryExtensions
{
}
