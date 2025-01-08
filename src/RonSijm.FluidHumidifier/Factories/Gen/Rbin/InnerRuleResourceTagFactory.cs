// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rbin;

public class InnerRuleResourceTagFactory(Action<Humidifier.Rbin.RuleTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.Rbin.RuleTypes.ResourceTag>
{

    protected override Humidifier.Rbin.RuleTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.Rbin.RuleTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.Rbin.RuleTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerRuleResourceTagFactoryExtensions
{
}
