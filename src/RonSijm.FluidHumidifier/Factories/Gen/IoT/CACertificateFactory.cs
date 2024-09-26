// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class CACertificateFactory(string resourceName = null, Action<Humidifier.IoT.CACertificate> factoryAction = null) : ResourceFactory<Humidifier.IoT.CACertificate>(resourceName)
{

    internal InnerCACertificateRegistrationConfigFactory RegistrationConfigFactory { get; set; }

    protected override Humidifier.IoT.CACertificate Create()
    {
        var cACertificateResult = CreateCACertificate();
        factoryAction?.Invoke(cACertificateResult);

        return cACertificateResult;
    }

    private Humidifier.IoT.CACertificate CreateCACertificate()
    {
        var cACertificateResult = new Humidifier.IoT.CACertificate
        {
            GivenName = InputResourceName,
        };

        return cACertificateResult;
    }
    public override void CreateChildren(Humidifier.IoT.CACertificate result)
    {
        base.CreateChildren(result);

        result.RegistrationConfig ??= RegistrationConfigFactory?.Build();
    }

} // End Of Class

public static class CACertificateFactoryExtensions
{
    public static CombinedResult<CACertificateFactory, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig(this CACertificateFactory parentFactory, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null)
    {
        parentFactory.RegistrationConfigFactory = new InnerCACertificateRegistrationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RegistrationConfigFactory);
    }

    public static CombinedResult<CACertificateFactory, T1, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1>(this CombinedResult<CACertificateFactory, T1> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CACertificateFactory, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1>(this CombinedResult<T1, CACertificateFactory> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CACertificateFactory, T1, T2, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2>(this CombinedResult<CACertificateFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CACertificateFactory, T2, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2>(this CombinedResult<T1, CACertificateFactory, T2> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CACertificateFactory, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2>(this CombinedResult<T1, T2, CACertificateFactory> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CACertificateFactory, T1, T2, T3, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3>(this CombinedResult<CACertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CACertificateFactory, T2, T3, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3>(this CombinedResult<T1, CACertificateFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CACertificateFactory, T3, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, CACertificateFactory, T3> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CACertificateFactory, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CACertificateFactory> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CACertificateFactory, T1, T2, T3, T4, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3, T4>(this CombinedResult<CACertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CACertificateFactory, T2, T3, T4, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, CACertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CACertificateFactory, T3, T4, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CACertificateFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CACertificateFactory, T4, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CACertificateFactory, T4> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CACertificateFactory, InnerCACertificateRegistrationConfigFactory> WithRegistrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CACertificateFactory> combinedResult, Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistrationConfig(combinedResult.T5, subFactoryAction));
}
