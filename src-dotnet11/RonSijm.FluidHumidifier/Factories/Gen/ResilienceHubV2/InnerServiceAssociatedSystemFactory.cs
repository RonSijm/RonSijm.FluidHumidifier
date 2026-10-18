// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceAssociatedSystemFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem Create()
    {
        var associatedSystemResult = CreateAssociatedSystem();
        factoryAction?.Invoke(associatedSystemResult);

        return associatedSystemResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem CreateAssociatedSystem()
    {
        var associatedSystemResult = new Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem();

        return associatedSystemResult;
    }

} // End Of Class

public static class InnerServiceAssociatedSystemFactoryExtensions
{
}
