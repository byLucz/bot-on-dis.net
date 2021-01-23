using RandomSoul;
using System;
using System.Collections.Generic;
using System.Text;

namespace vosemyaic
{
    public class vosemyaic
    {
        private static List<string> _yaica = new List<string>
        {
            "`да`" ,
            "`нет`" ,
            "`не думаю`",
            "`пашол нахуй`" ,
            "`не хочу на такое отвечать`" ,
            "`САСИ ЖОПУ`",
            "`точно нет!`" ,
            "`нууу хз`" ,
            "`правильно`",
            "`yep cock`",
            "`окок`" ,
            "`50 на 50`" ,
            "`я бы еще подумал над вопросом...`" ,
            "`абсолютно точно`" ,
            "`абсолютный пиздеж`",
        
        };

        public static string RND()
        {
            return _yaica.Random();
        }
    }
}
