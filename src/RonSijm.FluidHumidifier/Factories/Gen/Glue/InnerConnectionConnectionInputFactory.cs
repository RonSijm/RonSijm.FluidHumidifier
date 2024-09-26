// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionConnectionInputFactory(Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.ConnectionInput>
{

    internal InnerConnectionPhysicalConnectionRequirementsFactory PhysicalConnectionRequirementsFactory { get; set; }

    protected override Humidifier.Glue.ConnectionTypes.ConnectionInput Create()
    {
        var connectionInputResult = CreateConnectionInput();
        factoryAction?.Invoke(connectionInputResult);

        return connectionInputResult;
    }

    private Humidifier.Glue.ConnectionTypes.ConnectionInput CreateConnectionInput()
    {
        var connectionInputResult = new Humidifier.Glue.ConnectionTypes.ConnectionInput();

        return connectionInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.ConnectionTypes.ConnectionInput result)
    {
        base.CreateChildren(result);

        result.PhysicalConnectionRequirements ??= PhysicalConnectionRequirementsFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionConnectionInputFactoryExtensions
{
    public static CombinedResult<InnerConnectionConnectionInputFactory, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements(this InnerConnectionConnectionInputFactory parentFactory, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null)
    {
        parentFactory.PhysicalConnectionRequirementsFactory = new InnerConnectionPhysicalConnectionRequirementsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PhysicalConnectionRequirementsFactory);
    }

    public static CombinedResult<InnerConnectionConnectionInputFactory, T1, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1>(this CombinedResult<InnerConnectionConnectionInputFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectionInputFactory, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1>(this CombinedResult<T1, InnerConnectionConnectionInputFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectionInputFactory, T1, T2, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2>(this CombinedResult<InnerConnectionConnectionInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectionInputFactory, T2, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2>(this CombinedResult<T1, InnerConnectionConnectionInputFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectionInputFactory, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2>(this CombinedResult<T1, T2, InnerConnectionConnectionInputFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectionInputFactory, T1, T2, T3, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3>(this CombinedResult<InnerConnectionConnectionInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectionInputFactory, T2, T3, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3>(this CombinedResult<T1, InnerConnectionConnectionInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectionInputFactory, T3, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionConnectionInputFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionConnectionInputFactory, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionConnectionInputFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectionInputFactory, T1, T2, T3, T4, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3, T4>(this CombinedResult<InnerConnectionConnectionInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectionInputFactory, T2, T3, T4, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionConnectionInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectionInputFactory, T3, T4, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionConnectionInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionConnectionInputFactory, T4, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionConnectionInputFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionConnectionInputFactory, InnerConnectionPhysicalConnectionRequirementsFactory> WithPhysicalConnectionRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionConnectionInputFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalConnectionRequirements(combinedResult.T5, subFactoryAction));
}
