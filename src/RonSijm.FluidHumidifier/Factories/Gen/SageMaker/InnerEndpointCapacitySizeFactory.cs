// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointCapacitySizeFactory(Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.CapacitySize>
{

    protected override Humidifier.SageMaker.EndpointTypes.CapacitySize Create()
    {
        var capacitySizeResult = CreateCapacitySize();
        factoryAction?.Invoke(capacitySizeResult);

        return capacitySizeResult;
    }

    private Humidifier.SageMaker.EndpointTypes.CapacitySize CreateCapacitySize()
    {
        var capacitySizeResult = new Humidifier.SageMaker.EndpointTypes.CapacitySize();

        return capacitySizeResult;
    }

} // End Of Class

public static class InnerEndpointCapacitySizeFactoryExtensions
{
}
