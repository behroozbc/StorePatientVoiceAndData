var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.StorePatientVoiceAndData>("storepatientvoiceanddata");

builder.Build().Run();
