// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyParametersFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.Parameters>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.Parameters Create()
    {
        var parametersResult = CreateParameters();
        factoryAction?.Invoke(parametersResult);

        return parametersResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.Parameters CreateParameters()
    {
        var parametersResult = new Humidifier.DLM.LifecyclePolicyTypes.Parameters();

        return parametersResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyParametersFactoryExtensions
{
}
