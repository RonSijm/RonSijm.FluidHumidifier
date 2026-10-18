// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceVpcLatticeConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration>
{

    internal InnerServiceVpcLatticeAdvancedConfigurationFactory AdvancedConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration Create()
    {
        var vpcLatticeConfigurationResult = CreateVpcLatticeConfiguration();
        factoryAction?.Invoke(vpcLatticeConfigurationResult);

        return vpcLatticeConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration CreateVpcLatticeConfiguration()
    {
        var vpcLatticeConfigurationResult = new Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration();

        return vpcLatticeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration result)
    {
        base.CreateChildren(result);

        result.AdvancedConfiguration ??= AdvancedConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceVpcLatticeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceVpcLatticeConfigurationFactory, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration(this InnerServiceVpcLatticeConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null)
    {
        parentFactory.AdvancedConfigurationFactory = new InnerServiceVpcLatticeAdvancedConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdvancedConfigurationFactory);
    }

    public static CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1>(this CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1>(this CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2, T3, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2, T3, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory, T3, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceVpcLatticeConfigurationFactory, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceVpcLatticeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2, T3, T4, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceVpcLatticeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2, T3, T4, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceVpcLatticeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory, T3, T4, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceVpcLatticeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceVpcLatticeConfigurationFactory, T4, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceVpcLatticeConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceVpcLatticeConfigurationFactory, InnerServiceVpcLatticeAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceVpcLatticeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T5, subFactoryAction).T2);
}
