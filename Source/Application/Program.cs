var currentDirectory = Directory.GetCurrentDirectory();

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
	Args = args,
	ContentRootPath = currentDirectory,
	WebRootPath = currentDirectory
});

var application = builder.Build();

application.UseStaticFiles();

application.Run();