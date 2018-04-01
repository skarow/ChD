using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using HutongGames.PlayMaker;


public class QuotesMgr : MonoBehaviour
{


    private Dictionary<string, string> quotesMgrEn;
    private Dictionary<string, string> quotesMgrBg;
    private int quoteIndex = 0;



    void Awake()
    {
        quotesMgrEn = new Dictionary<string, string>
        {
            {"“Without ambition one starts nothing. Without work one finishes nothing. The prize will not be sent to you. You have to win it.”" , "Ralph Waldo Emerson" },
            {"“The man who moves a mountain begins by carrying away small stones.”", "Confucius, Confucius: The Analects" },
            {"“Nothing is so strong as gentleness, nothing so gentle as real strength.”", "Johann Wolfgang von Goethe" },
            {"“Nothing is worth more than this day.”", "Johann Wolfgang von Goethe" },
            {"“A man sees in the world what he carries in his heart.”", "Johann Wolfgang von Goethe" },
            {"“You can easily judge the character of a man by how he treats those who can do nothing for him.”", "Johann Wolfgang von Goethe" },
            {"“As soon as you trust yourself, you will know how to live.”", "Johann Wolfgang von Goethe" },
            {"“Everything is hard before it is easy”", "Johann Wolfgang von Goethe" },
            {"“What is not started today is never finished tomorrow.” ", "Johann Wolfgang von Goethe" },
            {"“A really great talent finds its happiness in execution.”", "Johann Wolfgang von Goethe" },
            {"“For a man to achieve all that is demanded of him, he must regard himself as greater than he is.”", "Johann Wolfgang von Goethe" },
            {"“Oblivion is full of people who allow the opinions of others to overrule their belief in themselves.”", "Johann Wolfgang von Goethe" },
            {"“One can stand anything except a succession of ordinary days.”", "Johann Wolfgang von Goethe" },
            {"“The greatest evil that can befall man is that he should come to think ill of himself.”", "Johann Wolfgang von Goethe" },
            {"“Treat people as if they were what they ought to be and you help them to become what they are capable of being.”", "Johann Wolfgang von Goethe" },
            {"“Doubt can only be removed by action.”", "Johann Wolfgang von Goethe" },
            {"“We know accurately only when we know little; doubt grows with knowledge.”", "Johann Wolfgang von Goethe" },
            {"“We are never deceived; we deceive ourselves. ”", "Johann Wolfgang von Goethe" },
            {"“Difficulties increase the nearer we get to the goal.”", "Johann Wolfgang von Goethe" },
            {"“What you get by achieving your goals is not as important as what you become by achieving your goals.”", "Johann Wolfgang von Goethe" },
            {"“If you would create something, you must be something.”", "Johann Wolfgang von Goethe" },
            {"“If you don't feel it, you'll never get it.”", "Johann Wolfgang von Goethe" },
            {"“Talent develops in solitude, character develops in the stream of life.”", "Johann Wolfgang von Goethe" },
            {"“At the moment of commitment the entire universe conspires to assist you.”", "Johann Wolfgang von Goethe" },
            {"“Do what you can, with what you have, where you are.”", "Theodore Roosevelt" },
            {"“It is not the critic who counts; not the man who points out how the strong man stumbles, or where the doer of deeds could have done them better. The credit belongs to the man who is actually in the arena, whose face is marred by dust and sweat and blood; who strives valiantly; who errs, who comes short again and again, because there is no effort without error and shortcoming; but who does actually strive to do the deeds; who knows great enthusiasms, the great devotions; who spends himself in a worthy cause; who at the best knows in the end the triumph of high achievement, and who at the worst, if he fails, at least fails while daring greatly, so that his place shall never be with those cold and timid souls who neither know victory nor defeat.”", "Theodore Roosevelt" },
            {"“Believe you can and you're halfway there.”", "Theodore Roosevelt" },
            {"“When you're at the end of your rope, tie a knot and hold on.”", "Theodore Roosevelt" },
            {"“The only man who never makes mistakes is the man who never does anything.”", "Theodore Roosevelt" },
            { "“Nothing in the world is worth having or worth doing unless it means effort, pain, difficulty… I have never in my life envied a human being who led an easy life. I have envied a great many people who led difficult lives and led them well.”", "Theodore Roosevelt" },
            {"“To educate a person in the mind but not in morals is to educate a menace to society.”","Theodore Roosevelt" },
            {"“Knowing what's right doesn't mean much unless you do what's right.”","Theodore Roosevelt" },
            {"“Keep your eyes on the stars, and your feet on the ground.”","Theodore Roosevelt" },
            {"“If you could kick the person in the pants responsible for most of your trouble, you wouldn't sit for a month.”","Theodore Roosevelt" },
            {"“In any moment of decision, the best thing you can do is the right thing. The worst thing you can do is nothing.”","Theodore Roosevelt" },
            {"“Here is your country. Cherish these natural wonders, cherish the natural resources, cherish the history and romance as a sacred heritage, for your children and your children's children. Do not let selfish men or greedy interests skin your country of its beauty, its riches or its romance.”","Theodore Roosevelt" },
            {"“Courage is not having the strength to go on; it is going on when you don't have the strength.”","Theodore Roosevelt" },
            {"“Whenever you are asked if you can do a job, tell 'em, 'Certainly I can!' Then get busy and find out how to do it.”","Theodore Roosevelt" },
            {"“Never throughout history has a man who lived a life of ease left a name worth remembering.”","Theodore Roosevelt" },
            {"“When you play, play hard; when you work, don't play at all.”","Theodore Roosevelt" },
            {"“No man needs sympathy because he has to work, because he has a burden to carry. Far and away the best prize that life offers is the chance to work hard at work worth doing.”","Theodore Roosevelt" },
            {"“Don't hit at all if it is honorably possible to avoid hitting; but never hit soft!”","Theodore Roosevelt" },
            {"“If you've got them by the balls, their hearts and minds will follow.”","Theodore Roosevelt" },
            {"“Politeness [is] a sign of dignity, not subservience.”","Theodore Roosevelt" },
            {"“The joy in life is his who has the heart to demand it.”","Theodore Roosevelt" },
            {"“It is not often that a man can make opportunities for himself. But he can put himself in such shape that when or if the opportunities come he is ready.”","Theodore Roosevelt" },
            {"“There is not a man of us who does not at times need a helping hand to be stretched out to him, and then shame upon him who will not stretch out the helping hand to his brother.”","Theodore Roosevelt" },
            {"“No man should receive a dollar unless that dollar has been fairly earned.”","Theodore Roosevelt" },
            {"“The worst of all fears is the fear of living”","Theodore Roosevelt" },
            {"“Courtesy is as much a mark of a gentleman as courage.”","Theodore Roosevelt" },
            {"“For those who fight for it life has a flavor the sheltered will never know”","Theodore Roosevelt" },
            {"“Comparison is the thief of joy.”","Theodore Roosevelt" },
            { "“There can be no life without change, and to be afraid of what is different or unfamiliar is to be afraid of life.”","Theodore Roosevelt" },
            {"“The only true wisdom is in knowing you know nothing.”", "Socrates" },
            {"“The unexamined life is not worth living.”", "Socrates" },
            {"“I cannot teach anybody anything. I can only make them think”", "Socrates" },
            {"“Wonder is the beginning of wisdom.”", "Socrates" },
            {"“Be kind, for everyone you meet is fghting a hard battle.”", "Socrates" },
            {"“Strong minds discuss ideas, average minds discuss events, weak minds discuss people.”", "Socrates" },
            {"“To find yourself, think for yourself.”", "Socrates" },
            {"“Education is the kindling of a flame, not the filling of a vessel.”", "Socrates" },
            {"“He who is not contented with what he has, would not be contented with what he would like to have.”", "Socrates" },
            {"“Be slow to fall into friendship, but when you are in, continue firm and constant.”", "Socrates" },
            {"“If you don't get what you want, you suffer; if you get what you don't want, you suffer; even when you get exactly what you want, you still suffer because you can't hold on to it forever. Your mind is your predicament. It wants to be free of change. Free of pain, free of the obligations of life and death. But change is law and no amount of pretending will alter that reality.”", "Socrates" },
            {"“Know thyself.”", "Socrates" },
            {"“When the debate is lost, slander becomes the tool of the loser.”", "Socrates" },
            {"“No man has the right to be an amateur in the matter of physical training. It is a shame for a man to grow old without seeing the beauty and strength of which his body is capable.”", "Socrates" },
            {"“Do not do to others what angers you if done to you by others.”", "Socrates" },
            {"“Employ your time in improving yourself by other men's writings so that you shall come easily by what others have labored hard for.”", "Socrates" },
            {"“We cannot live better than in seeking to become better.”", "Socrates" },
            {"“We can easily forgive a child who is afraid of the dark; the real tragedy of life is when men are afraid of the light.”", "Socrates" },
            {"“Understanding a question is half an answer.”", "Socrates" },
            {"“Be as you wish to seem.”", "Socrates" },
            {"“Life contains but two tragedies. One is not to get your heart’s desire; the other is to get it.”", "Socrates" },
            {"“True wisdom comes to each of us when we realize how little we understand about life, ourselves, and the world around us.”", "Socrates" },
            {"“The really important thing is not to live, but to live well. And to live well meant, along with more enjoyable things in life, to live according to your principles.”", "Socrates" },
            {"“My friend...care for your psyche...know thyself, for once we know ourselves, we may learn how to care for ourselves”", "Socrates" },
            {"“The mind is everything; what you think you become”", "Socrates" },
            {"“It is better to change an opinion than to persist in a wrong one.”", "Socrates" },
            {"“The secret of change is to focus all your energy, not fighting the old, but on building the new.”", "Socrates" },
            {"Wise men talk because they have something to say; fools, because they have to say something.", "Plato" },
            {"Be kind, for everyone you meet is fighting a hard battle.", "Plato" },
            {"Only the dead have seen the end of war.", "Plato" },
            {"The price good men pay for indifference to public affairs is to be ruled by evil men.", "Plato" },
            {"Good people do not need laws to tell them to act responsibly, while bad people will find a way around the laws.", "Plato" },
            {"“Do not train a child to learn by force or harshness; but direct them to it by what amuses their minds, so that you may be better able to discover with accuracy the peculiar bent of the genius of each.”", "Plato" },
            {"“Never discourage anyone...who continually makes progress, no matter how slow.”", "Plato" },
            {"“The measure of a man is what he does with power.”", "Plato" },
            {"“Human behavior flows from three main sources: desire, emotion, and knowledge. ”", "Plato" },
            {"“Education is teaching our children to desire the right things.”", "Plato" },
            {"“There are two things a person should never be angry at, what they can help, and what they cannot.”", "Plato" },
            {"“In politics we presume that everyone who knows how to get votes knows how to administer a city or a state. When we are ill... we do not ask for the handsomest physician, or the most eloquent one.”", "Plato" },
            {"“Character is simply habit long continued.”", "Plato" },
            {"“No man should bring children into the world who is unwilling to persevere to the end in their nature and education.”", "Plato" },
            {"“Bodily exercise, when compulsory, does no harm to the body; but knowledge which is acquired under compulsion obtains no hold on the mind.”", "Plato" },
            {"“An empty vessel makes the loudest sound, so they that have the least wit are the greatest babblers.”", "Plato" },
            {"“Good actions give strength to ourselves and inspire good actions in others. ”", "Plato" },
            {"“Any man may easily do harm, but not every man can do good to another.”", "Plato" },
            { "“The first and best victory is to conquer self”", "Plato" },
        };

        quotesMgrBg = new Dictionary<string, string>
        {
            {"В основата на всяка мъдрост е търпението.", "Платон" },
            {"Добрите хора не се нуждаят от закони, за да се държат правилно, а лошите винаги ще намерят как да ги заобиколят.", "Платон" },
            {"Дребните цели създават дребни личности.", "Платон" },
            {"Който сам не се убеди, никой не може да го убеди", "Платон" },
            {"Мъдрецът говори когато има да каже нещо, а глупакът - за да каже нещо.", "Платон" },
            {"Невежи са само тези, които са решили да си останат такива.", "Платон" },
            {"Никой не е станал добър човек случайно.", "Платон" },
            {"Говори, че да те видя.", "Сократ" },
            {"Лошите хора живеят, за да ядат и пият, докато добрите ядат и пият, за да живеят.", "Сократ" },
            {"На хората им е по-лесно да държат на езика си горещ въглен, отколкото тайна.", "Сократ" },
            {"Не изисквай от другите това, което ти сам не можеш да изпълниш.", "Сократ" },
            {"Непременно се ожени — ако вземеш добра жена ще си щастлив; ако вземеш лоша — ще станеш философ.", "Сократ" },
            {"Никога не предпочитай личната си глупост пред полезния съвет.", "Сократ" },
            {"Обучението е запалване на пламък, а не пълнене на съд.", "Сократ" },
            {"Познай себе си!", "Сократ" },
            {"Владетел, който не събира около себе си всички даровити и достойни хора, е пълководец без армия.", "Гьоте" },
            {"Всеки чува това, което разбира.", "Гьоте" },
            {"Голяма част от бедите на този свят идват от това, че хората недостатъчно добре са разбрали своите цели.", "Гьоте" },
            {"Не бъди нетърпелив, когато не приемат твоите аргументи.", "Гьоте" },
            {"Не е достатъчно само да се сдобиеш със знания, трябва да им намериш и приложение.", "Гьоте" },
            {"Няма положение, което да не би могло да се облагороди с усилие или търпение.", "Гьоте" },
            {"Природата никога не спира в своето движение и наказва всяко бездействие.", "Гьоте" },
            {"Разделяй и владей е мъдро правило, но Обединявай и направлявай е по-добро.", "Гьоте" },
            {"Съвети може да даваш само за работа, в която сам смяташ да вземеш участие.", "Гьоте" },
            {"Човек вижда толкова, колкото знае.", "Гьоте" },
            {"Щастлив е, който работи с радост и се радва на извършеното.", "Гьоте" },
            {"Ако вярвате, че можете, вие сте изминали половината път.", "Рузвелт" },
            {"Ако играеш, играй усърдно; но когато работиш, въобще не си играй.", "Рузвелт" },
            {"Вероятно най-голямата вреда от огромното богатство е тази, която ние, хората със средни възможности, сами си причиняваме, позволявайки такива пороци като завистта и ненавистта да навлязат дъбоко в нашите души.", "Рузвелт" },
            {"Войните, разбира се, като правило трябва да бъдат избягвани, но те са далече пò за предпочитане от някои видове мир.", "Рузвелт" },
            {"Всеки път, когато вземаш решение, най-доброто нещо, което можеш да направиш, е да направиш нещо правилно, следващото добро нещо е да направиш нещо грешно, най-лощото е да не направиш нищо.", "Рузвелт" },
            {"Големите мисли говорят само на мислещия ум, но големите дела говорят на цялото човечество.", "Рузвелт" },
            {"Далече по-добре е да се решиш на големи неща, да спечелиш славни триумфи, дори и маркирани със знака на провала…, отколкото да се наредиш сред тези бедни душѝ, които нито се наслаждават особено, нито страдат особено, защото живеят в някакъв сив полуздрач, който не познава нито победи, нито поражения.", "Рузвелт" },
            {"Девет десети от разсъдливостта е да бъдеш разсъдлив навреме.", "Рузвелт" },
            {"Дръж очите си в звездите, а краката си на земята.", "Рузвелт" },
            {"Момчето, което се кани да стане голям мъж, трябва да се реши не само да преодоле хиляди пречки, но и да спечели, въпреки хиляди отхвърляния и поражения.", "Рузвелт" },
            {"Най-голямата награда, която ни дава животът, е да се трудим усърдно за това, което наистина си струва.", "Рузвелт" },
            {"Не критикът има значение, не човекът, който изтъква как силните се препъват или къде онези, които вършат полезни дела, са могли да ги на правят по-добре. Уважение заслужава човекът, който действително излиза на арената, чието лице е белязано от прах, пот и кръв, който се стреми към целта без страх, който греши и отново и отново не улучва целта, защото няма усилие без грешки и недостатъци; който знае какво е да си безкористен и се посвещава на кауза, която си заслужава; който в най-добрия случай достига високите постижения на триумфа, а в най-лошия случай, ако не успее, а много му се иска, знае, че мястото му никога няма да бъде сред боязливите и студени душици, които не познават нито победата, нито поражението.", "Рузвелт" },
            {"Не можем да избегнем срещата с големите проблеми. Всичко, което можем да решим за себе си е, дали да ги посрещнем добре или зле.", "Рузвелт" },
            {"Не удряй, ако е възможно и достойно да се избегне ударът; но (ако ще удряш) никога не удряй слабо.", "Рузвелт" },
            {"Никога не греши само този, който нищо не прави.", "Рузвелт" },
            {"Прави това, което можеш, с това, което имаш, там, където се намираш.", "Рузвелт" },
            {"Със самодисциплина е възможно почти всичко.", "Рузвелт" },
            {"Тежко е да се провалиш, но по-лошо е никога да не се опиташ да успееш.", "Рузвелт" },
            {"„Дори да обиколим света в търсене на красотата, не я ли носим в себе си, не ще я открием.“", "Ралф Уолдо Емерсън" },
        };
    }

    public string GetRandomQuote()
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                quoteIndex = UnityEngine.Random.Range(0, quotesMgrBg.Count);
                return quotesMgrBg.ElementAt(quoteIndex).Key;
            case LanguageMgr.LANGUAGE_EN:
                quoteIndex = UnityEngine.Random.Range(0, quotesMgrEn.Count);
                return quotesMgrEn.ElementAt(quoteIndex).Key;
            default:
                quoteIndex = UnityEngine.Random.Range(0, quotesMgrEn.Count);
                return quotesMgrEn.ElementAt(quoteIndex).Key;
        }
    }

    public string GetCurrentQuoteAutor()
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                return quotesMgrBg.ElementAt(quoteIndex).Value;
            case LanguageMgr.LANGUAGE_EN:
                return quotesMgrEn.ElementAt(quoteIndex).Value;
            default:
                return quotesMgrEn.ElementAt(quoteIndex).Value;
        }
    }
}
