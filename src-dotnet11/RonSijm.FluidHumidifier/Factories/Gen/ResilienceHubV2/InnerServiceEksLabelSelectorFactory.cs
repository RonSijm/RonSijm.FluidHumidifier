// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceEksLabelSelectorFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector Create()
    {
        var eksLabelSelectorResult = CreateEksLabelSelector();
        factoryAction?.Invoke(eksLabelSelectorResult);

        return eksLabelSelectorResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector CreateEksLabelSelector()
    {
        var eksLabelSelectorResult = new Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector();

        return eksLabelSelectorResult;
    }

} // End Of Class

public static class InnerServiceEksLabelSelectorFactoryExtensions
{
}
