// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunRetryPolicyConfigurationFactory(Action<Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration>
{

    protected override Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration Create()
    {
        var retryPolicyConfigurationResult = CreateRetryPolicyConfiguration();
        factoryAction?.Invoke(retryPolicyConfigurationResult);

        return retryPolicyConfigurationResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration CreateRetryPolicyConfiguration()
    {
        var retryPolicyConfigurationResult = new Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration();

        return retryPolicyConfigurationResult;
    }

} // End Of Class

public static class InnerJobRunRetryPolicyConfigurationFactoryExtensions
{
}
