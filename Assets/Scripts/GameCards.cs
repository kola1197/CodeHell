using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class GameCards : MonoBehaviour
{
    public List<Card> mobsCards = new List<Card>(); 
    public List<Card> ImpactCards = new List<Card>();
    public List<Card> ItemsCards = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameCards()
    {
        GenerateCards();
    }

    public void GenerateMobs()
    {
        mobsCards.Add(new Monster("Общение с клиентом", "Вы же сможете, вы же Эксперт!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Критическая ошибка", "Половина офиса с облегчением отдыхает, проблема не на их сороне.", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(
            new Monster("Отчёт", "Долбанные бумаги! Что? В смысле вчера?!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Дедлайн", "В смысле вчера?!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Баг", "один есть, 5239 осталось", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Критическая ошибка",
            "Среди 400 предупреждений так легко пропустить действительно важные вещи", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Забыли проверку на null", "%description_text", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Провалы в текстуры", "Мб сделать скрытые проходы?", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Перепутали направление гравитации", "Или это был симулятор полета", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Переобучение ии", "“Правильно” не всегда значит “хорошо”", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("А что если так попробовать ?",
            "Похоже на начало истории об отличном стартапе. Или на начало очень плохой идеи", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("while (true))", "Бесконечность не предел!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Я художник, я так вижу!","Нет, мы не будем делать фиолетовых пауков", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Динамическая типизация", "Тут все и так ясно", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Переизбыток ctrl+c кода", "Жаль, что с деньгами так не выйдет...", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Неоднозначное тз", "Хочу то, сам не знаю чего, но чтобы принесли завтра!", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Я не буду делать как удобно!", "Цитаты великих...", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Похмелье", "Тише, пожалуйста", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Новый сериал на нетфликс", "Надо попробовать в следующий раз рассказать им спойлеры",
            0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Токсичный тимейт", "Вообще-то в \"тиммейт\" 2 м", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Тиммейт - тормоз", "Делает быстро всего одну вещь — уходит.", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Отсутствие консенсуса", "Лебедь, рак и щука", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Отпуск у тимлида", "Кто дал ему ключ от цепи?", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Расистские шуточки", "В чем разница между сбитыми негром и собакой? ... ", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Всеобщая прострация", "С этим надо бы что - то сделать, но может попозже?", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Не сходящаяся бухгалтерия", "Откуда там интегралы?", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Закончились кофе и вода в кулере",
            "Когда я трезвый и пустой, я поворачиваюсь к миру темной стороной", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Сломанный кондей", "Добро пожаловать в Сахару", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Эпидемия гриппа", "Передайте...Ачпхи… чаю...", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Хейтеры", "Как думаете, они ненавидят всех или только вас?", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Противники насилия", "Это они еще Доку 2 не видели...", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Проблемы с авторскими правами",
            "Экономить на композиторе и просто вставлять треки Audiomachine было не лучшей идеей", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Феминистки", "Вообще не понятно, при чем они тут", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Проблемы с балансом", "Даже в тетрисе были квадратные блоки", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Нулевая реиграбельность", "Когда была всего одна задача и всё равно не справились",
            0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Нападки сми", "-Нет мы не тестируем наше приложение на животных", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Творческий кризис", "Да откуда мне еще взять карточек?", 0, Monster.Type.OutsideTroubles));

    }

    public void GenerateImpacts()
    {
        ImpactCards.Add(new Impact("Регресионное тестирование", "Никто не знает, что это, но начальство довольно", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Костыль", "И так сойдет", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Божественное вмешательство", "Deus ex machina", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Отладка", "О, собирается, уже  неплохо", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Code review", "Мама посмотрела, говорит, что я молодец", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Переход на новую версию движка", "В смысле нет совместимости?", 0, Impact.Type.CodeTroubles));

        ImpactCards.Add(new Impact("Премии за переработки", "И эту ручку получает ...", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Офисный баскетбол", "Запишем, как тимбилдинг", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Медобследование", "Жаль только, что я не удосужился спросить у профессора, что такое шизофрения", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Перерыв на обед", "Иногда перетекает в ужин", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Jack Daniels", "Кто колы долил?!", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Новые технологии управления", "-А зачем тут эти коробки с кнутами и пряниками?", 0, Impact.Type.SocialTroubles));

        ImpactCards.Add(new Impact("Пост в Instagram", "У нас уже 5 подписчиков", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Распродажа", "Мне точно нужна эта ваза", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Игнорирование", "...", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Подкуп", "В смысле борзыми щенками вы боьше не берете?", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Пресс-конференция", "Мы ... ЭЭЭ ... тут новый дизайн кнопочки ...", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Добавление популярных технологий", "Не знаю зачем нам бокчейн, но заказчик согласен заплатить за проект в два раза больше", 0, Impact.Type.OutsideTroubles));
    }

    public void GenerateItems()
    {
        ImpactCards.Add(new Impact("Коробка процессоров", "А если подключить водопровод, можно съэкономить на горячей воде", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Удобные кресла", "Легким движжением превращается в кровать", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Пароль от гитхаба конкурентов", "sudo rm -rf", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Студенты на аутсорсе", "В трезвом виде могли бы закрыть проект за день", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Лицензионный софт", "Куплен в даркнете", 0, Impact.Type.CodeTroubles));        

        ImpactCards.Add(new Impact("Офисные коты", "Сотрудники в порезах, но довольные", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Штатный психолог", "Хорошо, что он еще и психиатр", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Стол для пинпонга", "Возможно стоит купить еще и ракетки", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Набор кляпов", "Ругань на языке жестов хотя-бы тише", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Кальян", "половина офиса скрыта туманом войны", 0, Impact.Type.SocialTroubles));

        ImpactCards.Add(new Impact("Телефон губернатора на быстром наборе", "Не работает, но придает уверенности", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Гипножаба для переговоров", "На последнем собрании акционеров стала владельцем предприятия", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Охранные чихуахуа", "Они делают больно иначе", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Странное кольцо", "Мояяя пррреллесть", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Гей-ниггер из далекого космоса", "Эхх, был бы он трансгендером", 0, Impact.Type.OutsideTroubles));
    }


    public void GenerateCards()
    {
        GenerateMobs();
        GenerateImpacts();
        GenerateItems();
    }

    public Card GetImpacts()
    {
        
        Random r = new Random();
        int i = Random.Range(0, ImpactCards.Count);
        return ImpactCards[i];
    }

    public Card GetCard()
    {
        int index = mobsCards.Count - 1;
        Card res = mobsCards[index];
        mobsCards.RemoveAt(index);
        return res;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
