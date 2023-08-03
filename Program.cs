using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SmartBuyApi.Authorization;
using SmartBuyApi.Data.Services.UserService;
using SmartBuyApi.DataBase;
using SmartBuyApi.DataBase.Tables;
using System.Text.Json.Serialization;
using Microsoft.Extensions.FileProviders;
using SmartBuyApi.Data.Mappers;
using SmartBuyApi.Data.Services.ShopService;
using SmartBuyApi.Data.Services.ProductService;

var builder = WebApplication.CreateBuilder(args);


var MyAllowSpecificOrigins = "LocalHostPolicy";
var connectionString = builder.Configuration.GetConnectionString("ShopApi") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

{
	var services = builder.Services;
	services.AddDbContext<ApplicationDbContext>(options =>
		options.UseSqlServer(connectionString));

	services.AddDefaultIdentity<SmartUser>(options =>
	{
		options.SignIn.RequireConfirmedAccount = false;
		options.User.RequireUniqueEmail = true;
		options.Password.RequireDigit = false;
		options.Password.RequiredLength = 6;
		options.Password.RequireNonAlphanumeric = false;
		options.Password.RequireUppercase = false;
		options.Password.RequireLowercase = false;
	}).AddRoles<IdentityRole>()
		.AddEntityFrameworkStores<ApplicationDbContext>();
	services.AddCors(options =>
	{
		options.AddPolicy(name: MyAllowSpecificOrigins,
						  policy =>
						  {
							  policy.WithOrigins("http://localhost:3000").AllowAnyMethod();
							  policy.WithOrigins("http://localhost:3000").AllowAnyHeader();
							  policy.WithOrigins("http://localhost:3000").AllowAnyOrigin();
							  policy.WithOrigins("http://localhost:3000").AllowCredentials();


						  });
	});
	services.AddProblemDetails();

	services.AddAutoMapper(typeof(AppMapProfile));
	services.AddControllers()
		.AddJsonOptions(x => x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
	services.AddEndpointsApiExplorer();
	services.AddScoped<IJwtUtils, JwtUtils>();
	services.AddScoped<IUserService, UserService>();
	services.AddScoped<IShopService, ShopService>();
	services.AddScoped<IProductService, ProductService>();


	services.AddHttpContextAccessor();

	services.AddSwaggerGen(option =>
	{
		option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
		option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
		{
			In = ParameterLocation.Header,
			Description = "Please enter a valid token",
			Name = "Authorization",
			Type = SecuritySchemeType.Http,
			BearerFormat = "JWT",
			Scheme = "Bearer"
		});
		option.AddSecurityRequirement(new OpenApiSecurityRequirement
		{
			{
				new OpenApiSecurityScheme
				{
					Reference = new OpenApiReference
					{
						Type=ReferenceType.SecurityScheme,
						Id="Bearer"
					}
				},
				new string[]{}
			}
		});
	});
}
var app = builder.Build();


{



if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();

    app.UseDeveloperExceptionPage();
}
var dir = Path.Combine(Directory.GetCurrentDirectory(), "Images");
if (!Directory.Exists(dir))
    Directory.CreateDirectory(dir);
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(dir),
    RequestPath = "/images"
});


	app.UseHttpsRedirection();
	app.UseCors(MyAllowSpecificOrigins);
	app.UseMiddleware<JwtMiddleware>();
	app.MapControllers();

	app.Run();
}