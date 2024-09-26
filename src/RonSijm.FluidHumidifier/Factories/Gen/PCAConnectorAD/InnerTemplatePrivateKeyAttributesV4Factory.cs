// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyAttributesV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4>
{

    internal InnerTemplateKeyUsagePropertyFactory KeyUsagePropertyFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4 Create()
    {
        var privateKeyAttributesV4Result = CreatePrivateKeyAttributesV4();
        factoryAction?.Invoke(privateKeyAttributesV4Result);

        return privateKeyAttributesV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4 CreatePrivateKeyAttributesV4()
    {
        var privateKeyAttributesV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4();

        return privateKeyAttributesV4Result;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4 result)
    {
        base.CreateChildren(result);

        result.KeyUsageProperty ??= KeyUsagePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerTemplatePrivateKeyAttributesV4FactoryExtensions
{
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty(this InnerTemplatePrivateKeyAttributesV4Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null)
    {
        parentFactory.KeyUsagePropertyFactory = new InnerTemplateKeyUsagePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsagePropertyFactory);
    }

    public static CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1>(this CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV4Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<InnerTemplatePrivateKeyAttributesV4Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV4Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV4Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV4Factory, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV4Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplatePrivateKeyAttributesV4Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplatePrivateKeyAttributesV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T5, subFactoryAction));
}
