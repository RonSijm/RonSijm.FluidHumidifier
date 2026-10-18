using Humidifier;
using Humidifier.S3;
using RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;
using RonSijm.FluidHumidifier.Features.Decorating.Decorators.S3;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;
using RonSijm.FluidHumidifier.Features.Factories.Base;
using RonSijm.FluidHumidifier.Features.Helpers;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Tests;

public class UnionDecoratorTests
{
    [Fact]
    public void NameTagsAreAddedWhenTagsAreUnset()
    {
        var bucket = new Bucket { BucketName = "Images" };
        new HaveTagsDecorator().Decorate(bucket);
        var nameTag = Assert.IsType<Tag>(UnionValue.Unwrap(Assert.Single(bucket.Tags.GetItems())));
        Assert.Equal("Images", nameTag.Value.GetLiteral());
    }

    [Fact]
    public void NameTagsAreAddedWithoutReplacingExistingTagsOrExpressions()
    {
        var decorator = new HaveTagsDecorator();
        var reference = Fn.Ref("ExtraTag");
        var bucket = new Bucket
        {
            BucketName = "Images",
            Tags = new Union<Tag, BaseFunction>[] { new Tag { Key = "Team", Value = "App" }, reference }
        };
        decorator.Decorate(bucket);
        var tags = bucket.Tags.GetItems();
        Assert.Equal(3, tags.Count);
        Assert.Same(reference, UnionValue.Unwrap(tags[1]));
        var nameTag = Assert.IsType<Tag>(UnionValue.Unwrap(tags[2]));
        Assert.Equal("Name", nameTag.Key.GetLiteral());
        Assert.Equal("Images", nameTag.Value.GetLiteral());

        decorator.Decorate(bucket);
        Assert.Equal(3, bucket.Tags.GetItems().Count);

        bucket.Tags = new[] { new Tag { Key = "Name", Value = "Custom" } };
        decorator.Decorate(bucket);
        Assert.Single(bucket.Tags.GetItems());
        Assert.Equal("Custom", Assert.IsType<Tag>(UnionValue.Unwrap(bucket.Tags.GetItems()[0])).Value.GetLiteral());
    }

    [Fact]
    public void WholeListExpressionsAreLeftDeferred()
    {
        var expression = Fn.Ref("Tags");
        var bucket = new Bucket { BucketName = "Images", Tags = expression };
        new HaveTagsDecorator().Decorate(bucket);
        Assert.Same(expression, UnionValue.Unwrap(bucket.Tags));
    }

    [Fact]
    public void BucketNamesAreLoweredOnlyWhenLiteral()
    {
        var decorator = new BucketNameToLowerDecorator();
        var bucket = new Bucket { BucketName = "Images" };
        decorator.Decorate(bucket);
        Assert.Equal("images", bucket.BucketName.GetLiteral());

        var expression = Fn.Sub("${AWS::StackName}-images");
        bucket.BucketName = expression;
        decorator.Decorate(bucket);
        Assert.Same(expression, UnionValue.Unwrap(bucket.BucketName));
    }

    [Fact]
    public void ReflectionInjectionUnwrapsPropertyAndInheritedVariableValues()
    {
        var decorator = new CaptureResourceName();
        var orchestrator = new DecoratorOrchestrator([decorator]);
        var factory = new NamedTarget { Decorator = orchestrator, ResourceName = "Images" };
        PropertiesDecorator.FillInProperties(factory);
        Assert.Equal("Images", decorator.ResourceName);

        orchestrator.Variables["ResourceName"] = (Union<string, BaseFunction>)"Inherited";
        PropertiesDecorator.FillInProperties(new VariableTarget { Decorator = orchestrator });
        Assert.Equal("Inherited", decorator.ResourceName);
    }

    private class NamedTarget : IHaveDecorators
    {
        public DecoratorOrchestrator Decorator { get; set; }
        public Union<string, BaseFunction>? ResourceName { get; set; }
    }

    private class VariableTarget : IHaveDecorators
    {
        public DecoratorOrchestrator Decorator { get; set; }
    }

    private class CaptureResourceName : BaseDecorator, IWantResourceName
    {
        public string ResourceName { get; set; }
        public override int Rank { get; set; }
        public override bool CanHandle(object target) => true;
        public override void Decorate(object target) { }
    }
}
