// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkteamMemberDefinitionFactory(Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkteamTypes.MemberDefinition>
{

    internal InnerWorkteamOidcMemberDefinitionFactory OidcMemberDefinitionFactory { get; set; }

    internal InnerWorkteamCognitoMemberDefinitionFactory CognitoMemberDefinitionFactory { get; set; }

    protected override Humidifier.SageMaker.WorkteamTypes.MemberDefinition Create()
    {
        var memberDefinitionResult = CreateMemberDefinition();
        factoryAction?.Invoke(memberDefinitionResult);

        return memberDefinitionResult;
    }

    private Humidifier.SageMaker.WorkteamTypes.MemberDefinition CreateMemberDefinition()
    {
        var memberDefinitionResult = new Humidifier.SageMaker.WorkteamTypes.MemberDefinition();

        return memberDefinitionResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.WorkteamTypes.MemberDefinition result)
    {
        base.CreateChildren(result);

        result.OidcMemberDefinition ??= OidcMemberDefinitionFactory?.Build();
        result.CognitoMemberDefinition ??= CognitoMemberDefinitionFactory?.Build();
    }

} // End Of Class

public static class InnerWorkteamMemberDefinitionFactoryExtensions
{
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition(this InnerWorkteamMemberDefinitionFactory parentFactory, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null)
    {
        parentFactory.OidcMemberDefinitionFactory = new InnerWorkteamOidcMemberDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OidcMemberDefinitionFactory);
    }

    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition(this InnerWorkteamMemberDefinitionFactory parentFactory, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null)
    {
        parentFactory.CognitoMemberDefinitionFactory = new InnerWorkteamCognitoMemberDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CognitoMemberDefinitionFactory);
    }

    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, T4, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3, T4>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, T4, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, T4, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, T4, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkteamMemberDefinitionFactory, InnerWorkteamOidcMemberDefinitionFactory> WithOidcMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidcMemberDefinition(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, T4, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3, T4>(this CombinedResult<InnerWorkteamMemberDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, T4, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkteamMemberDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, T4, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkteamMemberDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, T4, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkteamMemberDefinitionFactory, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkteamMemberDefinitionFactory, InnerWorkteamCognitoMemberDefinitionFactory> WithCognitoMemberDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkteamMemberDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoMemberDefinition(combinedResult.T5, subFactoryAction));
}
