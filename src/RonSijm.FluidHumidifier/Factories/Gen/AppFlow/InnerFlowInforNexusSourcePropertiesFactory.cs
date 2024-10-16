// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowInforNexusSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties Create()
    {
        var inforNexusSourcePropertiesResult = CreateInforNexusSourceProperties();
        factoryAction?.Invoke(inforNexusSourcePropertiesResult);

        return inforNexusSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties CreateInforNexusSourceProperties()
    {
        var inforNexusSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties();

        return inforNexusSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowInforNexusSourcePropertiesFactoryExtensions
{
}
