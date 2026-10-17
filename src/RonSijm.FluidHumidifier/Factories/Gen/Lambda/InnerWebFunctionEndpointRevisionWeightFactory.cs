// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionEndpointRevisionWeightFactory(Action<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight>
{

    protected override Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight Create()
    {
        var revisionWeightResult = CreateRevisionWeight();
        factoryAction?.Invoke(revisionWeightResult);

        return revisionWeightResult;
    }

    private Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight CreateRevisionWeight()
    {
        var revisionWeightResult = new Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight();

        return revisionWeightResult;
    }

} // End Of Class

public static class InnerWebFunctionEndpointRevisionWeightFactoryExtensions
{
}
