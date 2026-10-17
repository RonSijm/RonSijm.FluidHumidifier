// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationDynatraceConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration Create()
    {
        var dynatraceConfigurationResult = CreateDynatraceConfiguration();
        factoryAction?.Invoke(dynatraceConfigurationResult);

        return dynatraceConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration CreateDynatraceConfiguration()
    {
        var dynatraceConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration();

        return dynatraceConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationDynatraceConfigurationFactoryExtensions
{
}
