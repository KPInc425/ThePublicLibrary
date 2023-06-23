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
global using KernelShared.Interfaces;

global using TPL.Core.Enums;
global using TPL.Core.TestData.Entities;

global using TPL.Infrastructure;
global using TPL.Infrastructure.Data;
global using TPL.Infrastructure.CommandQuery;

global using TPL.Application;
global using TPL.Application.Automaps;
global using TPL.Application.Shared.Configuration;
global using TPL.Application.Shared.Requests;
global using TPL.Application.Shared.ViewModels;
global using TPL.Application.Data.Interfaces;
global using TPL.Application.Data.SeedScripts;


