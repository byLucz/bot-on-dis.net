using RandomSoul;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordZapBot
{
    public class Membl
    {
        private static List<string> _memes = new List<string>
        {
            "https://memepedia.ru/wp-content/uploads/2019/04/memy-pro-volkov-4-360x270.jpg",
            "https://7ly.ru/wp-content/uploads/2019/06/Bez-nazvaniya-6.jpg",
            "https://memepedia.ru/wp-content/uploads/2019/04/uaeyvg8i3la-360x270.jpg",
            "https://pbs.twimg.com/media/EBf8754WkAASoZ6.jpg",
            "https://www.meme-arsenal.com/memes/6c787e5c4ec97446fb0f1b019c7dd6cd.jpg",
            "https://r3.mt.ru/r4/photo8F95/20231675453-0/jpg/bp.webp",
            "https://memepedia.ru/wp-content/uploads/2019/04/memy-pro-volkov-9.jpg",
            "https://memepedia.ru/wp-content/uploads/2019/04/memy-pro-volkov-3.jpg",
            "https://v1rt.ru/upload/iblock/83a/83ad1b0db5f1e95cc4a0ff0d8a4f491a.jpg",
            "https://pm1.narvii.com/7317/6534a14507a6761dfd8bf4f0b9e3f2bafe2916c7r1-1000-648v2_uhq.jpg",
            "https://pbs.twimg.com/media/EK8k-IMW4AAl1QA.jpg",
            "https://coub-anubis-a.akamaized.net/coub_storage/coub/simple/cw_timeline_pic/2aaccae61c4/cc6b0dd73c5ac703b7733/med_1588841421_image.jpg",
            "https://mem-baza.ru/_ph/1/2/813302926.jpg?1600929164"
        };

        public static string rndm()
        {
            return _memes.Random();
        }
    }
}
