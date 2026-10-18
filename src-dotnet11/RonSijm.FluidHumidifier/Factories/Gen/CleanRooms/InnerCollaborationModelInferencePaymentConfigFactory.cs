// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationModelInferencePaymentConfigFactory(Action<Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig Create()
    {
        var modelInferencePaymentConfigResult = CreateModelInferencePaymentConfig();
        factoryAction?.Invoke(modelInferencePaymentConfigResult);

        return modelInferencePaymentConfigResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig CreateModelInferencePaymentConfig()
    {
        var modelInferencePaymentConfigResult = new Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig();

        return modelInferencePaymentConfigResult;
    }

} // End Of Class

public static class InnerCollaborationModelInferencePaymentConfigFactoryExtensions
{
}
