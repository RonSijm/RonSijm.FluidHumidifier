// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DomainNameV2Factory(string resourceName = null, Action<Humidifier.ApiGateway.DomainNameV2> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.DomainNameV2>(resourceName)
{

    internal InnerDomainNameV2EndpointConfigurationFactory EndpointConfigurationFactory { get; set; }

    protected override Humidifier.ApiGateway.DomainNameV2 Create()
    {
        var domainNameV2Result = CreateDomainNameV2();
        factoryAction?.Invoke(domainNameV2Result);

        return domainNameV2Result;
    }

    private Humidifier.ApiGateway.DomainNameV2 CreateDomainNameV2()
    {
        var domainNameV2Result = new Humidifier.ApiGateway.DomainNameV2
        {
            GivenName = InputResourceName,
        };

        return domainNameV2Result;
    }
    public override void CreateChildren(Humidifier.ApiGateway.DomainNameV2 result)
    {
        base.CreateChildren(result);

        result.EndpointConfiguration ??= EndpointConfigurationFactory?.Build();
    }

} // End Of Class

public static class DomainNameV2FactoryExtensions
{
    public static CombinedResult<DomainNameV2Factory, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration(this DomainNameV2Factory parentFactory, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null)
    {
        parentFactory.EndpointConfigurationFactory = new InnerDomainNameV2EndpointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointConfigurationFactory);
    }

    public static CombinedResult<DomainNameV2Factory, T1, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<DomainNameV2Factory, T1> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameV2Factory, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<T1, DomainNameV2Factory> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainNameV2Factory, T1, T2, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<DomainNameV2Factory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameV2Factory, T2, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, DomainNameV2Factory, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameV2Factory, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, T2, DomainNameV2Factory> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainNameV2Factory, T1, T2, T3, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<DomainNameV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameV2Factory, T2, T3, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, DomainNameV2Factory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameV2Factory, T3, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DomainNameV2Factory, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameV2Factory, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainNameV2Factory> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainNameV2Factory, T1, T2, T3, T4, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<DomainNameV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameV2Factory, T2, T3, T4, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DomainNameV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameV2Factory, T3, T4, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainNameV2Factory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameV2Factory, T4, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainNameV2Factory, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainNameV2Factory, InnerDomainNameV2EndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainNameV2Factory> combinedResult, Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T5, subFactoryAction));
}
