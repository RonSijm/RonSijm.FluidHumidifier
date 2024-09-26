// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerJobConnectionsListFactory(Action<Humidifier.Glue.JobTypes.ConnectionsList> factoryAction = null) : SubResourceFactory<Humidifier.Glue.JobTypes.ConnectionsList>
{

    protected override Humidifier.Glue.JobTypes.ConnectionsList Create()
    {
        var connectionsListResult = CreateConnectionsList();
        factoryAction?.Invoke(connectionsListResult);

        return connectionsListResult;
    }

    private Humidifier.Glue.JobTypes.ConnectionsList CreateConnectionsList()
    {
        var connectionsListResult = new Humidifier.Glue.JobTypes.ConnectionsList();

        return connectionsListResult;
    }

} // End Of Class

public static class InnerJobConnectionsListFactoryExtensions
{
}
