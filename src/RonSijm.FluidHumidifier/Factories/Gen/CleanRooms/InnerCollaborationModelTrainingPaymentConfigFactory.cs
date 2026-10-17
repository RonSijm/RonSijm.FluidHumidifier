// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationModelTrainingPaymentConfigFactory(Action<Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig Create()
    {
        var modelTrainingPaymentConfigResult = CreateModelTrainingPaymentConfig();
        factoryAction?.Invoke(modelTrainingPaymentConfigResult);

        return modelTrainingPaymentConfigResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig CreateModelTrainingPaymentConfig()
    {
        var modelTrainingPaymentConfigResult = new Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig();

        return modelTrainingPaymentConfigResult;
    }

} // End Of Class

public static class InnerCollaborationModelTrainingPaymentConfigFactoryExtensions
{
}
