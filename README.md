# Ethan-This-One

MacBook-Pro-6:vega mymac$ dotnet watch run
watch : Started
Unhandled exception. System.MissingMethodException: Method not found: 'Void AutoMapper.Mapper.Initialize(System.Action`1<AutoMapper.IMapperConfigurationExpression>)'.
   at AutoMapper.ServiceCollectionExtensions.AddAutoMapperClasses(IServiceCollection services, Action`1 additionalInitAction, IEnumerable`1 assembliesToScan)
   at AutoMapper.ServiceCollectionExtensions.AddAutoMapper(IServiceCollection services, Action`1 additionalInitAction, IEnumerable`1 assemblies)
   at AutoMapper.ServiceCollectionExtensions.AddAutoMapper(IServiceCollection services, Action`1 additionalInitAction, DependencyContext dependencyContext)
   at AutoMapper.ServiceCollectionExtensions.AddAutoMapper(IServiceCollection services)
   at vega.Startup.ConfigureServices(IServiceCollection services) in /Users/mymac/Desktop/moshProjects/vega/Startup.cs:line 26
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Object[] arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.InvokeCore(Object instance, IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.<>c__DisplayClass9_0.<Invoke>g__Startup|0(IServiceCollection serviceCollection)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.Invoke(Object instance, IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.<>c__DisplayClass8_0.<Build>b__0(IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.GenericWebHostBuilder.UseStartup(Type startupType, HostBuilderContext context, IServiceCollection services, Object instance)
   at Microsoft.AspNetCore.Hosting.GenericWebHostBuilder.<>c__DisplayClass13_0.<UseStartup>b__0(HostBuilderContext context, IServiceCollection services)
   at Microsoft.Extensions.Hosting.HostBuilder.CreateServiceProvider()
   at Microsoft.Extensions.Hosting.HostBuilder.Build()
   at vega.Program.Main(String[] args) in /Users/mymac/Desktop/moshProjects/vega/Program.cs:line 16

watch : Exited with error code 134
watch : Waiting for a file to change before restarting dotnet...
