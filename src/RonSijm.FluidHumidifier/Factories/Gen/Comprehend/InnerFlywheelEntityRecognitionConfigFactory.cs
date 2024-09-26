// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerFlywheelEntityRecognitionConfigFactory(Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig>
{

    protected override Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig Create()
    {
        var entityRecognitionConfigResult = CreateEntityRecognitionConfig();
        factoryAction?.Invoke(entityRecognitionConfigResult);

        return entityRecognitionConfigResult;
    }

    private Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig CreateEntityRecognitionConfig()
    {
        var entityRecognitionConfigResult = new Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig();

        return entityRecognitionConfigResult;
    }

} // End Of Class

public static class InnerFlywheelEntityRecognitionConfigFactoryExtensions
{
}
