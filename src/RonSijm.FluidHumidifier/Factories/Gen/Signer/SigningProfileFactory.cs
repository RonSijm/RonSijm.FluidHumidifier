// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Signer;

public class SigningProfileFactory(string resourceName = null, Action<Humidifier.Signer.SigningProfile> factoryAction = null) : ResourceFactory<Humidifier.Signer.SigningProfile>(resourceName)
{

    internal InnerSigningProfileSignatureValidityPeriodFactory SignatureValidityPeriodFactory { get; set; }

    protected override Humidifier.Signer.SigningProfile Create()
    {
        var signingProfileResult = CreateSigningProfile();
        factoryAction?.Invoke(signingProfileResult);

        return signingProfileResult;
    }

    private Humidifier.Signer.SigningProfile CreateSigningProfile()
    {
        var signingProfileResult = new Humidifier.Signer.SigningProfile
        {
            GivenName = InputResourceName,
        };

        return signingProfileResult;
    }
    public override void CreateChildren(Humidifier.Signer.SigningProfile result)
    {
        base.CreateChildren(result);

        result.SignatureValidityPeriod ??= SignatureValidityPeriodFactory?.Build();
    }

} // End Of Class

public static class SigningProfileFactoryExtensions
{
    public static CombinedResult<SigningProfileFactory, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod(this SigningProfileFactory parentFactory, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null)
    {
        parentFactory.SignatureValidityPeriodFactory = new InnerSigningProfileSignatureValidityPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SignatureValidityPeriodFactory);
    }

    public static CombinedResult<SigningProfileFactory, T1, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1>(this CombinedResult<SigningProfileFactory, T1> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SigningProfileFactory, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1>(this CombinedResult<T1, SigningProfileFactory> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SigningProfileFactory, T1, T2, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2>(this CombinedResult<SigningProfileFactory, T1, T2> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SigningProfileFactory, T2, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2>(this CombinedResult<T1, SigningProfileFactory, T2> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SigningProfileFactory, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2>(this CombinedResult<T1, T2, SigningProfileFactory> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SigningProfileFactory, T1, T2, T3, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3>(this CombinedResult<SigningProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SigningProfileFactory, T2, T3, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3>(this CombinedResult<T1, SigningProfileFactory, T2, T3> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SigningProfileFactory, T3, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3>(this CombinedResult<T1, T2, SigningProfileFactory, T3> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SigningProfileFactory, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, SigningProfileFactory> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SigningProfileFactory, T1, T2, T3, T4, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3, T4>(this CombinedResult<SigningProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SigningProfileFactory, T2, T3, T4, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, SigningProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SigningProfileFactory, T3, T4, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, SigningProfileFactory, T3, T4> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SigningProfileFactory, T4, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SigningProfileFactory, T4> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SigningProfileFactory, InnerSigningProfileSignatureValidityPeriodFactory> WithSignatureValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SigningProfileFactory> combinedResult, Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignatureValidityPeriod(combinedResult.T5, subFactoryAction));
}
