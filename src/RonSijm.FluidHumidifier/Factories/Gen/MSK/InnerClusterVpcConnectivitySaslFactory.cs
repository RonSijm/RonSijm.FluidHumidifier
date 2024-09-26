// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivitySaslFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl>
{

    internal InnerClusterVpcConnectivityIamFactory IamFactory { get; set; }

    internal InnerClusterVpcConnectivityScramFactory ScramFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivitySasl Create()
    {
        var vpcConnectivitySaslResult = CreateVpcConnectivitySasl();
        factoryAction?.Invoke(vpcConnectivitySaslResult);

        return vpcConnectivitySaslResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivitySasl CreateVpcConnectivitySasl()
    {
        var vpcConnectivitySaslResult = new Humidifier.MSK.ClusterTypes.VpcConnectivitySasl();

        return vpcConnectivitySaslResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.VpcConnectivitySasl result)
    {
        base.CreateChildren(result);

        result.Iam ??= IamFactory?.Build();
        result.Scram ??= ScramFactory?.Build();
    }

} // End Of Class

public static class InnerClusterVpcConnectivitySaslFactoryExtensions
{
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityIamFactory> WithIam(this InnerClusterVpcConnectivitySaslFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null)
    {
        parentFactory.IamFactory = new InnerClusterVpcConnectivityIamFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamFactory);
    }

    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityScramFactory> WithScram(this InnerClusterVpcConnectivitySaslFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null)
    {
        parentFactory.ScramFactory = new InnerClusterVpcConnectivityScramFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScramFactory);
    }

    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, InnerClusterVpcConnectivityIamFactory> WithIam<T1>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityIamFactory> WithIam<T1>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, T4, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, T4, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, T4, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, T4, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, InnerClusterVpcConnectivityScramFactory> WithScram<T1>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityScramFactory> WithScram<T1>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, T4, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<InnerClusterVpcConnectivitySaslFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, T4, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterVpcConnectivitySaslFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, T4, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterVpcConnectivitySaslFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, T4, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterVpcConnectivitySaslFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory, InnerClusterVpcConnectivityScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterVpcConnectivitySaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T5, subFactoryAction));
}
