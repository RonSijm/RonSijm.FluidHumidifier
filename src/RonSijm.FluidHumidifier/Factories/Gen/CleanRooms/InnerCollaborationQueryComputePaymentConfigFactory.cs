// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationQueryComputePaymentConfigFactory(Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig Create()
    {
        var queryComputePaymentConfigResult = CreateQueryComputePaymentConfig();
        factoryAction?.Invoke(queryComputePaymentConfigResult);

        return queryComputePaymentConfigResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig CreateQueryComputePaymentConfig()
    {
        var queryComputePaymentConfigResult = new Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig();

        return queryComputePaymentConfigResult;
    }

} // End Of Class

public static class InnerCollaborationQueryComputePaymentConfigFactoryExtensions
{
}
