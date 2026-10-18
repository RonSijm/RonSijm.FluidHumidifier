// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceAssertionDefinitionFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition Create()
    {
        var assertionDefinitionResult = CreateAssertionDefinition();
        factoryAction?.Invoke(assertionDefinitionResult);

        return assertionDefinitionResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition CreateAssertionDefinition()
    {
        var assertionDefinitionResult = new Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition();

        return assertionDefinitionResult;
    }

} // End Of Class

public static class InnerServiceAssertionDefinitionFactoryExtensions
{
}
