WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

var mailgunApiKey = builder.Configuration["MAILGUN_API_KEY"];
var mailgunDomain = builder.Configuration["MAILGUN_DOMAIN"];
var mailgunFromEmail = builder.Configuration["MAILGUN_FROM_EMAIL"];

Console.WriteLine($"Mailgun API Key: {mailgunApiKey}");
Console.WriteLine($"Mailgun Domain: {mailgunDomain}");
Console.WriteLine($"Mailgun From Email: {mailgunFromEmail}");

builder.CreateUmbracoBuilder()
	.AddBackOffice()
	.AddWebsite()
	.AddDeliveryApi()
	.AddComposers()
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

app.UseHttpsRedirection();

app.UseUmbraco()
	.WithMiddleware(u =>
	{
		u.UseBackOffice();
		u.UseWebsite();
	})
	.WithEndpoints(u =>
	{
		u.UseBackOfficeEndpoints();
		u.UseWebsiteEndpoints();
	});

await app.RunAsync();
