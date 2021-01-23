using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using DiscordZapBot;
using MainShit;

namespace commandz
{
    public class BotCommandModule : ModuleBase<SocketCommandContext>
    {

        //[Command("статус")]
       // public async Task SetGameAsync(string name, string streamUrl = null, ActivityType type = ActivityType.Playing)
        //{
        //    await Client._client.SetGameAsync("хуйло памаги", "https://twitch.tv/luc4sz7", ActivityType.Streaming);
       // }






        [Command("волк")]
        public async Task volk()
        {
            await ReplyAsync(Membl.rndm());
        }

        [Command("8 яиц")]
        [Alias("?")]
        public async Task vosemyaiasc([Remainder] string args = null)
        {
            IUserMessage message = await ReplyAsync(vosemyaic.vosemyaic.RND(), true);
        }

        [Command("удоли")]
        public async Task Clean(int max)
        {
            await ReplyAsync("легчайшее");
            var messages = Context.Channel.GetMessagesAsync(max + 2).Flatten();
            foreach (var h in await messages.ToArrayAsync())
            {
                await this.Context.Channel.DeleteMessageAsync(h);
            }
        }

        [Command("x")]
        public async Task testtts()
        {

            IUserMessage message = await ReplyAsync("макс сосет бибу", true);

        }


        [Command("справедливо")]


    public async Task sozdasssteaal()
    {
        await ReplyAsync("https://mem-baza.ru/_ph/1/2/15681645.jpg?1600932334");
    }




    [Command("снюс бот?")]
    public async Task snusbot()
    {
        var EmbedBuilder = new EmbedBuilder()
            .WithDescription($"СОСАТЬ СОСАТЬ СОСАТЬ СОСАТЬ")
            .WithFooter(footer =>
            {
                footer
                .WithText("агент донбас сосет тоже кста")
                .WithIconUrl("https://pbs.twimg.com/profile_images/1285974237023481859/UU7fnlf__400x400.jpg");
            });
        Embed embed = EmbedBuilder.Build();
        await ReplyAsync(embed: embed);
    }

    [Command("памаги")]
    public async Task snusbosst()
    {
        var botzname = new EmbedAuthorBuilder()
        .WithName("здарова я сын гавна и вот мои комманды")
        .WithIconUrl("https://assets.coingecko.com/coins/images/8758/large/ShitCoin.png?1561601773");
        var copy = new EmbedFooterBuilder()
                .WithText("COPYRIGHT NOT ALLOWED BECAUSE YOU HAVE SMALL EGGS @lucz 2021")
                .WithIconUrl("https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/Copyright.svg/1200px-Copyright.svg.png");

        var q = new EmbedFieldBuilder()
                .WithName("кто твой создатель?")
                .WithValue("знаем своего гения в лицо");
        var w = new EmbedFieldBuilder()
              .WithName("пинг")
              .WithValue("пинг бота к серверу");
        var e = new EmbedFieldBuilder()
              .WithName("снюс бот?")
              .WithValue("нагнуть никитоса");
        var y = new EmbedFieldBuilder()
              .WithName("бэн")
              .WithValue("забэнить додика");
        var u = new EmbedFieldBuilder()
              .WithName("удоли")
              .WithValue("удолить сообщения <колво шт>");
            var x = new EmbedFieldBuilder()
             .WithName("эхо")
             .WithValue("дублирует сообщение(хз зачем это нужно)");
            var kik = new EmbedFieldBuilder()
            .WithName("кэк")
            .WithValue("кикает додика");
            var page2 = new EmbedFieldBuilder()
      .WithName("памаги с музыкой")
      .WithValue("Команды для музыки ");
            var page3 = new EmbedFieldBuilder()
.WithName("дай пофаниться")
.WithValue("Команды для фана");
            var embed = new EmbedBuilder()
                .AddField(q)
                .AddField(w)
                .AddField(e)
                .AddField(y)
                .AddField(u)
                .AddField(x)
                .AddField(kik)
                .AddField(page2)
                .AddField(page3)
                .WithAuthor(botzname)
                .WithFooter(copy)
                .Build();
        await ReplyAsync(embed: embed);

    }
        [Command("памаги с музыкой")]
        public async Task dj()
        {
            var botzname = new EmbedAuthorBuilder()
       .WithName("здарова я сын гавна и вот мои комманды")
       .WithIconUrl("https://assets.coingecko.com/coins/images/8758/large/ShitCoin.png?1561601773");
            var copy = new EmbedFooterBuilder();
            var v = new EmbedFieldBuilder()
 .WithName("играй ебать|и")
 .WithValue("Играть песенку");
            var b = new EmbedFieldBuilder()
            .WithName("пнх|л")
            .WithValue("Лив с канала");
            var n = new EmbedFieldBuilder()
           .WithName("СТОПНИСЬ НАХУЙ|стоп")
           .WithValue("Отменяет проигрывание песни");
            var m1 = new EmbedFieldBuilder()
.WithName("СТОПНИСЬ НАХУЙ|стоп")
.WithValue("Отменяет проигрывание песни");
            var m2 = new EmbedFieldBuilder()
            .WithName("громкость|гр (знач)")
            .WithValue("Делает бота тише|громче");
            var m3 = new EmbedFieldBuilder()
            .WithName("пауза|пз")
            .WithValue("Приостановить проигрываение");
            var m4 = new EmbedFieldBuilder()
            .WithName("продолжи|пук")
            .WithValue("Продолжить проигрывание");
            var embed = new EmbedBuilder()
                .AddField(v)
                .AddField(b)
                .AddField(b)
                .AddField(m1)
                .AddField(m2)
                .AddField(m3)
                .AddField(m4)
                .Build();
            await ReplyAsync(embed: embed);
        }
        [Command("дай пофаниться")]
        public async Task Fun()
        {

            var botzname = new EmbedAuthorBuilder()
            .WithName("здарова я сын гавна и вот мои комманды для фана(В процессе выдачи рофла...)")
            .WithIconUrl("https://assets.coingecko.com/coins/images/8758/large/ShitCoin.png?1561601773");
            var copy = new EmbedFooterBuilder();
            var r = new EmbedFieldBuilder()
            .WithName("максим")
            .WithValue("позвать додика");
            var t = new EmbedFieldBuilder()
            .WithName("ауе")
            .WithValue("ауе");
            var m1 = new EmbedFieldBuilder()
            .WithName("пососи")
            .WithValue("пососи");
            var z = new EmbedFieldBuilder()
                         .WithName("волк")
                         .WithValue("выводит рандомную картинку с волком");
            var zxc = new EmbedFieldBuilder()
                .WithName("андерстендебел")
                .WithValue("андерстендебел");
            var zxc1 = new EmbedFieldBuilder()
               .WithName("8 яиц|?")
               .WithValue("Местный АНАЛог шара-восьмерки(Просто автор кода любит яица)");
            var embed = new EmbedBuilder()
                .AddField(r)
                .AddField(m1)
                .AddField(z)
                .AddField(t)
                .AddField(zxc)
                .AddField(zxc1)
                .Build();
            await ReplyAsync(embed: embed);
        }



    [Command("эхо")]
        
        public Task EchoAsync([Remainder] string text)
            
            // Insert a ZWSP before the text to prevent triggering other bots!
            => ReplyAsync('\u200B' + text, true);
            

        [Command("кэк")]
        [RequireUserPermission(GuildPermission.KickMembers, ErrorMessage = "тебе нельзя ты додик")]
        public async Task KickMember(IGuildUser user = null, [Remainder] string reason = null)
        {
            if (user == null)
            {
                await ReplyAsync("выбери чмыгу");
                return;
            }
            if (reason == null) reason = "не выбрал дебил";

            await user.KickAsync();

            var EmbedBuilder = new EmbedBuilder()
                .WithDescription($":white_check_mark: {user.Mention} чпокнул патамуша \n**Reason** {reason}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("пасаси")
                    .WithIconUrl("https://www.meme-arsenal.com/memes/909b4f2f82a9a087d4b042e1327da47f.jpg");
                });
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);

            ITextChannel logChannel = Context.Client.GetChannel(500682256059334656) as ITextChannel;
            var EmbedBuilderLog = new EmbedBuilder()
               .WithDescription($"{user.Mention} был забэнэн \n**Reason** {reason}\n**Moderator** {Context.User.Mention}")
              .WithFooter(footer =>
              {
                  footer
                  .WithText("пасаси")
                   .WithIconUrl("https://www.meme-arsenal.com/memes/909b4f2f82a9a087d4b042e1327da47f.jpg");
              });
            Embed embedLog = EmbedBuilderLog.Build();

            await ReplyAsync(embed: embed);
        }

        [Command("андерстендебел")]


        public async Task sozdateaal()
        {
            await ReplyAsync("https://www.dailydot.com/wp-content/uploads/c1b/b4/ca394a1143d6d0e5.png");
        }


        [Command("кто твой создатель?")]
        public async Task sozdatel()
        {
            await ReplyAsync(" ***` бота создал агент лукекз😋`*** ");
        }

        [Command("иди нахуй")]
        public async Task nah()
        {
            await ReplyAsync("сам иди.");
        }


        [Command("максим")]
        public async Task max()
        {
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");
            await ReplyAsync("СЛУЕР ЗАЙДИ В ДС СЛУЕР ЗАЙДИ В ДС <@264335002874019841>");

        }


        [Command("ы")]

        public async Task ayse()
        {
            var id = Context.Message.Author.Id;
            await Context.Channel.SendMessageAsync($"<@{id}>");

        }

        [Command("ауе")]
        public async Task aye()
        {
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
            await ReplyAsync("ауе ауе ауе ");
        }


        [Command("пинг")]
        public async Task Ping()
        {
            await ReplyAsync($"🏓 понг ебать ``{(Context.Client as DiscordSocketClient).Latency} микропэнисоw``");
        }

        [Command("бэн")]
        [RequireUserPermission(GuildPermission.BanMembers, ErrorMessage = "тебе нельзя ты додик")]
        public async Task BanMember(IGuildUser user = null, [Remainder] string reason = null)

        {

            if (user == null)
            {
                await ReplyAsync("выбери чмыгу");
                return;

            }


            if (reason == null) reason = "не выбрал дебил";

            await Context.Guild.AddBanAsync(user, 1, reason);

            var EmbedBuilder = new EmbedBuilder()
                .WithDescription($":white_check_mark: {user.Mention} чпокнул патамуша \n**Reason** {reason}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("пасаси")
                    .WithIconUrl("https://www.meme-arsenal.com/memes/909b4f2f82a9a087d4b042e1327da47f.jpg");
                });
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);

            ITextChannel logChannel = Context.Client.GetChannel(500682256059334656) as ITextChannel;
            var EmbedBuilderLog = new EmbedBuilder()
                .WithDescription($"{user.Mention} был забэнэн \n**Reason** {reason}\n**Moderator** {Context.User.Mention}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("пасаси")
                    .WithIconUrl("https://www.meme-arsenal.com/memes/909b4f2f82a9a087d4b042e1327da47f.jpg");
                });
            Embed embedLog = EmbedBuilderLog.Build();
            await logChannel.SendMessageAsync(embed: embedLog);

        }
        [Command("Пососи")]
        public async Task pososi()
        { await ReplyAsync(" пососи пососи пососи пососи"); }

    }


}

