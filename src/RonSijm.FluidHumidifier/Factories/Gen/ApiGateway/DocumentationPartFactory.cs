// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DocumentationPartFactory(string resourceName = null, Action<Humidifier.ApiGateway.DocumentationPart> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.DocumentationPart>(resourceName)
{

    internal InnerDocumentationPartLocationFactory LocationFactory { get; set; }

    protected override Humidifier.ApiGateway.DocumentationPart Create()
    {
        var documentationPartResult = CreateDocumentationPart();
        factoryAction?.Invoke(documentationPartResult);

        return documentationPartResult;
    }

    private Humidifier.ApiGateway.DocumentationPart CreateDocumentationPart()
    {
        var documentationPartResult = new Humidifier.ApiGateway.DocumentationPart
        {
            GivenName = InputResourceName,
        };

        return documentationPartResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.DocumentationPart result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class DocumentationPartFactoryExtensions
{
    public static CombinedResult<DocumentationPartFactory, InnerDocumentationPartLocationFactory> WithLocation(this DocumentationPartFactory parentFactory, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerDocumentationPartLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<DocumentationPartFactory, T1, InnerDocumentationPartLocationFactory> WithLocation<T1>(this CombinedResult<DocumentationPartFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentationPartFactory, InnerDocumentationPartLocationFactory> WithLocation<T1>(this CombinedResult<T1, DocumentationPartFactory> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DocumentationPartFactory, T1, T2, InnerDocumentationPartLocationFactory> WithLocation<T1, T2>(this CombinedResult<DocumentationPartFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentationPartFactory, T2, InnerDocumentationPartLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, DocumentationPartFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentationPartFactory, InnerDocumentationPartLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, DocumentationPartFactory> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DocumentationPartFactory, T1, T2, T3, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<DocumentationPartFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentationPartFactory, T2, T3, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, DocumentationPartFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentationPartFactory, T3, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, DocumentationPartFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentationPartFactory, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, DocumentationPartFactory> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DocumentationPartFactory, T1, T2, T3, T4, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<DocumentationPartFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentationPartFactory, T2, T3, T4, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, DocumentationPartFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentationPartFactory, T3, T4, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, DocumentationPartFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentationPartFactory, T4, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DocumentationPartFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DocumentationPartFactory, InnerDocumentationPartLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DocumentationPartFactory> combinedResult, Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
