// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PaymentCryptography;

public class InnerKeyKeyAttributesFactory(Action<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes> factoryAction = null) : SubResourceFactory<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes>
{

    internal InnerKeyKeyModesOfUseFactory KeyModesOfUseFactory { get; set; }

    protected override Humidifier.PaymentCryptography.KeyTypes.KeyAttributes Create()
    {
        var keyAttributesResult = CreateKeyAttributes();
        factoryAction?.Invoke(keyAttributesResult);

        return keyAttributesResult;
    }

    private Humidifier.PaymentCryptography.KeyTypes.KeyAttributes CreateKeyAttributes()
    {
        var keyAttributesResult = new Humidifier.PaymentCryptography.KeyTypes.KeyAttributes();

        return keyAttributesResult;
    }
    public override void CreateChildren(Humidifier.PaymentCryptography.KeyTypes.KeyAttributes result)
    {
        base.CreateChildren(result);

        result.KeyModesOfUse ??= KeyModesOfUseFactory?.Build();
    }

} // End Of Class

public static class InnerKeyKeyAttributesFactoryExtensions
{
    public static CombinedResult<InnerKeyKeyAttributesFactory, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse(this InnerKeyKeyAttributesFactory parentFactory, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null)
    {
        parentFactory.KeyModesOfUseFactory = new InnerKeyKeyModesOfUseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyModesOfUseFactory);
    }

    public static CombinedResult<InnerKeyKeyAttributesFactory, T1, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1>(this CombinedResult<InnerKeyKeyAttributesFactory, T1> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKeyKeyAttributesFactory, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1>(this CombinedResult<T1, InnerKeyKeyAttributesFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKeyKeyAttributesFactory, T1, T2, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2>(this CombinedResult<InnerKeyKeyAttributesFactory, T1, T2> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKeyKeyAttributesFactory, T2, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2>(this CombinedResult<T1, InnerKeyKeyAttributesFactory, T2> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKeyKeyAttributesFactory, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2>(this CombinedResult<T1, T2, InnerKeyKeyAttributesFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKeyKeyAttributesFactory, T1, T2, T3, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3>(this CombinedResult<InnerKeyKeyAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKeyKeyAttributesFactory, T2, T3, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3>(this CombinedResult<T1, InnerKeyKeyAttributesFactory, T2, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKeyKeyAttributesFactory, T3, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3>(this CombinedResult<T1, T2, InnerKeyKeyAttributesFactory, T3> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKeyKeyAttributesFactory, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKeyKeyAttributesFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKeyKeyAttributesFactory, T1, T2, T3, T4, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3, T4>(this CombinedResult<InnerKeyKeyAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKeyKeyAttributesFactory, T2, T3, T4, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3, T4>(this CombinedResult<T1, InnerKeyKeyAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKeyKeyAttributesFactory, T3, T4, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKeyKeyAttributesFactory, T3, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKeyKeyAttributesFactory, T4, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKeyKeyAttributesFactory, T4> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKeyKeyAttributesFactory, InnerKeyKeyModesOfUseFactory> WithKeyModesOfUse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKeyKeyAttributesFactory> combinedResult, Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyModesOfUse(combinedResult.T5, subFactoryAction));
}
