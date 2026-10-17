// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionGridConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.GridConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.GridConfiguration>
{

    protected override Humidifier.IVS.CompositionTypes.GridConfiguration Create()
    {
        var gridConfigurationResult = CreateGridConfiguration();
        factoryAction?.Invoke(gridConfigurationResult);

        return gridConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.GridConfiguration CreateGridConfiguration()
    {
        var gridConfigurationResult = new Humidifier.IVS.CompositionTypes.GridConfiguration();

        return gridConfigurationResult;
    }

} // End Of Class

public static class InnerCompositionGridConfigurationFactoryExtensions
{
}
