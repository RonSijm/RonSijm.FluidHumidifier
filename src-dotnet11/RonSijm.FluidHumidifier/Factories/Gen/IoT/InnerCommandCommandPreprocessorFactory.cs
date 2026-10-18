// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCommandCommandPreprocessorFactory(Action<Humidifier.IoT.CommandTypes.CommandPreprocessor> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CommandTypes.CommandPreprocessor>
{

    internal InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory AwsJsonSubstitutionFactory { get; set; }

    protected override Humidifier.IoT.CommandTypes.CommandPreprocessor Create()
    {
        var commandPreprocessorResult = CreateCommandPreprocessor();
        factoryAction?.Invoke(commandPreprocessorResult);

        return commandPreprocessorResult;
    }

    private Humidifier.IoT.CommandTypes.CommandPreprocessor CreateCommandPreprocessor()
    {
        var commandPreprocessorResult = new Humidifier.IoT.CommandTypes.CommandPreprocessor();

        return commandPreprocessorResult;
    }
    public override void CreateChildren(Humidifier.IoT.CommandTypes.CommandPreprocessor result)
    {
        base.CreateChildren(result);

        result.AwsJsonSubstitution ??= AwsJsonSubstitutionFactory?.Build();
    }

} // End Of Class

public static class InnerCommandCommandPreprocessorFactoryExtensions
{
    public static CombinedResult<InnerCommandCommandPreprocessorFactory, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution(this InnerCommandCommandPreprocessorFactory parentFactory, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null)
    {
        parentFactory.AwsJsonSubstitutionFactory = new InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsJsonSubstitutionFactory);
    }

    public static CombinedResult<InnerCommandCommandPreprocessorFactory, T1, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1>(this CombinedResult<InnerCommandCommandPreprocessorFactory, T1> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCommandCommandPreprocessorFactory, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1>(this CombinedResult<T1, InnerCommandCommandPreprocessorFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2>(this CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2>(this CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2>(this CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2, T3, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3>(this CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2, T3, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3>(this CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory, T3, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3>(this CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCommandCommandPreprocessorFactory, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCommandCommandPreprocessorFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2, T3, T4, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3, T4>(this CombinedResult<InnerCommandCommandPreprocessorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2, T3, T4, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3, T4>(this CombinedResult<T1, InnerCommandCommandPreprocessorFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory, T3, T4, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCommandCommandPreprocessorFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCommandCommandPreprocessorFactory, T4, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCommandCommandPreprocessorFactory, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCommandCommandPreprocessorFactory, InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory> WithAwsJsonSubstitution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCommandCommandPreprocessorFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsJsonSubstitution(combinedResult.T5, subFactoryAction).T2);
}
