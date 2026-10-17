// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class CodeSecurityIntegrationFactory(string resourceName = null, Action<Humidifier.InspectorV2.CodeSecurityIntegration> factoryAction = null) : ResourceFactory<Humidifier.InspectorV2.CodeSecurityIntegration>(resourceName)
{

    internal InnerCodeSecurityIntegrationCreateDetailsFactory CreateIntegrationDetailsFactory { get; set; }

    internal InnerCodeSecurityIntegrationUpdateDetailsFactory UpdateIntegrationDetailsFactory { get; set; }

    protected override Humidifier.InspectorV2.CodeSecurityIntegration Create()
    {
        var codeSecurityIntegrationResult = CreateCodeSecurityIntegration();
        factoryAction?.Invoke(codeSecurityIntegrationResult);

        return codeSecurityIntegrationResult;
    }

    private Humidifier.InspectorV2.CodeSecurityIntegration CreateCodeSecurityIntegration()
    {
        var codeSecurityIntegrationResult = new Humidifier.InspectorV2.CodeSecurityIntegration
        {
            GivenName = InputResourceName,
        };

        return codeSecurityIntegrationResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CodeSecurityIntegration result)
    {
        base.CreateChildren(result);

        result.CreateIntegrationDetails ??= CreateIntegrationDetailsFactory?.Build();
        result.UpdateIntegrationDetails ??= UpdateIntegrationDetailsFactory?.Build();
    }

} // End Of Class

public static class CodeSecurityIntegrationFactoryExtensions
{
    public static CombinedResult<CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails(this CodeSecurityIntegrationFactory parentFactory, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null)
    {
        parentFactory.CreateIntegrationDetailsFactory = new InnerCodeSecurityIntegrationCreateDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreateIntegrationDetailsFactory);
    }

    public static CombinedResult<CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails(this CodeSecurityIntegrationFactory parentFactory, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null)
    {
        parentFactory.UpdateIntegrationDetailsFactory = new InnerCodeSecurityIntegrationUpdateDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UpdateIntegrationDetailsFactory);
    }

    public static CombinedResult<CodeSecurityIntegrationFactory, T1, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1>(this CombinedResult<CodeSecurityIntegrationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1>(this CombinedResult<T1, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, T4, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, T4, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, T4, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, T4, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationCreateDetailsFactory> WithCreateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreateIntegrationDetails(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1>(this CombinedResult<CodeSecurityIntegrationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1>(this CombinedResult<T1, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, T4, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<CodeSecurityIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, T4, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, CodeSecurityIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, T4, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeSecurityIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, T4, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeSecurityIntegrationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodeSecurityIntegrationFactory, InnerCodeSecurityIntegrationUpdateDetailsFactory> WithUpdateIntegrationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeSecurityIntegrationFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdateIntegrationDetails(combinedResult.T5, subFactoryAction).T2);
}
