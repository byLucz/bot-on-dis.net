using Discord.Commands;
using Discord.WebSocket;
using Discord;
using System.Threading.Tasks;
using System;
using Victoria;
using StreamMusicBot.Services;
using Microsoft.Extensions.DependencyInjection;
using StreamMusicBot;

namespace MainShit
{
    public class Client
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _cmdService;
        private IServiceProvider _services;
        private readonly LogService _logService;

        public Client()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig {
                AlwaysDownloadUsers = true,
                MessageCacheSize = 50,
                LogLevel = LogSeverity.Debug
            });

            _cmdService = new CommandService(new CommandServiceConfig {
                LogLevel = LogSeverity.Verbose,
                CaseSensitiveCommands = false
            });

            _logService = new LogService();
        }

        public async Task InitializeAsync()
        {
            string Token = "MzQyNjYwMzQyNzU0NTc0MzM2.WYMlUA.8P_TA-i5m-Lo2IG3XyjUTSBFPSc";
            await _client.LoginAsync(TokenType.Bot, Token);
            await _client.StartAsync();
            _client.Log += LogAsync;
            _services = SetupServices();
            var cmdHandler = new CommandHandler(_client, _cmdService, _services);
            await cmdHandler.InitializeAsync();
            await _services.GetRequiredService<MusicService>().InitializeAsync();
            await _client.SetGameAsync("хуйло памаги", "https://twitch.tv/luc4sz7", ActivityType.Listening);
            //await _client.SetActivityAsync(new Game("как максим ебет в жопу осеров", ActivityType.Watching));
            await _client.SetStatusAsync(UserStatus.DoNotDisturb);
            await Task.Delay(-1);
        }

        private async Task LogAsync(LogMessage logMessage)
        {
            await _logService.LogAsync(logMessage);
        }



        private IServiceProvider SetupServices()
            => new ServiceCollection()
            .AddSingleton(_client)
            .AddSingleton(_cmdService)
            .AddSingleton(_logService)
            .AddSingleton<LavaRestClient>()
            .AddSingleton<LavaSocketClient>()
            .AddSingleton<MusicService>()
            .BuildServiceProvider();

        internal static ISocketMessageChannel GetChannel(long v)
        {
            throw new NotImplementedException();
        }
    }
}
