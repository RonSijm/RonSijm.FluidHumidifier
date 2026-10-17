// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerPolicyAvailabilitySloFactory(Action<Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo>
{

    protected override Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo Create()
    {
        var availabilitySloResult = CreateAvailabilitySlo();
        factoryAction?.Invoke(availabilitySloResult);

        return availabilitySloResult;
    }

    private Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo CreateAvailabilitySlo()
    {
        var availabilitySloResult = new Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo();

        return availabilitySloResult;
    }

} // End Of Class

public static class InnerPolicyAvailabilitySloFactoryExtensions
{
}
