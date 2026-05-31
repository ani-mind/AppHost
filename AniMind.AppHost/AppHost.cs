var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AniMind_Core_Api>("animind-core");

await builder.Build().RunAsync();
