// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerAssociationInstanceAssociationOutputLocationFactory(Action<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation> factoryAction = null) : SubResourceFactory<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation>
{

    internal InnerAssociationS3OutputLocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation Create()
    {
        var instanceAssociationOutputLocationResult = CreateInstanceAssociationOutputLocation();
        factoryAction?.Invoke(instanceAssociationOutputLocationResult);

        return instanceAssociationOutputLocationResult;
    }

    private Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation CreateInstanceAssociationOutputLocation()
    {
        var instanceAssociationOutputLocationResult = new Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation();

        return instanceAssociationOutputLocationResult;
    }
    public override void CreateChildren(Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerAssociationInstanceAssociationOutputLocationFactoryExtensions
{
    public static CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, InnerAssociationS3OutputLocationFactory> WithS3Location(this InnerAssociationInstanceAssociationOutputLocationFactory parentFactory, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerAssociationS3OutputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, InnerAssociationS3OutputLocationFactory> WithS3Location<T1>(this CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, InnerAssociationS3OutputLocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2, T3, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2, T3, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory, T3, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory, T3> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2, T3, T4, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerAssociationInstanceAssociationOutputLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2, T3, T4, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssociationInstanceAssociationOutputLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory, T3, T4, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssociationInstanceAssociationOutputLocationFactory, T3, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory, T4, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssociationInstanceAssociationOutputLocationFactory, T4> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssociationInstanceAssociationOutputLocationFactory, InnerAssociationS3OutputLocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssociationInstanceAssociationOutputLocationFactory> combinedResult, Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction));
}
