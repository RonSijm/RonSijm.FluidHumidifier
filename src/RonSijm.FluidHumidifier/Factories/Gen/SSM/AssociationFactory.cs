// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class AssociationFactory(string resourceName = null, Action<Humidifier.SSM.Association> factoryAction = null) : ResourceFactory<Humidifier.SSM.Association>(resourceName)
{

    internal List<InnerAssociationTargetFactory> TargetsFactories { get; set; } = [];

    internal InnerAssociationInstanceAssociationOutputLocationFactory OutputLocationFactory { get; set; }

    protected override Humidifier.SSM.Association Create()
    {
        var associationResult = CreateAssociation();
        factoryAction?.Invoke(associationResult);

        return associationResult;
    }

    private Humidifier.SSM.Association CreateAssociation()
    {
        var associationResult = new Humidifier.SSM.Association
        {
            GivenName = InputResourceName,
        };

        return associationResult;
    }
    public override void CreateChildren(Humidifier.SSM.Association result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
        result.OutputLocation ??= OutputLocationFactory?.Build();
    }

} // End Of Class

public static class AssociationFactoryExtensions
{
    public static CombinedResult<AssociationFactory, InnerAssociationTargetFactory> WithTargets(this AssociationFactory parentFactory, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null)
    {
        var factory = new InnerAssociationTargetFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssociationFactory, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation(this AssociationFactory parentFactory, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null)
    {
        parentFactory.OutputLocationFactory = new InnerAssociationInstanceAssociationOutputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputLocationFactory);
    }

    public static CombinedResult<AssociationFactory, T1, InnerAssociationTargetFactory> WithTargets<T1>(this CombinedResult<AssociationFactory, T1> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, InnerAssociationTargetFactory> WithTargets<T1>(this CombinedResult<T1, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, InnerAssociationTargetFactory> WithTargets<T1, T2>(this CombinedResult<AssociationFactory, T1, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, InnerAssociationTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, AssociationFactory, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, InnerAssociationTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, T3, InnerAssociationTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<AssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, T3, InnerAssociationTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, AssociationFactory, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, T3, InnerAssociationTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, AssociationFactory, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssociationFactory, InnerAssociationTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, T3, T4, InnerAssociationTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<AssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, T3, T4, InnerAssociationTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, AssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, T3, T4, InnerAssociationTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssociationFactory, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssociationFactory, T4, InnerAssociationTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssociationFactory, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssociationFactory, InnerAssociationTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1>(this CombinedResult<AssociationFactory, T1> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1>(this CombinedResult<T1, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2>(this CombinedResult<AssociationFactory, T1, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2>(this CombinedResult<T1, AssociationFactory, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2>(this CombinedResult<T1, T2, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3>(this CombinedResult<AssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3>(this CombinedResult<T1, AssociationFactory, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, T3, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3>(this CombinedResult<T1, T2, AssociationFactory, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssociationFactory, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssociationFactory, T1, T2, T3, T4, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3, T4>(this CombinedResult<AssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssociationFactory, T2, T3, T4, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, AssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssociationFactory, T3, T4, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssociationFactory, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssociationFactory, T4, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssociationFactory, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssociationFactory, InnerAssociationInstanceAssociationOutputLocationFactory> WithOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssociationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLocation(combinedResult.T5, subFactoryAction));
}
