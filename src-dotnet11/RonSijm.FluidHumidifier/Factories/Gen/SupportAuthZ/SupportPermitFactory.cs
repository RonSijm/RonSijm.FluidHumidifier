// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportAuthZ;

public class SupportPermitFactory(string resourceName = null, Action<Humidifier.SupportAuthZ.SupportPermit> factoryAction = null) : ResourceFactory<Humidifier.SupportAuthZ.SupportPermit>(resourceName)
{

    internal InnerSupportPermitPermitFactory PermitFactory { get; set; }

    internal InnerSupportPermitSigningKeyInfoFactory SigningKeyInfoFactory { get; set; }

    protected override Humidifier.SupportAuthZ.SupportPermit Create()
    {
        var supportPermitResult = CreateSupportPermit();
        factoryAction?.Invoke(supportPermitResult);

        return supportPermitResult;
    }

    private Humidifier.SupportAuthZ.SupportPermit CreateSupportPermit()
    {
        var supportPermitResult = new Humidifier.SupportAuthZ.SupportPermit
        {
            GivenName = InputResourceName,
        };

        return supportPermitResult;
    }
    public override void CreateChildren(Humidifier.SupportAuthZ.SupportPermit result)
    {
        base.CreateChildren(result);

        result.Permit ??= PermitFactory?.Build();
        result.SigningKeyInfo ??= SigningKeyInfoFactory?.Build();
    }

} // End Of Class

public static class SupportPermitFactoryExtensions
{
    public static CombinedResult<SupportPermitFactory, InnerSupportPermitPermitFactory> WithPermit(this SupportPermitFactory parentFactory, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null)
    {
        parentFactory.PermitFactory = new InnerSupportPermitPermitFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PermitFactory);
    }

    public static CombinedResult<SupportPermitFactory, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo(this SupportPermitFactory parentFactory, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null)
    {
        parentFactory.SigningKeyInfoFactory = new InnerSupportPermitSigningKeyInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SigningKeyInfoFactory);
    }

    public static CombinedResult<SupportPermitFactory, T1, InnerSupportPermitPermitFactory> WithPermit<T1>(this CombinedResult<SupportPermitFactory, T1> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, InnerSupportPermitPermitFactory> WithPermit<T1>(this CombinedResult<T1, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, InnerSupportPermitPermitFactory> WithPermit<T1, T2>(this CombinedResult<SupportPermitFactory, T1, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, InnerSupportPermitPermitFactory> WithPermit<T1, T2>(this CombinedResult<T1, SupportPermitFactory, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, InnerSupportPermitPermitFactory> WithPermit<T1, T2>(this CombinedResult<T1, T2, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, T3, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3>(this CombinedResult<SupportPermitFactory, T1, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, T3, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3>(this CombinedResult<T1, SupportPermitFactory, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, T3, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3>(this CombinedResult<T1, T2, SupportPermitFactory, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SupportPermitFactory, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3>(this CombinedResult<T1, T2, T3, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, T3, T4, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3, T4>(this CombinedResult<SupportPermitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, T3, T4, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3, T4>(this CombinedResult<T1, SupportPermitFactory, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, T3, T4, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3, T4>(this CombinedResult<T1, T2, SupportPermitFactory, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SupportPermitFactory, T4, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SupportPermitFactory, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SupportPermitFactory, InnerSupportPermitPermitFactory> WithPermit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermit(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1>(this CombinedResult<SupportPermitFactory, T1> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1>(this CombinedResult<T1, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2>(this CombinedResult<SupportPermitFactory, T1, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2>(this CombinedResult<T1, SupportPermitFactory, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2>(this CombinedResult<T1, T2, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, T3, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3>(this CombinedResult<SupportPermitFactory, T1, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, T3, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3>(this CombinedResult<T1, SupportPermitFactory, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, T3, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3>(this CombinedResult<T1, T2, SupportPermitFactory, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SupportPermitFactory, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SupportPermitFactory, T1, T2, T3, T4, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3, T4>(this CombinedResult<SupportPermitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SupportPermitFactory, T2, T3, T4, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3, T4>(this CombinedResult<T1, SupportPermitFactory, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SupportPermitFactory, T3, T4, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, SupportPermitFactory, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SupportPermitFactory, T4, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SupportPermitFactory, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SupportPermitFactory, InnerSupportPermitSigningKeyInfoFactory> WithSigningKeyInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SupportPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningKeyInfo(combinedResult.T5, subFactoryAction).T2);
}
