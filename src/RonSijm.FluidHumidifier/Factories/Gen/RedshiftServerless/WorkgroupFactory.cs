// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class WorkgroupFactory(string resourceName = null, Action<Humidifier.RedshiftServerless.Workgroup> factoryAction = null) : ResourceFactory<Humidifier.RedshiftServerless.Workgroup>(resourceName)
{

    internal List<InnerWorkgroupConfigParameterFactory> ConfigParametersFactories { get; set; } = [];

    protected override Humidifier.RedshiftServerless.Workgroup Create()
    {
        var workgroupResult = CreateWorkgroup();
        factoryAction?.Invoke(workgroupResult);

        return workgroupResult;
    }

    private Humidifier.RedshiftServerless.Workgroup CreateWorkgroup()
    {
        var workgroupResult = new Humidifier.RedshiftServerless.Workgroup
        {
            GivenName = InputResourceName,
        };

        return workgroupResult;
    }
    public override void CreateChildren(Humidifier.RedshiftServerless.Workgroup result)
    {
        base.CreateChildren(result);

        result.ConfigParameters = ConfigParametersFactories.Any() ? ConfigParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class WorkgroupFactoryExtensions
{
    public static CombinedResult<WorkgroupFactory, InnerWorkgroupConfigParameterFactory> WithConfigParameters(this WorkgroupFactory parentFactory, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null)
    {
        var factory = new InnerWorkgroupConfigParameterFactory(subFactoryAction);
        parentFactory.ConfigParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkgroupFactory, T1, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1>(this CombinedResult<WorkgroupFactory, T1> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkgroupFactory, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1>(this CombinedResult<T1, WorkgroupFactory> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkgroupFactory, T1, T2, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2>(this CombinedResult<WorkgroupFactory, T1, T2> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkgroupFactory, T2, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2>(this CombinedResult<T1, WorkgroupFactory, T2> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkgroupFactory, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2>(this CombinedResult<T1, T2, WorkgroupFactory> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkgroupFactory, T1, T2, T3, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3>(this CombinedResult<WorkgroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkgroupFactory, T2, T3, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3>(this CombinedResult<T1, WorkgroupFactory, T2, T3> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkgroupFactory, T3, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3>(this CombinedResult<T1, T2, WorkgroupFactory, T3> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkgroupFactory, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkgroupFactory> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkgroupFactory, T1, T2, T3, T4, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3, T4>(this CombinedResult<WorkgroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkgroupFactory, T2, T3, T4, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3, T4>(this CombinedResult<T1, WorkgroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkgroupFactory, T3, T4, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkgroupFactory, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkgroupFactory, T4, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkgroupFactory, T4> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkgroupFactory, InnerWorkgroupConfigParameterFactory> WithConfigParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkgroupFactory> combinedResult, Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigParameters(combinedResult.T5, subFactoryAction));
}
