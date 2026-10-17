// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerSecurityProfileFlowModuleFactory(Action<Humidifier.Connect.SecurityProfileTypes.FlowModule> factoryAction = null) : SubResourceFactory<Humidifier.Connect.SecurityProfileTypes.FlowModule>
{

    protected override Humidifier.Connect.SecurityProfileTypes.FlowModule Create()
    {
        var flowModuleResult = CreateFlowModule();
        factoryAction?.Invoke(flowModuleResult);

        return flowModuleResult;
    }

    private Humidifier.Connect.SecurityProfileTypes.FlowModule CreateFlowModule()
    {
        var flowModuleResult = new Humidifier.Connect.SecurityProfileTypes.FlowModule();

        return flowModuleResult;
    }

} // End Of Class

public static class InnerSecurityProfileFlowModuleFactoryExtensions
{
}
