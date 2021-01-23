using Discord;
using Discord.Commands;
using Discord.WebSocket;
using StreamMusicBot.Services;
using System.Threading.Tasks;
namespace StreamMusicBot.Modules
{
    public class Music : ModuleBase<SocketCommandContext>
    {
        private MusicService _musicService;

        public Music(MusicService musicService)
        {
            _musicService = musicService;
        }


        [Command("играй ебать")]
        [Alias("и")]
        public async Task Plasy([Remainder] string query)
        {
            var user = Context.User as SocketGuildUser;
            if (user.VoiceChannel is null)
            {
                await ReplyAsync("надо быть в войсе дурачок");
                return;
            }
            else
            {
                await _musicService.ConnectAsync(user.VoiceChannel, Context.Channel as ITextChannel);
            }
            await ReplyAsync(await _musicService.PlayAsync(query, Context.Guild.Id));

        }


        [Command("пнх")]
        [Alias("л")]
        public async Task Leave()
        {
            var user = Context.User as SocketGuildUser;
            if (user.VoiceChannel is null)
            {
                await ReplyAsync("пж зайди в канал чтобы я увидел дверь для выхода 👉👈");
            }
            else
            {
                await _musicService.LeaveAsync(user.VoiceChannel);
            }
        }


        [Command("СТОПНИСЬ НАХУЙ")]
        [Alias("стоп")]
        public async Task Stop()
            => await ReplyAsync(await _musicService.StopAsync(Context.Guild.Id));

        [Command("скипни пж")]
        [Alias("скип")]
        public async Task Skip()
            => await ReplyAsync(await _musicService.SkipAsync(Context.Guild.Id));

        [Command("громкость")]
        [Alias("гр")]
        public async Task Volume(int vol)
            => await ReplyAsync(await _musicService.SetVolumeAsync(vol, Context.Guild.Id));

        [Command("пауза")]
        [Alias("пз")]
        public async Task Pause()
            => await ReplyAsync(await _musicService.PauseOrResumeAsync(Context.Guild.Id));

        [Command("продолжи")]
        [Alias("пук")]
        public async Task Resume()
            => await ReplyAsync(await _musicService.ResumeAsync(Context.Guild.Id));
    }
}
