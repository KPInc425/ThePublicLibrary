global using Ardalis.EFCore.Extensions;
global using Ardalis.GuardClauses;
global using Ardalis.Specification.EntityFrameworkCore;
global using Kernel;
global using Kernel.Interfaces;
global using KnownAccountsCore.Entities;
global using KnownAccountsCore.Interfaces;
global using KnownAccountsCore.Entities;
global using KnownAccountsInfrastructure.Commands;
global using KnownAccountsInfrastructure.Data;
global using KnownAccountsInfrastructure.Queries;

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