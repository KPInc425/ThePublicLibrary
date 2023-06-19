

global using Ardalis.HttpClientTestExtensions;

global using Autofac;
global using Autofac.Extensions.DependencyInjection;

global using AutoMapper;

global using FluentAssertions;
global using FluentValidation;

global using MediatR;
global using MediatR.Pipeline;

global using Swashbuckle.AspNetCore;
global using Swashbuckle.AspNetCore.Swagger;

global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Text.Json;
global using System.Net.Http;
global using System.Net.Http.Json;
global using System.Threading;
global using System.Threading.Tasks;

global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.AspNetCore.TestHost;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi.Models;

global using Newtonsoft.Json;
global using Newtonsoft.Json.Serialization;

global using Xunit;

global using KernelShared;
global using KernelShared.Interfaces;

global using TPL.Core;
global using TPL.Core.Entities;
global using TPL.Core.Enums;

global using TPL.Core.TestData.Entities;

global using TPL.Infrastructure;
global using TPL.Infrastructure.Data;
global using TPL.Infrastructure.CommandQuery;

global using TPL.Application;
global using TPL.Application.Automaps;
global using TPL.Application.Shared.Configuration;
global using TPL.Application.Shared.Interfaces;
global using TPL.Application.Shared.ViewModels;

global using TPL.Application.Data.Interfaces;
global using TPL.Application.Data.SeedScripts;

global using TPL.API.PrimaryApi;
global using TPL.API.PrimaryApi.Controllers;

global using TPL.API.PrimaryApi.FunctionalTests;
global using TPL.API.PrimaryApi.FunctionalTests.ControllerTests;

