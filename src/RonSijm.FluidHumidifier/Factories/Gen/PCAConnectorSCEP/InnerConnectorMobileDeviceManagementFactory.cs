// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorSCEP;

public class InnerConnectorMobileDeviceManagementFactory(Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement>
{

    internal InnerConnectorIntuneConfigurationFactory IntuneFactory { get; set; }

    protected override Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement Create()
    {
        var mobileDeviceManagementResult = CreateMobileDeviceManagement();
        factoryAction?.Invoke(mobileDeviceManagementResult);

        return mobileDeviceManagementResult;
    }

    private Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement CreateMobileDeviceManagement()
    {
        var mobileDeviceManagementResult = new Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement();

        return mobileDeviceManagementResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement result)
    {
        base.CreateChildren(result);

        result.Intune ??= IntuneFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorMobileDeviceManagementFactoryExtensions
{
    public static CombinedResult<InnerConnectorMobileDeviceManagementFactory, InnerConnectorIntuneConfigurationFactory> WithIntune(this InnerConnectorMobileDeviceManagementFactory parentFactory, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null)
    {
        parentFactory.IntuneFactory = new InnerConnectorIntuneConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntuneFactory);
    }

    public static CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, InnerConnectorIntuneConfigurationFactory> WithIntune<T1>(this CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntune(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, InnerConnectorIntuneConfigurationFactory> WithIntune<T1>(this CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntune(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2>(this CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2>(this CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2>(this CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2, T3, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3>(this CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2, T3, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3>(this CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory, T3, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorMobileDeviceManagementFactory, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorMobileDeviceManagementFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2, T3, T4, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3, T4>(this CombinedResult<InnerConnectorMobileDeviceManagementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2, T3, T4, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorMobileDeviceManagementFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory, T3, T4, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorMobileDeviceManagementFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorMobileDeviceManagementFactory, T4, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorMobileDeviceManagementFactory, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorMobileDeviceManagementFactory, InnerConnectorIntuneConfigurationFactory> WithIntune<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorMobileDeviceManagementFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntune(combinedResult.T5, subFactoryAction));
}
