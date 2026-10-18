// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceNetworkAccessControlFactory(Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl>
{

    protected override Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl Create()
    {
        var networkAccessControlResult = CreateNetworkAccessControl();
        factoryAction?.Invoke(networkAccessControlResult);

        return networkAccessControlResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl CreateNetworkAccessControl()
    {
        var networkAccessControlResult = new Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl();

        return networkAccessControlResult;
    }

} // End Of Class

public static class InnerWorkspaceNetworkAccessControlFactoryExtensions
{
}
