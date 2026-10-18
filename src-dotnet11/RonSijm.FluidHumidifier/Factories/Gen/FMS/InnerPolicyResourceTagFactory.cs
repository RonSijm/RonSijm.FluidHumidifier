// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyResourceTagFactory(Action<Humidifier.FMS.PolicyTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.ResourceTag>
{

    protected override Humidifier.FMS.PolicyTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.FMS.PolicyTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.FMS.PolicyTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerPolicyResourceTagFactoryExtensions
{
}
