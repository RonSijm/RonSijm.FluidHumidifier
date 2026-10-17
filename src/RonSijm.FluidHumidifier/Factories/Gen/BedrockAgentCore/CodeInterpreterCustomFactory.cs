// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class CodeInterpreterCustomFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustom> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreterCustom>(resourceName)
{

    internal List<InnerCodeInterpreterCustomCertificateFactory> CertificatesFactories { get; set; } = [];

    internal InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CodeInterpreterCustom Create()
    {
        var codeInterpreterCustomResult = CreateCodeInterpreterCustom();
        factoryAction?.Invoke(codeInterpreterCustomResult);

        return codeInterpreterCustomResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreterCustom CreateCodeInterpreterCustom()
    {
        var codeInterpreterCustomResult = new Humidifier.BedrockAgentCore.CodeInterpreterCustom
        {
            GivenName = InputResourceName,
        };

        return codeInterpreterCustomResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CodeInterpreterCustom result)
    {
        base.CreateChildren(result);

        result.Certificates = CertificatesFactories.Any() ? CertificatesFactories.Select(x => x.Build()).ToList() : null;
        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class CodeInterpreterCustomFactoryExtensions
{
    public static CombinedResult<CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCertificateFactory> WithCertificates(this CodeInterpreterCustomFactory parentFactory, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null)
    {
        var factory = new InnerCodeInterpreterCustomCertificateFactory(subFactoryAction);
        parentFactory.CertificatesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration(this CodeInterpreterCustomFactory parentFactory, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<CodeInterpreterCustomFactory, T1, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1>(this CombinedResult<CodeInterpreterCustomFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1>(this CombinedResult<T1, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, T4, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, T4, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, T4, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, T4, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCertificateFactory> WithCertificates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificates(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<CodeInterpreterCustomFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<CodeInterpreterCustomFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CodeInterpreterCustomFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeInterpreterCustomFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeInterpreterCustomFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodeInterpreterCustomFactory, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeInterpreterCustomFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction).T2);
}
