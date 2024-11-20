var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.StorePatientVoiceAndData_ApiService>("apiservice");

builder.AddProject<Projects.StorePatientVoiceAndData_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
