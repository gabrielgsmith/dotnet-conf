using Aspire.DotnetConf.Core.ContributorAggregate;

namespace Aspire.DotnetConf.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
