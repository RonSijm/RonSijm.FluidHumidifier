using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Factories.Custom;

namespace RonSijm.FluidHumidifier.Factories.IAM;

public static class PolicyWithDocumentExtension
{
    public static PolicyDocumentFactory WithDocument<T>(this BaseFactory<T> factory) where T : IHavePolicyDocument
    {
        var subFactory = factory.CreateSubFactory(() => new PolicyDocumentFactory());

        var action = new Action<T>(x =>
        {
            var document = subFactory.Build();
            x.PolicyDocument = document;
        });

        factory.ExtendedActions.Enqueue(action);

        return subFactory;
    }
}