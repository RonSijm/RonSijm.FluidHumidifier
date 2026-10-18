// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DAX;

public class InnerClusterSSESpecificationFactory(Action<Humidifier.DAX.ClusterTypes.SSESpecification> factoryAction = null) : SubResourceFactory<Humidifier.DAX.ClusterTypes.SSESpecification>
{

    protected override Humidifier.DAX.ClusterTypes.SSESpecification Create()
    {
        var sSESpecificationResult = CreateSSESpecification();
        factoryAction?.Invoke(sSESpecificationResult);

        return sSESpecificationResult;
    }

    private Humidifier.DAX.ClusterTypes.SSESpecification CreateSSESpecification()
    {
        var sSESpecificationResult = new Humidifier.DAX.ClusterTypes.SSESpecification();

        return sSESpecificationResult;
    }

} // End Of Class

public static class InnerClusterSSESpecificationFactoryExtensions
{
}
