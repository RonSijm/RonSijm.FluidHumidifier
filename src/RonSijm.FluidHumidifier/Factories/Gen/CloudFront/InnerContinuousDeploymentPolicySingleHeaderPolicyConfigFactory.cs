// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerContinuousDeploymentPolicySingleHeaderPolicyConfigFactory(Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig>
{

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig Create()
    {
        var singleHeaderPolicyConfigResult = CreateSingleHeaderPolicyConfig();
        factoryAction?.Invoke(singleHeaderPolicyConfigResult);

        return singleHeaderPolicyConfigResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig CreateSingleHeaderPolicyConfig()
    {
        var singleHeaderPolicyConfigResult = new Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig();

        return singleHeaderPolicyConfigResult;
    }

} // End Of Class

public static class InnerContinuousDeploymentPolicySingleHeaderPolicyConfigFactoryExtensions
{
}
