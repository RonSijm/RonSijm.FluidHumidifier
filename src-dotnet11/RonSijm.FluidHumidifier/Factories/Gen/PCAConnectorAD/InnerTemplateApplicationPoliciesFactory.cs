// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateApplicationPoliciesFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies Create()
    {
        var applicationPoliciesResult = CreateApplicationPolicies();
        factoryAction?.Invoke(applicationPoliciesResult);

        return applicationPoliciesResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies CreateApplicationPolicies()
    {
        var applicationPoliciesResult = new Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies();

        return applicationPoliciesResult;
    }

} // End Of Class

public static class InnerTemplateApplicationPoliciesFactoryExtensions
{
}
