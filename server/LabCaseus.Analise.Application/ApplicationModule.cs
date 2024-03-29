﻿using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LabCaseus.Analise.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assemblyMediatrProject = AppDomain.CurrentDomain.Load("LabCaseus.Analise.Application");
            services.AddMediatR(o => { o.AddPipelineValidator(services, assemblyMediatrProject); }, assemblyMediatrProject);
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            return services;
        }
    }
}