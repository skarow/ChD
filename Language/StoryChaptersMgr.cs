using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryChaptersMgr
{

    private List<string> chaptersEn;
    private List<string> chaptersBg;

    public StoryChaptersMgr()
    {
        chaptersEn = new List<string>
        {
        /*1*/     "Welcome to the most exciting game ever! Use your knight and bishop to prevail against those pesting pawns!",
        /*2*/     "Take all the pawns before they reach your base. Watch out for they can take you too… Pawns, just like in chess can take you diagonally!",
        /*3*/     "I guess you’ve figured that out but anyway. You move both the knight and the bishop before the pawns make their move. They all move simultaneously. ",
        /*4*/     "One of the most efficient ways to win the game is by breaking their formations. Usually one pawn protects others. But if you manage to stand in its way you stop it. That breaks formation.",
        /*5*/     "If a particular level seems too hard try breaking other formation.",
        /*6*/     "Ever too stuck? You could always use the bonuses at the top right of the screen. One is double move, which unsurprisingly gives you the ability to move twice with the currently selected figure.",
        /*7*/     "The other cool bonus is “switch order”. It is cool cus it grants you the ability to move the bishop before the knight. And a secret. If you’ve already moved the knight and you use “switch order”, the knight skips his turn. Psst.",
        /*8*/     "I guess you pretty much know all about there is to win the game! Don’t forget to block their path and break formations. If you ever manage to win the game there are some surprises for you. A level creating tool - you’d be able to make your own levels.",
        /*9*/     "The other is you would have the ability to unlock Act 2! Yeah! There is one. You get more types of enemies. Battle against the mighty ROOKS and the intimidation BISHOPS as they ally with the pawns in order to defeat you. It is scarier than it sounds…",
        /*10*/    "Since  there’s not much more we could say about the game… here are some interesting facts and jokes to keep you wanting more:",
        /*11*/    "A man asks a farmer near a field, “Sorry sir, would you mind if I crossed your field instead of going around it? You see, I have to catch the 4:23 train.”\nThe farmer says, “Sure, go right ahead. And if my bull sees you, you’ll even catch the 4:11 one.”",
        /*12*/    "What is the difference between a snowman and a snowwoman?\nSnowballs.",
        /*13*/    "Man to his priest: “Yesterday I sinned with an 18 year old girl.”\nThe priest: “Squeeze 18 lemons and drink the juice all at once.”\nMan: “And that frees me from my sin?”\nPriest: “No, but it frees your face from that dirty grin.”",
        /*14*/    "I managed to lose my rifle when I was in the army. I had to pay $855 to cover the loss.\nI’m starting to understand why a Navy captain always goes down with his ship.",
        /*15*/    "Doctor: “Do you do sports?\nPatient: “Does sex count?”\nDoctor: “Yes.”\nPatient: “Then no.”",
        /*16*/    "Police: “Open the door!” \nMan: “I don’t want any balls!” \nPolice: “What? We don’t have any balls!”\nMan: “I know.”",
        /*17*/    "Little Johnny asks his father: \n\"Where does the wind come from?\"\n\"I don't know.\" \n\"Why do dogs bark?\"\n\"I don't know.\"\n\"Why is the earth round?\"\n\"I don't know.\"\n\"Does it disturb you that I ask so much?\"\n\"No son. Please ask. Otherwise you will never learn anything.\"",
        /*18*/    "What is see-through and smells of carrots? \nA rabbit fart.",
        /*19*/    "One state official to the other: \"I don't know what people have against us - We haven't done anything.\"",
        /*20*/    "Q. Why do the French like to eat snails so much?\nA. They can’t stand fast food. ",
        /*21*/    "Bob: \"Holy schmoozes, I just fell off a 30 ft ladder.\"\nJim: \"No way man, are you okay?\"\nBob: \"Yeah, luckily I was just on the first step.\"",
        /*22*/    "My wife is a bit weird. She always starts her talking with “Michael, are you listening to me?”",
        /*23*/    "Why is it a bad idea to insult an octopus?\nBecause it is well armed.",
        /*24*/    "An employee complains to his boss, “Sorry boss, but the salary doesn’t even remotely match the effort I put into my work.”\nBoss nods, “I know, but we can’t let you starve to death.”",
        /*25*/    "When you say “a million seconds”, it means 11 and a half days. “A billion seconds” would be over 31 years.",
        /*26*/    "Bulgarians nod when they want to say NO and shake their heads when they want to say YES",
        /*27*/    "Scotland’s national animal is a unicorn.",
        /*28*/    "See you in part two!",
        };

        chaptersBg = new List<string>
        {
        /*1*/   "Добре дошли в най-вълнуващата игра правена някога! Използвай рицаря и офицера, за да надмогнеш ужасните пешки!",
        /*2*/   "Вземи всички пешки преди да достигнат базата ти. Внимавай, защото и те могат да те вземат… Пешките, също като при шаха, могат да те взимат по диагонал!",
        /*3*/   "Предполагам, че вече си разбрал, но съм длъжен да обясня. Ти движиш и двете фигури, преди пешките да направят своя ход. Заедно всички се преместват едно поле напред.",
        /*4*/   "Един от най-ефективните начини да победиш в играта е като им разваляш формациите. Обикновено една пешка защитава друга пешка. Но ако успееш да ѝ застанеш на пътя - ти я спираш. Така вече тя не защитава. Така разваляш формация.",
        /*5*/   "Ако някое ниво ти се струва твърде сложно - просто пробвай да разбиеш друга формация.",
        /*6*/   "Твърде много си я закъсал? Винаги можеш да използваш бонусите на екрана горе в дясно. Едното е “double move”, или двоен ход, което ти дава способността да се придвижиш 2 пъти с фигурата, която е текуща на ход.",
        /*7*/   "Другият готин бонус е “switch order” - или смени реда. Готин е, защото ти дава възможността да предвижиш офицера преди коня. И една тайна. Ако вече си придвижил коня и използваш “смени реда”, офицерът ще пропусне ход. Шшт. Psst.",
        /*8*/   "Мисля, че това е всичко, което ти е необходимо, за да спечелиш играта. Не забравяй да им блокираш пътя и така да им разваляш формацията. Ако някога успееш да спечелиш играта, ще има няколко изненади за теб. Способ за създаване на нива - ще можеш да си направиш собствени нива.",
        /*9*/   "НеДругото, което ще спечелиш е възможността да отключиш Том 2. Да! Има и такъв! Нови видове противници. Сражавай се срещу великите ТОПОВЕ и заплашителните ОФИЦЕРИ, които са се съюзили с пешките. По - страшно е, от колкото звучи.",
        /*10*/   "Тъй като няма какво повече да кажа за играта… от тук нататък ще следват интересни факти и шеги, които да те карат да се връщаш за още!",
        /*11*/   "Мъж пита фермер близо до едно поле, “Извинете господине, бихте ли имал нещо против ако прекося полето ви, вместо да го заобикалям. Разбирате ли, трябва да хвана влака в 4:23.”\nФермерът отговаря, “Разбира се, давай. И ако ви види бикът ми, дори ще хванете този в 4:11!”",
        /*12*/   "Народно поверие:\n- Не спори с жена си... на глад е!",
        /*13*/   "Когато мъжът ѝ предложи да опитат садо-мазо, тя веднага се съгласи, но не защото ѝ харесваше, а просто отдавна искаше да му тегли един бой.",
        /*14*/   "Когато ме попита жена ми \"Какво искаш за вечеря?\" Никога не познавам!",
        /*15*/   "Пролетна умора, лятна летаргия, есенна депресия, зимен сън... Живот - к'во да правиш.",
        /*16*/   "Производителите на колбаси, след като разбрали, че клиентите тестват салама, като първо дават на котката, започнали да слагат вътре и месо от мишки…",
        /*17*/   "Най лесно си планирам лятната отпуска... Началника ми казва КОГА, а жената КЪДЕ…",
        /*18*/   "Всеки се ражда девствен, ама никой не умира девствен - живота го \"слага\" на всеки.",
        /*19*/   "3016 ГОДИНА…\n- Хората имат дълги ръце - метър и половина... вследствие на селфита от няколко века…",
        /*20*/   "Ушите на човека, макар и бавно, растат до края на живота му.",
        /*21*/   "Морското конче си избира един партньор за целия си живот и когато едното от тях умре, наскоро след това умира и другото.",
        /*22*/   "Ако продължително време се преструвате, че се смеете, накрая ще започнете наистина.",
        /*23*/   "Всяка година порастват милиони дръвчета, благодарение на катерички, забравили къде са оставил ядките, които са събрали.",
        /*24*/   "Азотът в нашето ДНК, калцият в зъбите ни, съдържанието на желязо в кръвта ни, въглеродът в ябълковия ни пай са направени във вътрешността на падащи звезди.Ние може и да не сме направени от звезден прах, но поне със сигурност имаме по малко някъде в себе си.",
        /*25*/   "Кравите си имат най-добри приятели.",
        /*26*/   "Видрите се държат за ръце докато спят, за да не се изгубят взаимно.",
        /*27*/   "Когато малките мъжки кученца играят с момиченцата, те умишлено ще оставят \"дамата” да победи.",
        /*28*/   "Ще се видим във втора част!",
        }; 
    }

    public string GetChapterText( int chapterNo )
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                return chaptersBg[chapterNo];
            case LanguageMgr.LANGUAGE_EN:
                return chaptersEn[chapterNo];
            default:
                return chaptersEn[chapterNo];
        }
    }

    public int GetSize()
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                return chaptersBg.Count;
            case LanguageMgr.LANGUAGE_EN:
                return chaptersEn.Count;
            default:
                return chaptersEn.Count;
        }
    }
}
