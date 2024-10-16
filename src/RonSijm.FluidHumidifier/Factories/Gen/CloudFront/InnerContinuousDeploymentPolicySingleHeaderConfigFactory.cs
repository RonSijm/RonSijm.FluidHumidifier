// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerContinuousDeploymentPolicySingleHeaderConfigFactory(Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig>
{

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig Create()
    {
        var singleHeaderConfigResult = CreateSingleHeaderConfig();
        factoryAction?.Invoke(singleHeaderConfigResult);

        return singleHeaderConfigResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig CreateSingleHeaderConfig()
    {
        var singleHeaderConfigResult = new Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig();

        return singleHeaderConfigResult;
    }

} // End Of Class

public static class InnerContinuousDeploymentPolicySingleHeaderConfigFactoryExtensions
{
}
