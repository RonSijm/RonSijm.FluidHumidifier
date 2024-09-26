// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerContinuousDeploymentPolicySessionStickinessConfigFactory(Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig>
{

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig Create()
    {
        var sessionStickinessConfigResult = CreateSessionStickinessConfig();
        factoryAction?.Invoke(sessionStickinessConfigResult);

        return sessionStickinessConfigResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig CreateSessionStickinessConfig()
    {
        var sessionStickinessConfigResult = new Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig();

        return sessionStickinessConfigResult;
    }

} // End Of Class

public static class InnerContinuousDeploymentPolicySessionStickinessConfigFactoryExtensions
{
}
