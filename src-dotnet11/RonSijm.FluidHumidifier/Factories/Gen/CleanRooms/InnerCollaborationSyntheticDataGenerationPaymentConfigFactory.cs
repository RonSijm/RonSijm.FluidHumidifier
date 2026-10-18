// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationSyntheticDataGenerationPaymentConfigFactory(Action<Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig Create()
    {
        var syntheticDataGenerationPaymentConfigResult = CreateSyntheticDataGenerationPaymentConfig();
        factoryAction?.Invoke(syntheticDataGenerationPaymentConfigResult);

        return syntheticDataGenerationPaymentConfigResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig CreateSyntheticDataGenerationPaymentConfig()
    {
        var syntheticDataGenerationPaymentConfigResult = new Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig();

        return syntheticDataGenerationPaymentConfigResult;
    }

} // End Of Class

public static class InnerCollaborationSyntheticDataGenerationPaymentConfigFactoryExtensions
{
}
