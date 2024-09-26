// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectEnvironmentFactory(Action<Humidifier.CodeBuild.ProjectTypes.Environment> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.Environment>
{

    internal InnerProjectProjectFleetFactory FleetFactory { get; set; }

    internal InnerProjectRegistryCredentialFactory RegistryCredentialFactory { get; set; }

    protected override Humidifier.CodeBuild.ProjectTypes.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.CodeBuild.ProjectTypes.Environment();

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ProjectTypes.Environment result)
    {
        base.CreateChildren(result);

        result.Fleet ??= FleetFactory?.Build();
        result.RegistryCredential ??= RegistryCredentialFactory?.Build();
    }

} // End Of Class

public static class InnerProjectEnvironmentFactoryExtensions
{
    public static CombinedResult<InnerProjectEnvironmentFactory, InnerProjectProjectFleetFactory> WithFleet(this InnerProjectEnvironmentFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null)
    {
        parentFactory.FleetFactory = new InnerProjectProjectFleetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FleetFactory);
    }

    public static CombinedResult<InnerProjectEnvironmentFactory, InnerProjectRegistryCredentialFactory> WithRegistryCredential(this InnerProjectEnvironmentFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null)
    {
        parentFactory.RegistryCredentialFactory = new InnerProjectRegistryCredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RegistryCredentialFactory);
    }

    public static CombinedResult<InnerProjectEnvironmentFactory, T1, InnerProjectProjectFleetFactory> WithFleet<T1>(this CombinedResult<InnerProjectEnvironmentFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, WithFleet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, InnerProjectProjectFleetFactory> WithFleet<T1>(this CombinedResult<T1, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, WithFleet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, InnerProjectProjectFleetFactory> WithFleet<T1, T2>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, InnerProjectProjectFleetFactory> WithFleet<T1, T2>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, InnerProjectProjectFleetFactory> WithFleet<T1, T2>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, T4, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3, T4>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, T4, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, T4, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, T4, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectEnvironmentFactory, InnerProjectProjectFleetFactory> WithFleet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFleet(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1>(this CombinedResult<InnerProjectEnvironmentFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistryCredential(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1>(this CombinedResult<T1, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistryCredential(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, T4, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3, T4>(this CombinedResult<InnerProjectEnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, T4, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectEnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, T4, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectEnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, T4, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectEnvironmentFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectEnvironmentFactory, InnerProjectRegistryCredentialFactory> WithRegistryCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectEnvironmentFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistryCredential(combinedResult.T5, subFactoryAction));
}
