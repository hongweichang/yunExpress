﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FluentValidation;
using FluentValidation.Mvc;
using LighTake.Infrastructure.Common.Caching;
using LighTake.Infrastructure.Common.InversionOfControl;
using LighTake.Infrastructure.Common.Logging;
using LighTake.Infrastructure.Common.TypeAdapter;
using LighTake.Infrastructure.Web;

namespace LMS.WebAPI.Client
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Initialize();
            //GlobalConfiguration.Configuration.Services.Add(typeof(System.Web.Http.Validation.ModelValidatorProvider), new WebApiFluentValidationModelValidatorProvider());
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.UseXmlSerializer = true;
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }

        private void Initialize()
        {
            EngineContext.Initialize(false);
            //set dependency resolver
            var dependencyResolver = new MVCDependencyResolver();
            DependencyResolver.SetResolver(dependencyResolver);

            // initialize cache
            //Cache.InitializeWith(new CacheProviderFactory(ConfigurationManager.AppSettings["CacheProvider"]));


            ////initialize AutoMappe
            //Mapper.Initialize(x => x.AddProfile<AutoMapperProfile>());

            var typeAdapterFactory = EngineContext.Current.Resolve<ITypeAdapterFactory>();
            TypeAdapterFactory.SetCurrent(typeAdapterFactory);

            ConfigureFluentValidation();
        }

        protected void ConfigureFluentValidation()
        {
            //            // 设置 FluentValidation 默认的资源文件提供程序 - 中文资源
            //            ValidatorOptions.ResourceProviderType = typeof(FluentValidationResource);

            ///* 比如验证用户名 not null、not empty、length(2,int.MaxValue) 时，链式验证时，如果第一个验证失败，则停止验证 */
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure; // ValidatorOptions.CascadeMode 默认值为：CascadeMode.Continue

            // 配置 FluentValidation 模型验证为默认的 ASP.NET MVC 模型验证
            FluentValidationModelValidatorProvider.Configure();
        }

        protected void Application_Error(object sender, EventArgs e)
        {

            Exception ex = Server.GetLastError();

            //if (ex is ThreadAbortException)
            //    return;

            Log.Exception(ex);
            //Response.Redirect("unexpectederror.htm");
        }


    }
}