// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class VpcIngressConnectionFactory(string resourceName = null, Action<Humidifier.AppRunner.VpcIngressConnection> factoryAction = null) : ResourceFactory<Humidifier.AppRunner.VpcIngressConnection>(resourceName)
{

    internal InnerVpcIngressConnectionIngressVpcConfigurationFactory IngressVpcConfigurationFactory { get; set; }

    protected override Humidifier.AppRunner.VpcIngressConnection Create()
    {
        var vpcIngressConnectionResult = CreateVpcIngressConnection();
        factoryAction?.Invoke(vpcIngressConnectionResult);

        return vpcIngressConnectionResult;
    }

    private Humidifier.AppRunner.VpcIngressConnection CreateVpcIngressConnection()
    {
        var vpcIngressConnectionResult = new Humidifier.AppRunner.VpcIngressConnection
        {
            GivenName = InputResourceName,
        };

        return vpcIngressConnectionResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.VpcIngressConnection result)
    {
        base.CreateChildren(result);

        result.IngressVpcConfiguration ??= IngressVpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class VpcIngressConnectionFactoryExtensions
{
    public static CombinedResult<VpcIngressConnectionFactory, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration(this VpcIngressConnectionFactory parentFactory, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.IngressVpcConfigurationFactory = new InnerVpcIngressConnectionIngressVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IngressVpcConfigurationFactory);
    }

    public static CombinedResult<VpcIngressConnectionFactory, T1, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1>(this CombinedResult<VpcIngressConnectionFactory, T1> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VpcIngressConnectionFactory, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1>(this CombinedResult<T1, VpcIngressConnectionFactory> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VpcIngressConnectionFactory, T1, T2, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2>(this CombinedResult<VpcIngressConnectionFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VpcIngressConnectionFactory, T2, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2>(this CombinedResult<T1, VpcIngressConnectionFactory, T2> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VpcIngressConnectionFactory, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, VpcIngressConnectionFactory> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VpcIngressConnectionFactory, T1, T2, T3, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3>(this CombinedResult<VpcIngressConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VpcIngressConnectionFactory, T2, T3, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, VpcIngressConnectionFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VpcIngressConnectionFactory, T3, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, VpcIngressConnectionFactory, T3> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VpcIngressConnectionFactory, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, VpcIngressConnectionFactory> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VpcIngressConnectionFactory, T1, T2, T3, T4, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<VpcIngressConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VpcIngressConnectionFactory, T2, T3, T4, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, VpcIngressConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VpcIngressConnectionFactory, T3, T4, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, VpcIngressConnectionFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VpcIngressConnectionFactory, T4, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VpcIngressConnectionFactory, T4> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VpcIngressConnectionFactory, InnerVpcIngressConnectionIngressVpcConfigurationFactory> WithIngressVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VpcIngressConnectionFactory> combinedResult, Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressVpcConfiguration(combinedResult.T5, subFactoryAction));
}
