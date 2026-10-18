// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolAdvancedSecurityAdditionalFlowsFactory(Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows>
{

    protected override Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows Create()
    {
        var advancedSecurityAdditionalFlowsResult = CreateAdvancedSecurityAdditionalFlows();
        factoryAction?.Invoke(advancedSecurityAdditionalFlowsResult);

        return advancedSecurityAdditionalFlowsResult;
    }

    private Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows CreateAdvancedSecurityAdditionalFlows()
    {
        var advancedSecurityAdditionalFlowsResult = new Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows();

        return advancedSecurityAdditionalFlowsResult;
    }

} // End Of Class

public static class InnerUserPoolAdvancedSecurityAdditionalFlowsFactoryExtensions
{
}
