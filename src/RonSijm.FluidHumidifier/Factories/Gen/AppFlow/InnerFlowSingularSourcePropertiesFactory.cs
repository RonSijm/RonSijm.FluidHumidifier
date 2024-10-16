// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSingularSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.SingularSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SingularSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.SingularSourceProperties Create()
    {
        var singularSourcePropertiesResult = CreateSingularSourceProperties();
        factoryAction?.Invoke(singularSourcePropertiesResult);

        return singularSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.SingularSourceProperties CreateSingularSourceProperties()
    {
        var singularSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.SingularSourceProperties();

        return singularSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowSingularSourcePropertiesFactoryExtensions
{
}
