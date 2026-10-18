// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceVpcConfigurationFactory(Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration>
{

    protected override Humidifier.Grafana.WorkspaceTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.Grafana.WorkspaceTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerWorkspaceVpcConfigurationFactoryExtensions
{
}
