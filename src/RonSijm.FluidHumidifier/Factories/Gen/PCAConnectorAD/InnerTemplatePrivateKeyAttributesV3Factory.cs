// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyAttributesV3Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3>
{

    internal InnerTemplateKeyUsagePropertyFactory KeyUsagePropertyFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3 Create()
    {
        var privateKeyAttributesV3Result = CreatePrivateKeyAttributesV3();
        factoryAction?.Invoke(privateKeyAttributesV3Result);

        return privateKeyAttributesV3Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3 CreatePrivateKeyAttributesV3()
    {
        var privateKeyAttributesV3Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3();

        return privateKeyAttributesV3Result;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3 result)
    {
        base.CreateChildren(result);

        result.KeyUsageProperty ??= KeyUsagePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerTemplatePrivateKeyAttributesV3FactoryExtensions
{
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty(this InnerTemplatePrivateKeyAttributesV3Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null)
    {
        parentFactory.KeyUsagePropertyFactory = new InnerTemplateKeyUsagePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsagePropertyFactory);
    }

    public static CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1>(this CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory, T3, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV3Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV3Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<InnerTemplatePrivateKeyAttributesV3Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplatePrivateKeyAttributesV3Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory, T3, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplatePrivateKeyAttributesV3Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV3Factory, T4, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplatePrivateKeyAttributesV3Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplatePrivateKeyAttributesV3Factory, InnerTemplateKeyUsagePropertyFactory> WithKeyUsageProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplatePrivateKeyAttributesV3Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsageProperty(combinedResult.T5, subFactoryAction));
}
