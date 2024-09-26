// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateExtensionsV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2>
{

    internal InnerTemplateApplicationPoliciesFactory ApplicationPoliciesFactory { get; set; }

    internal InnerTemplateKeyUsageFactory KeyUsageFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2 Create()
    {
        var extensionsV2Result = CreateExtensionsV2();
        factoryAction?.Invoke(extensionsV2Result);

        return extensionsV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2 CreateExtensionsV2()
    {
        var extensionsV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2();

        return extensionsV2Result;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2 result)
    {
        base.CreateChildren(result);

        result.ApplicationPolicies ??= ApplicationPoliciesFactory?.Build();
        result.KeyUsage ??= KeyUsageFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateExtensionsV2FactoryExtensions
{
    public static CombinedResult<InnerTemplateExtensionsV2Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies(this InnerTemplateExtensionsV2Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null)
    {
        parentFactory.ApplicationPoliciesFactory = new InnerTemplateApplicationPoliciesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationPoliciesFactory);
    }

    public static CombinedResult<InnerTemplateExtensionsV2Factory, InnerTemplateKeyUsageFactory> WithKeyUsage(this InnerTemplateExtensionsV2Factory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null)
    {
        parentFactory.KeyUsageFactory = new InnerTemplateKeyUsageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsageFactory);
    }

    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, T4, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV2Factory, InnerTemplateApplicationPoliciesFactory> WithApplicationPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationPolicies(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, InnerTemplateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<InnerTemplateExtensionsV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateExtensionsV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateExtensionsV2Factory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, T4, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateExtensionsV2Factory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV2Factory, InnerTemplateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateExtensionsV2Factory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T5, subFactoryAction));
}
