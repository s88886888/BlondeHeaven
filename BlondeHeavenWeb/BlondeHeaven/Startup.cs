using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace BlondeHeaven
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });







            //每次发起请求都创建一个新的仓库，请求结束后自动注销
            //在系统创建时仅创建一个仓库，每次处理请求都使用同一个
            //将一系列请求整合到一个事务中
            services.AddTransient<IShopKeeperRepository, ShopKeeperRepository>();
            services.AddTransient<ICommodityRepository, CommodityRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            //Ef core3.15 连接数据库
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));


            //身份验证
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
            })
         .AddDefaultUI()
        .AddEntityFrameworkStores<AppDbContext>();



            services.AddMvc();
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //静态服务托管中间件
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //身份认证
            app.UseAuthentication();
            //设置路由
            app.UseMvc(route =>
            {
                route.MapRoute("defaul", "{controller=Shop}/{action=Index}/{id?}");
            });
        }
    }
    
}
