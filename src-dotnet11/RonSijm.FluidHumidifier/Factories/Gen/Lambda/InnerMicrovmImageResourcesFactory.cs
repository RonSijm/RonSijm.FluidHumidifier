// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageResourcesFactory(Action<Humidifier.Lambda.MicrovmImageTypes.Resources> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.Resources>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.Resources Create()
    {
        var resourcesResult = CreateResources();
        factoryAction?.Invoke(resourcesResult);

        return resourcesResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.Resources CreateResources()
    {
        var resourcesResult = new Humidifier.Lambda.MicrovmImageTypes.Resources();

        return resourcesResult;
    }

} // End Of Class

public static class InnerMicrovmImageResourcesFactoryExtensions
{
}
