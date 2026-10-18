// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationJobComputePaymentConfigFactory(Action<Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig Create()
    {
        var jobComputePaymentConfigResult = CreateJobComputePaymentConfig();
        factoryAction?.Invoke(jobComputePaymentConfigResult);

        return jobComputePaymentConfigResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig CreateJobComputePaymentConfig()
    {
        var jobComputePaymentConfigResult = new Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig();

        return jobComputePaymentConfigResult;
    }

} // End Of Class

public static class InnerCollaborationJobComputePaymentConfigFactoryExtensions
{
}
