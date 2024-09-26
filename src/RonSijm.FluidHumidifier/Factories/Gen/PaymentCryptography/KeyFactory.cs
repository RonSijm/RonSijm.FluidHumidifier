// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PaymentCryptography;

public class KeyFactory(string resourceName = null, Action<Humidifier.PaymentCryptography.Key> factoryAction = null) : ResourceFactory<Humidifier.PaymentCryptography.Key>(resourceName)
{

    internal InnerKeyKeyAttributesFactory KeyAttributesFactory { get; set; }

    protected override Humidifier.PaymentCryptography.Key Create()
    {
        var keyResult = CreateKey();
        factoryAction?.Invoke(keyResult);

        return keyResult;
    }

    private Humidifier.PaymentCryptography.Key CreateKey()
    {
        var keyResult = new Humidifier.PaymentCryptography.Key
        {
            GivenName = InputResourceName,
        };

        return keyResult;
    }
    public override void CreateChildren(Humidifier.PaymentCryptography.Key result)
    {
        base.CreateChildren(result);

        result.KeyAttributes ??= KeyAttributesFactory?.Build();
    }

} // End Of Class

public static class KeyFactoryExtensions
{
    public static CombinedResult<KeyFactory, InnerKeyKeyAttributesFactory> WithKeyAttributes(this KeyFactory parentFactory, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null)
    {
        parentFactory.KeyAttributesFactory = new InnerKeyKeyAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyAttributesFactory);
    }

    public static CombinedResult<KeyFactory, T1, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1>(this CombinedResult<KeyFactory, T1> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyFactory, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1>(this CombinedResult<T1, KeyFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KeyFactory, T1, T2, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2>(this CombinedResult<KeyFactory, T1, T2> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyFactory, T2, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2>(this CombinedResult<T1, KeyFactory, T2> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyFactory, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2>(this CombinedResult<T1, T2, KeyFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KeyFactory, T1, T2, T3, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3>(this CombinedResult<KeyFactory, T1, T2, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyFactory, T2, T3, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3>(this CombinedResult<T1, KeyFactory, T2, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyFactory, T3, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3>(this CombinedResult<T1, T2, KeyFactory, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyFactory, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, KeyFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KeyFactory, T1, T2, T3, T4, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3, T4>(this CombinedResult<KeyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyFactory, T2, T3, T4, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3, T4>(this CombinedResult<T1, KeyFactory, T2, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyFactory, T3, T4, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, KeyFactory, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyFactory, T4, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KeyFactory, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KeyFactory, InnerKeyKeyAttributesFactory> WithKeyAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KeyFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyAttributes(combinedResult.T5, subFactoryAction));
}
