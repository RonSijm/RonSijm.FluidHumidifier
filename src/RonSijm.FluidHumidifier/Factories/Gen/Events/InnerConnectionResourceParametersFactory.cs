// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionResourceParametersFactory(Action<Humidifier.Events.ConnectionTypes.ResourceParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.ResourceParameters>
{

    protected override Humidifier.Events.ConnectionTypes.ResourceParameters Create()
    {
        var resourceParametersResult = CreateResourceParameters();
        factoryAction?.Invoke(resourceParametersResult);

        return resourceParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.ResourceParameters CreateResourceParameters()
    {
        var resourceParametersResult = new Humidifier.Events.ConnectionTypes.ResourceParameters();

        return resourceParametersResult;
    }

} // End Of Class

public static class InnerConnectionResourceParametersFactoryExtensions
{
}
