using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Editor
{
	public class Startup : WebApi.Startup
	{
		public Startup(IConfiguration configuration) : base(configuration)
		{
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public override void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
			services.AddControllers();
			////services.AddAuthorization(options => {
			////	options.AddPolicy("Editor", policy => policy.RequireClaim("perfil", "editor"));
			////	options.AddPolicy("Interactive", policy => policy.RequireClaim("int"));
			////});
			////var key = Encoding.ASCII.GetBytes("chave-cripto");
			////services.AddAuthentication(opt => {
			////	opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			////	opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			////}).AddJwtBearer(opt => {
			////	opt.RequireHttpsMetadata = false;
			////	opt.SaveToken = true;
			////	opt.TokenValidationParameters = new TokenValidationParameters {
			////		ValidateIssuerSigningKey = true,
			////		IssuerSigningKey = new SymmetricSecurityKey(key),
			////		ValidateIssuer = false,
			////		ValidateAudience = false
			////	};
			////});
			services.AddSwaggerGen(opt => {
				opt.SwaggerDoc("v1", new OpenApiInfo { Title = "ICI.Clipping.WebApi.Editor", Version = "v1" });
				////opt.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme {
				////	Name = "Authorization",
				////	Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
				////	In = ParameterLocation.Header,
				////	Type = SecuritySchemeType.ApiKey,
				////	Scheme = "Bearer"
				////});
				////opt.AddSecurityRequirement(new OpenApiSecurityRequirement {
				////	{
				////		new OpenApiSecurityScheme {
				////			Reference = new OpenApiReference {
				////				Type = ReferenceType.SecurityScheme,
				////				Id = "bearer"
				////			}
				////		},
				////		new List<string>()
				////	}
				////});
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseFileServer();

			////app.UseAuthentication();

			////app.UseAuthorization();

			app.UseEndpoints(endpoints => {
				endpoints.MapControllers();
			});
		}
	}
}
