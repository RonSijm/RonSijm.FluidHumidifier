// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelinePresenterOnlyConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration Create()
    {
        var presenterOnlyConfigurationResult = CreatePresenterOnlyConfiguration();
        factoryAction?.Invoke(presenterOnlyConfigurationResult);

        return presenterOnlyConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration CreatePresenterOnlyConfiguration()
    {
        var presenterOnlyConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration();

        return presenterOnlyConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelinePresenterOnlyConfigurationFactoryExtensions
{
}
