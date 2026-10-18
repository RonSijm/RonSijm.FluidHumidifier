// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionHyperPodPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput Create()
    {
        var hyperPodPropertiesInputResult = CreateHyperPodPropertiesInput();
        factoryAction?.Invoke(hyperPodPropertiesInputResult);

        return hyperPodPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput CreateHyperPodPropertiesInput()
    {
        var hyperPodPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput();

        return hyperPodPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionHyperPodPropertiesInputFactoryExtensions
{
}
