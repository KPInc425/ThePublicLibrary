global using Ardalis.EFCore.Extensions;
global using Ardalis.GuardClauses;
global using Ardalis.Specification.EntityFrameworkCore;
global using TPL.Kernel;
global using TPL.Kernel.Interfaces;
global using TPL.KnownAccounts.Core.Entities;
global using TPL.KnownAccounts.Core.Interfaces;
global using TPL.KnownAccounts.Core.Specifications;
global using TPL.KnownAccounts.Infrastructure.Commands;
global using TPL.KnownAccounts.Infrastructure.Data;
global using TPL.KnownAccounts.Infrastructure.Queries;

global using Autofac;
global using MediatR;
global using MediatR.Pipeline;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using System.ComponentModel.DataAnnotations;

global using System.Net.Mail;
global using System.Reflection;
global using Module = Autofac.Module;