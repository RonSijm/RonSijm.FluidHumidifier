// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class OrganizationConformancePackFactory(string resourceName = null, Action<Humidifier.Config.OrganizationConformancePack> factoryAction = null) : ResourceFactory<Humidifier.Config.OrganizationConformancePack>(resourceName)
{

    internal List<InnerOrganizationConformancePackConformancePackInputParameterFactory> ConformancePackInputParametersFactories { get; set; } = [];

    protected override Humidifier.Config.OrganizationConformancePack Create()
    {
        var organizationConformancePackResult = CreateOrganizationConformancePack();
        factoryAction?.Invoke(organizationConformancePackResult);

        return organizationConformancePackResult;
    }

    private Humidifier.Config.OrganizationConformancePack CreateOrganizationConformancePack()
    {
        var organizationConformancePackResult = new Humidifier.Config.OrganizationConformancePack
        {
            GivenName = InputResourceName,
        };

        return organizationConformancePackResult;
    }
    public override void CreateChildren(Humidifier.Config.OrganizationConformancePack result)
    {
        base.CreateChildren(result);

        result.ConformancePackInputParameters = ConformancePackInputParametersFactories.Any() ? ConformancePackInputParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class OrganizationConformancePackFactoryExtensions
{
    public static CombinedResult<OrganizationConformancePackFactory, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters(this OrganizationConformancePackFactory parentFactory, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null)
    {
        var factory = new InnerOrganizationConformancePackConformancePackInputParameterFactory(subFactoryAction);
        parentFactory.ConformancePackInputParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<OrganizationConformancePackFactory, T1, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1>(this CombinedResult<OrganizationConformancePackFactory, T1> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OrganizationConformancePackFactory, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1>(this CombinedResult<T1, OrganizationConformancePackFactory> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<OrganizationConformancePackFactory, T1, T2, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<OrganizationConformancePackFactory, T1, T2> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OrganizationConformancePackFactory, T2, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<T1, OrganizationConformancePackFactory, T2> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OrganizationConformancePackFactory, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<T1, T2, OrganizationConformancePackFactory> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<OrganizationConformancePackFactory, T1, T2, T3, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<OrganizationConformancePackFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OrganizationConformancePackFactory, T2, T3, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, OrganizationConformancePackFactory, T2, T3> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OrganizationConformancePackFactory, T3, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, T2, OrganizationConformancePackFactory, T3> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OrganizationConformancePackFactory, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, OrganizationConformancePackFactory> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<OrganizationConformancePackFactory, T1, T2, T3, T4, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<OrganizationConformancePackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OrganizationConformancePackFactory, T2, T3, T4, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, OrganizationConformancePackFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OrganizationConformancePackFactory, T3, T4, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, OrganizationConformancePackFactory, T3, T4> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OrganizationConformancePackFactory, T4, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OrganizationConformancePackFactory, T4> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, OrganizationConformancePackFactory, InnerOrganizationConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OrganizationConformancePackFactory> combinedResult, Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T5, subFactoryAction));
}
