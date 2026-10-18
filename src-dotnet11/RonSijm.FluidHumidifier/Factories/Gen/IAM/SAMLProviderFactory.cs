// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class SAMLProviderFactory(string resourceName = null, Action<Humidifier.IAM.SAMLProvider> factoryAction = null) : ResourceFactory<Humidifier.IAM.SAMLProvider>(resourceName)
{

    internal List<InnerSAMLProviderSAMLPrivateKeyFactory> PrivateKeyListFactories { get; set; } = [];

    protected override Humidifier.IAM.SAMLProvider Create()
    {
        var sAMLProviderResult = CreateSAMLProvider();
        factoryAction?.Invoke(sAMLProviderResult);

        return sAMLProviderResult;
    }

    private Humidifier.IAM.SAMLProvider CreateSAMLProvider()
    {
        var sAMLProviderResult = new Humidifier.IAM.SAMLProvider
        {
            GivenName = InputResourceName,
        };

        return sAMLProviderResult;
    }
    public override void CreateChildren(Humidifier.IAM.SAMLProvider result)
    {
        base.CreateChildren(result);

        result.PrivateKeyList = PrivateKeyListFactories.Any() ? PrivateKeyListFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SAMLProviderFactoryExtensions
{
    public static CombinedResult<SAMLProviderFactory, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList(this SAMLProviderFactory parentFactory, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null)
    {
        var factory = new InnerSAMLProviderSAMLPrivateKeyFactory(subFactoryAction);
        parentFactory.PrivateKeyListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SAMLProviderFactory, T1, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1>(this CombinedResult<SAMLProviderFactory, T1> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SAMLProviderFactory, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1>(this CombinedResult<T1, SAMLProviderFactory> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SAMLProviderFactory, T1, T2, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2>(this CombinedResult<SAMLProviderFactory, T1, T2> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SAMLProviderFactory, T2, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2>(this CombinedResult<T1, SAMLProviderFactory, T2> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SAMLProviderFactory, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2>(this CombinedResult<T1, T2, SAMLProviderFactory> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SAMLProviderFactory, T1, T2, T3, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3>(this CombinedResult<SAMLProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SAMLProviderFactory, T2, T3, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3>(this CombinedResult<T1, SAMLProviderFactory, T2, T3> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SAMLProviderFactory, T3, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3>(this CombinedResult<T1, T2, SAMLProviderFactory, T3> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SAMLProviderFactory, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3>(this CombinedResult<T1, T2, T3, SAMLProviderFactory> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SAMLProviderFactory, T1, T2, T3, T4, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3, T4>(this CombinedResult<SAMLProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SAMLProviderFactory, T2, T3, T4, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3, T4>(this CombinedResult<T1, SAMLProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SAMLProviderFactory, T3, T4, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3, T4>(this CombinedResult<T1, T2, SAMLProviderFactory, T3, T4> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SAMLProviderFactory, T4, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SAMLProviderFactory, T4> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SAMLProviderFactory, InnerSAMLProviderSAMLPrivateKeyFactory> WithPrivateKeyList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SAMLProviderFactory> combinedResult, Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeyList(combinedResult.T5, subFactoryAction).T2);
}
