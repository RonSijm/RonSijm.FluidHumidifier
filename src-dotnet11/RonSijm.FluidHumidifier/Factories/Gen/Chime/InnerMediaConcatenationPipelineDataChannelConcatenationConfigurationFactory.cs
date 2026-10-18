// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineDataChannelConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration Create()
    {
        var dataChannelConcatenationConfigurationResult = CreateDataChannelConcatenationConfiguration();
        factoryAction?.Invoke(dataChannelConcatenationConfigurationResult);

        return dataChannelConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration CreateDataChannelConcatenationConfiguration()
    {
        var dataChannelConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration();

        return dataChannelConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineDataChannelConcatenationConfigurationFactoryExtensions
{
}
