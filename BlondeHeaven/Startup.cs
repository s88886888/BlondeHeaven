using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddMvc();
            //services.AddTransient<INoodleRepository, MockNoodleRepository>();   //每次发起请求都创建一个新的仓库，请求结束后自动注销
            //--services.AddSingleton<MockNoodleRepository>();    //在系统创建时仅创建一个仓库，每次处理请求都使用同一个
            //--services.AddScoped<MockNoodleRepository>();       //将一系列请求整合到一个事务中
            //services.AddTransient<IFeedbackRepository, MockFeedbackRepository>();


            services.AddTransient<INoodleRepository, NoodleRepository>();
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();

            services.AddTransient<IShopKeeperRepository, ShopKeeperRepository>();
            services.AddTransient<ICommodityRepository, CommodityRepository>();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //静态服务托管中间件
            app.UseStaticFiles();

            //身份认证
            app.UseAuthentication();

            //设置路由
            app.UseMvc(route =>
            {
                route.MapRoute("defaul", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
