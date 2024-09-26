// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionReplaceDefaultPolicyVersionParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams Create()
    {
        var replaceDefaultPolicyVersionParamsResult = CreateReplaceDefaultPolicyVersionParams();
        factoryAction?.Invoke(replaceDefaultPolicyVersionParamsResult);

        return replaceDefaultPolicyVersionParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams CreateReplaceDefaultPolicyVersionParams()
    {
        var replaceDefaultPolicyVersionParamsResult = new Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams();

        return replaceDefaultPolicyVersionParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionReplaceDefaultPolicyVersionParamsFactoryExtensions
{
}
