var builder = DistributedApplication.CreateBuilder(args);

var seq = builder.AddSeq("seq")
    .WithImageTag("2025.2")
    .WithDataVolume()
    .WithContainerName("animind-seq");

builder.AddProject<Projects.AniMind_Core_Api>("animind-core")
    .WithReference(seq);

await builder.Build().RunAsync();
