using AppDataRepository.Admins;
using AppDataRepository.Categorys;
using AppDataRepository.Comments;
using AppDataRepository.Customers;
using AppDataRepository.CustomersRequests;
using AppDataRepository.Db.Context;
using AppDataRepository.Experts;
using AppDataRepository.ExpertsRequests;
using AppDataRepository.Photos;
using AppDataRepository.Provinces;
using AppDataRepository.SubCategorys;
using AppDataRepository.Works;
using AppDomainCore.Account.AppService;
using AppDomainCore.Admins.Contract.AppService;
using AppDomainCore.Admins.Contract.Repository;
using AppDomainCore.Admins.Contract.Service;
using AppDomainCore.Base;
using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.Categorys.Contract.Repository;
using AppDomainCore.Categorys.Contract.Service;
using AppDomainCore.Comments.Contract.AppService;
using AppDomainCore.Comments.Contract.Repository;
using AppDomainCore.Comments.Contract.Service;
using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.Contract.Repository;
using AppDomainCore.Customers.Contract.Service;
using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.CustomersRequests.Contract.Repository;
using AppDomainCore.CustomersRequests.Contract.Service;
using AppDomainCore.Experts.Contract.AppService;
using AppDomainCore.Experts.Contract.Repository;
using AppDomainCore.Experts.Contract.Service;
using AppDomainCore.ExpertsRequests.Contract.AppService;
using AppDomainCore.ExpertsRequests.Contract.Repository;
using AppDomainCore.ExpertsRequests.Contract.Service;
using AppDomainCore.Photos.Contract.AppService;
using AppDomainCore.Photos.Contract.Repository;
using AppDomainCore.Photos.Contract.Service;
using AppDomainCore.Provinces.Contract.AppService;
using AppDomainCore.Provinces.Contract.Repository;
using AppDomainCore.Provinces.Contract.Service;
using AppDomainCore.SiteSetting;
using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.SubCategorys.Contract.Repository;
using AppDomainCore.SubCategorys.Contract.Service;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Contract.AppService;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.Contract.Service;
using AppEndpoin_API.Filters;
using DomainAppService.Account;
using DomainAppService.Admins;
using DomainAppService.Categorys;
using DomainAppService.Comments;
using DomainAppService.Customers;
using DomainAppService.CustomersRequests;
using DomainAppService.Experts;
using DomainAppService.ExpertsRequests;
using DomainAppService.Photos;
using DomainAppService.Provinces;
using DomainAppService.SubCategorys;
using DomainAppService.Works;
using DomainService.Admins;
using DomainService.Base;
using DomainService.Categorys;
using DomainService.Comments;
using DomainService.Customers;
using DomainService.CustomersRequests;
using DomainService.Experts;
using DomainService.ExpertsRequests;
using DomainService.Photos;
using DomainService.Provinces;
using DomainService.SubCategorys;
using DomainService.Works;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ApiFilter>();

builder.Services.AddControllers()
	.AddJsonOptions(x =>
	{
		x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
		x.JsonSerializerOptions.WriteIndented = true; // Optional
	});



var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var siteSettings = configuration.GetSection("SiteSettings").Get<SiteSettings>();
builder.Services.AddSingleton(siteSettings);

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(siteSettings.ConnectionStrings.SqlConnection));


builder.Services.AddIdentity<User, IdentityRole<int>>(options =>
{
	options.SignIn.RequireConfirmedAccount = false;
	options.Password.RequireDigit = false;
	options.Password.RequiredLength = 6;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = false;
	options.Password.RequireLowercase = false;

})
.AddRoles<IdentityRole<int>>()
.AddEntityFrameworkStores<AppDbContext>()
.AddSignInManager<SignInManager<User>>()
.AddDefaultTokenProviders();

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("NotAdmin", policy =>
		policy.RequireAssertion(context =>
			!context.User.IsInRole("admin")));
});




builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAdminAppService, AdminAppService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentAppService, CommentAppService>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerAppService, CustomerAppService>();

builder.Services.AddScoped<ICustomerRequestRepository, CustomerRequestRepository>();
builder.Services.AddScoped<ICustomerRequestService, CustomerRequestService>();
builder.Services.AddScoped<ICustomerRequestAppService, CustomerRequestAppService>();

builder.Services.AddScoped<IExpertRepository, ExpertRepository>();
builder.Services.AddScoped<IExpertService, ExpertService>();
builder.Services.AddScoped<IExpertAppService, ExpertAppService>();

builder.Services.AddScoped<IExpertsRequestRepository, ExpertRequestRepository>();
builder.Services.AddScoped<IExpertsRequestService, ExpertRequestService>();
builder.Services.AddScoped<IExpertsRequestAppService, ExpertRequestAppService>();

builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IProvinceService, ProvincesService>();
builder.Services.AddScoped<IprovinceAppService, ProvinceAppService>();

builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<ISubCategoryAppService, SubCategoryAppService>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentAppService, CommentAppService>();

builder.Services.AddScoped<IWorkRepository, WorkRepository>();
builder.Services.AddScoped<IWorkService, WorkService>();
builder.Services.AddScoped<IWorkAppService, WorkAppService>();

builder.Services.AddScoped<IPhotoRepository, PhotoRepository>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddScoped<IPhotoAppService, PhotoAppService>();

builder.Services.AddScoped<IAccountAppService, AccountAppService>();

builder.Services.AddScoped<IBaseDataService, BaseDataService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
