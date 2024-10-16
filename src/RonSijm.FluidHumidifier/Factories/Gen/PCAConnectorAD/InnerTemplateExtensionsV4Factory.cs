// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateExtensionsV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4>
{

    internal InnerTemplateApplicationPoliciesFactory ApplicationPoliciesFactory { get; set; }

    internal InnerTemplateKeyUsageFactory KeyUsageFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4 Create()
    {
        var extensionsV4Result = CreateExtensionsV4();
        factoryAction?.Invoke(extensionsV4Result);

        return extensionsV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4 CreateExtensionsV4()
    {
        var extensionsV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4();

        return extensionsV4Result;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4 result)
    {
        base.CreateChildren(result);

        result.ApplicationPolicies ??= ApplicationPoliciesFactory?.Build();
        result.KeyUsage ??= KeyUsageFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateExtensionsV4FactoryExtensions
{
    public static CombinedResult<InnerTemplateExtensionsV4Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies(this InnerTemplateExtensionsV4Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null)
    {
        parentFactory.ApplicationPoliciesFactory = new InnerTemplateApplicationPoliciesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationPoliciesFactory);
    }

    public static CombinedResult<InnerTemplateExtensionsV4Factory, InnerTemplateKeyUsageFactory> WithKeyUsage(this InnerTemplateExtensionsV4Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null)
    {
        parentFactory.KeyUsageFactory = new InnerTemplateKeyUsageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsageFactory);
    }

    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV4Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, InnerTemplateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<InnerTemplateExtensionsV4Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateExtensionsV4Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateExtensionsV4Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV4Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV4Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV4Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T5, subFactoryAction));
}
