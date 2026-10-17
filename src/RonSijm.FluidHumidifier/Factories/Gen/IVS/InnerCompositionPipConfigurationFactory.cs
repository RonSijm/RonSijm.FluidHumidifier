// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionPipConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.PipConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.PipConfiguration>
{

    protected override Humidifier.IVS.CompositionTypes.PipConfiguration Create()
    {
        var pipConfigurationResult = CreatePipConfiguration();
        factoryAction?.Invoke(pipConfigurationResult);

        return pipConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.PipConfiguration CreatePipConfiguration()
    {
        var pipConfigurationResult = new Humidifier.IVS.CompositionTypes.PipConfiguration();

        return pipConfigurationResult;
    }

} // End Of Class

public static class InnerCompositionPipConfigurationFactoryExtensions
{
}
