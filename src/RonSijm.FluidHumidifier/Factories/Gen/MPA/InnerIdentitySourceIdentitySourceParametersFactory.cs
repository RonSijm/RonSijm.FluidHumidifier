// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerIdentitySourceIdentitySourceParametersFactory(Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> factoryAction = null) : SubResourceFactory<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters>
{

    internal InnerIdentitySourceIamIdentityCenterFactory IamIdentityCenterFactory { get; set; }

    protected override Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters Create()
    {
        var identitySourceParametersResult = CreateIdentitySourceParameters();
        factoryAction?.Invoke(identitySourceParametersResult);

        return identitySourceParametersResult;
    }

    private Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters CreateIdentitySourceParameters()
    {
        var identitySourceParametersResult = new Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters();

        return identitySourceParametersResult;
    }
    public override void CreateChildren(Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters result)
    {
        base.CreateChildren(result);

        result.IamIdentityCenter ??= IamIdentityCenterFactory?.Build();
    }

} // End Of Class

public static class InnerIdentitySourceIdentitySourceParametersFactoryExtensions
{
    public static CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter(this InnerIdentitySourceIdentitySourceParametersFactory parentFactory, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null)
    {
        parentFactory.IamIdentityCenterFactory = new InnerIdentitySourceIamIdentityCenterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamIdentityCenterFactory);
    }

    public static CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1>(this CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1>(this CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2>(this CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2>(this CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2>(this CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2, T3, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3>(this CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2, T3, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3>(this CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory, T3, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2, T3, T4, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3, T4>(this CombinedResult<InnerIdentitySourceIdentitySourceParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2, T3, T4, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, InnerIdentitySourceIdentitySourceParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory, T3, T4, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIdentitySourceIdentitySourceParametersFactory, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory, T4, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIdentitySourceIdentitySourceParametersFactory, InnerIdentitySourceIamIdentityCenterFactory> WithIamIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIdentitySourceIdentitySourceParametersFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenter(combinedResult.T5, subFactoryAction).T2);
}
