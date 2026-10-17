// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationMetricsConfigurationPolicyFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy Create()
    {
        var metricsConfigurationPolicyResult = CreateMetricsConfigurationPolicy();
        factoryAction?.Invoke(metricsConfigurationPolicyResult);

        return metricsConfigurationPolicyResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy CreateMetricsConfigurationPolicy()
    {
        var metricsConfigurationPolicyResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.MetricsConfigurationPolicy();

        return metricsConfigurationPolicyResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationMetricsConfigurationPolicyFactoryExtensions
{
}
