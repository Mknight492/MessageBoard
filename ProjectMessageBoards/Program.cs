// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ProjectMessageBoards.Commands;
using ProjectMessageBoards.Repositories;
using ProjectMessageBoards;

var parser = new CommandParser();

var inMemoryStorage = new MessageRepository();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Register services with DI container
        services.AddSingleton<IMessageRepository, MessageRepository>(); 
        services.AddTransient<ICommandParser, CommandParser>(); 
        services.AddTransient<MyApplication>(); // Main application class
    })
    .Build();


var app = host.Services.GetRequiredService<MyApplication>();
app.Run();