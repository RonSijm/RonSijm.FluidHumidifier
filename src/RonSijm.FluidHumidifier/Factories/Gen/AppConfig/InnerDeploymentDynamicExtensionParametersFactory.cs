// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerDeploymentDynamicExtensionParametersFactory(Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters>
{

    protected override Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters Create()
    {
        var dynamicExtensionParametersResult = CreateDynamicExtensionParameters();
        factoryAction?.Invoke(dynamicExtensionParametersResult);

        return dynamicExtensionParametersResult;
    }

    private Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters CreateDynamicExtensionParameters()
    {
        var dynamicExtensionParametersResult = new Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters();

        return dynamicExtensionParametersResult;
    }

} // End Of Class

public static class InnerDeploymentDynamicExtensionParametersFactoryExtensions
{
}
