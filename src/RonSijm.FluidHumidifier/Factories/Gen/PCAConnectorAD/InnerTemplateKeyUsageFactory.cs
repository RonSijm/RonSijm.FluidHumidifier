// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateKeyUsageFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage>
{

    internal InnerTemplateKeyUsageFlagsFactory UsageFlagsFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage Create()
    {
        var keyUsageResult = CreateKeyUsage();
        factoryAction?.Invoke(keyUsageResult);

        return keyUsageResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage CreateKeyUsage()
    {
        var keyUsageResult = new Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage();

        return keyUsageResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage result)
    {
        base.CreateChildren(result);

        result.UsageFlags ??= UsageFlagsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateKeyUsageFactoryExtensions
{
    public static CombinedResult<InnerTemplateKeyUsageFactory, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags(this InnerTemplateKeyUsageFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null)
    {
        parentFactory.UsageFlagsFactory = new InnerTemplateKeyUsageFlagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UsageFlagsFactory);
    }

    public static CombinedResult<InnerTemplateKeyUsageFactory, T1, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1>(this CombinedResult<InnerTemplateKeyUsageFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsageFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsageFactory, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1>(this CombinedResult<T1, InnerTemplateKeyUsageFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsageFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsageFactory, T1, T2, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2>(this CombinedResult<InnerTemplateKeyUsageFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsageFactory, T2, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2>(this CombinedResult<T1, InnerTemplateKeyUsageFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsageFactory, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2>(this CombinedResult<T1, T2, InnerTemplateKeyUsageFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsageFactory, T1, T2, T3, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3>(this CombinedResult<InnerTemplateKeyUsageFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsageFactory, T2, T3, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3>(this CombinedResult<T1, InnerTemplateKeyUsageFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsageFactory, T3, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateKeyUsageFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateKeyUsageFactory, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateKeyUsageFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateKeyUsageFactory, T1, T2, T3, T4, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3, T4>(this CombinedResult<InnerTemplateKeyUsageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateKeyUsageFactory, T2, T3, T4, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateKeyUsageFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateKeyUsageFactory, T3, T4, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateKeyUsageFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateKeyUsageFactory, T4, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateKeyUsageFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateKeyUsageFactory, InnerTemplateKeyUsageFlagsFactory> WithUsageFlags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateKeyUsageFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageFlags(combinedResult.T5, subFactoryAction));
}
