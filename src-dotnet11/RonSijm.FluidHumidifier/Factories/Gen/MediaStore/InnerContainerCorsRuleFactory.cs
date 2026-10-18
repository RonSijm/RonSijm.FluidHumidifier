// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaStore;

public class InnerContainerCorsRuleFactory(Action<Humidifier.MediaStore.ContainerTypes.CorsRule> factoryAction = null) : SubResourceFactory<Humidifier.MediaStore.ContainerTypes.CorsRule>
{

    protected override Humidifier.MediaStore.ContainerTypes.CorsRule Create()
    {
        var corsRuleResult = CreateCorsRule();
        factoryAction?.Invoke(corsRuleResult);

        return corsRuleResult;
    }

    private Humidifier.MediaStore.ContainerTypes.CorsRule CreateCorsRule()
    {
        var corsRuleResult = new Humidifier.MediaStore.ContainerTypes.CorsRule();

        return corsRuleResult;
    }

} // End Of Class

public static class InnerContainerCorsRuleFactoryExtensions
{
}
