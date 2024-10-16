// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyPolicyTagFactory(Action<Humidifier.FMS.PolicyTypes.PolicyTag> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.PolicyTag>
{

    protected override Humidifier.FMS.PolicyTypes.PolicyTag Create()
    {
        var policyTagResult = CreatePolicyTag();
        factoryAction?.Invoke(policyTagResult);

        return policyTagResult;
    }

    private Humidifier.FMS.PolicyTypes.PolicyTag CreatePolicyTag()
    {
        var policyTagResult = new Humidifier.FMS.PolicyTypes.PolicyTag();

        return policyTagResult;
    }

} // End Of Class

public static class InnerPolicyPolicyTagFactoryExtensions
{
}
