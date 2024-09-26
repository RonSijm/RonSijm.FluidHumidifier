using Humidifier.ECR;
using RonSijm.FluidHumidifier.Factories.Custom;
using RonSijm.FluidHumidifier.Factories.ECR;

namespace RonSijm.FluidHumidifier.Factories.IAM;

public static class RoleWithAssumeRolePolicyExtension
{
    public static PolicyDocumentFactory WithAssumeRolePolicy(this RoleFactory factory)
    {
        var subFactory = factory.CreateSubFactory(() => new PolicyDocumentFactory());

        var action = new Action<Role>(x =>
        {
            var document = subFactory.Build();
            x.AssumeRolePolicyDocument = document;
        });

        factory.ExtendedActions.Enqueue(action);

        return subFactory;
    }
}

public static class RepositoryWithAssumeRolePolicyExtension
{
    public static PolicyDocumentFactory WithRepositoryPolicyText(this RepositoryFactory factory)
    {
        var subFactory = factory.CreateSubFactory(() => new PolicyDocumentFactory());

        var action = new Action<Repository>(x =>
        {
            var document = subFactory.Build();
            x.RepositoryPolicyText = document;
        });

        factory.ExtendedActions.Enqueue(action);

        return subFactory;
    }
}