// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateKeyUsagePropertyFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty>
{

    internal InnerTemplateKeyUsagePropertyFlagsFactory PropertyFlagsFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty Create()
    {
        var keyUsagePropertyResult = CreateKeyUsageProperty();
        factoryAction?.Invoke(keyUsagePropertyResult);

        return keyUsagePropertyResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty CreateKeyUsageProperty()
    {
        var keyUsagePropertyResult = new Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty();

        return keyUsagePropertyResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty result)
    {
        base.CreateChildren(result);

        result.PropertyFlags ??= PropertyFlagsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateKeyUsagePropertyFactoryExtensions
{
    public static CombinedResult<InnerTemplateKeyUsagePropertyFactory, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags(this InnerTemplateKeyUsagePropertyFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null)
    {
        parentFactory.PropertyFlagsFactory = new InnerTemplateKeyUsagePropertyFlagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropertyFlagsFactory);
    }

    public static CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1>(this CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithPropertyFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1>(this CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithPropertyFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2>(this CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2>(this CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2>(this CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2, T3, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3>(this CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2, T3, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3>(this CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory, T3, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateKeyUsagePropertyFactory, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateKeyUsagePropertyFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2, T3, T4, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3, T4>(this CombinedResult<InnerTemplateKeyUsagePropertyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2, T3, T4, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateKeyUsagePropertyFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory, T3, T4, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateKeyUsagePropertyFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateKeyUsagePropertyFactory, T4, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateKeyUsagePropertyFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory, InnerTemplateKeyUsagePropertyFlagsFactory> WithPropertyFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPropertyFlags(combinedResult.T5, subFactoryAction));
}
