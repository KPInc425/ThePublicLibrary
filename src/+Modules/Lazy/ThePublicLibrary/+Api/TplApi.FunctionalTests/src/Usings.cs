global using Autofac;
global using Autofac.Extensions.DependencyInjection;

global using FluentAssertions;
global using FluentValidation;

global using MediatR;
global using MediatR.Pipeline;

global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Net.Http;
global using System.Net.Http.Json;
global using System.Threading.Tasks;

global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;

global using Xunit;

global using Fernweh.KernelShared.Configuration;
global using Fernweh.KernelShared.Interfaces;

global using TplCore.Enums;
global using TplCore.TplTestData.Entities;

global using TplInfrastructure;
global using TplInfrastructure.Data;
global using TplInfrastructure.CommandQuery;

global using TplApplication;
global using TplApplication.Automaps;
global using TplApplication.Shared.Requests;
global using TplApplication.Shared.ViewModels;
global using TplApplication.Data.Interfaces;
global using TplApplication.Data.SeedScripts;


