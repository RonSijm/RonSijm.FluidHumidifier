// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.M2.Application> factoryAction = null) : ResourceFactory<Humidifier.M2.Application>(resourceName)
{

    internal InnerApplicationDefinitionFactory DefinitionFactory { get; set; }

    protected override Humidifier.M2.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.M2.Application CreateApplication()
    {
        var applicationResult = new Humidifier.M2.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.M2.Application result)
    {
        base.CreateChildren(result);

        result.Definition ??= DefinitionFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationDefinitionFactory> WithDefinition(this ApplicationFactory parentFactory, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerApplicationDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationDefinitionFactory> WithDefinition<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationDefinitionFactory> WithDefinition<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.M2.ApplicationTypes.Definition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
