using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCards : MonoBehaviour
{
    public List<Card> mobsCards = new List<Card>(); 
    public List<Card> ImpactCards = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GenerateMobs()
    {
        mobsCards.Add(new Monster("Общение с клиентом", "Вы же сможете, вы же Эксперт!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(
            new Monster("Отчёт", "Долбанные бумаги! Что? Это только за неделю?", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Дедлайн", "Вы и так его знаете...", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Баг", "Несметные орды", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Критическая ошибка",
            "Среди 400 предупреждений так легко пропустить действительно важные вещи", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Забыли проверку на null", "Ошибка новичка", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Провалы в текстуры", "Ловушка Джокера нервно курит", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Перепутали направление гравитации", "Или это был симулятор полета", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Переобучение ии", "“Правильно” не всегда значит “хорошо”", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("А что если так попробовать ?",
            "Похоже на начало истории об отличном стартапе. Или на начало очень плохой идеи", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("while (true))", "Бесконечность не предел!", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Я художник, я так вижу!", "-Вася! Зачем 3d Берсерк?", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Динамическая типизация", "Тут все и так ясно", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Переизбыток ctrl+c кода", "Жаль, что с деньгами так не выйдет...", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Неоднозначное тз", "Хочу то, сам не знаю чего, но чтобы принесли завтра!", 0,
            Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Я не буду делать как удобно!", "Цитаты великих...", 0, Monster.Type.CodeTroubles));
        mobsCards.Add(new Monster("Похмелье", "Тише, пожалуйста", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Новый сериал на нетфликс", "Надо попробовать в следующий раз рассказать им спойлеры",
            0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Токсичный тиммейт", "Действительно злой и неприятный", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Тиммейт - тормоз", "Делает быстро всего одну вещь — уходит.", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Отсутствие консенсуса", "Лебедь, рак и щука", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Отпуск у тимлида", "Кто снял замок с цепи?", 0, Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Расистские шуточки", "Негр и мексиканец падают с небоскрёба.Кто упадёт", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Всеобщая прострация", "С этим надо бы что - то сделать, но как - то все равно...", 0,
            Monster.Type.SocialTroubles));
        mobsCards.Add(new Monster("Не сходящаяся бухгалтерия", "Не математики считают, что математики считают", 0,
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
        mobsCards.Add(new Monster("Феминистки", "Вообще не понятно, откуда они тут", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Проблемы с балансом", "Даже в тетрисе были квадратные блоки", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Нулевая реиграбельность", "Когда была всего одна задача и всё равно не справились",
            0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("СЛОЖНААААА", "ААААААААААА", 0, Monster.Type.OutsideTroubles));
    }

    public void GenerateImpacts()
    {
        ImpactCards.Add(new Impact("Регресионное тестирование", "", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Костыль", "", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Божественное вмешательство", "", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Отладка", "", 0, Impact.Type.CodeTroubles));
        ImpactCards.Add(new Impact("Code review", "", 0, Impact.Type.CodeTroubles));

        ImpactCards.Add(new Impact("Премии за переработки", "", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Офисный баскетбол", "", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Медобследование", "", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Перерыв на обед", "", 0, Impact.Type.SocialTroubles));
        ImpactCards.Add(new Impact("Jack Daniels", "", 0, Impact.Type.SocialTroubles));

        ImpactCards.Add(new Impact("Пост в Instagram", "", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Распродажа", "", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Игнорирование", "", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Подкуп", "", 0, Impact.Type.OutsideTroubles));
        ImpactCards.Add(new Impact("Пресс-конференция", "", 0, Impact.Type.OutsideTroubles));
    }

    public void GenerateCards()
    {
        GenerateMobs();
        GenerateImpacts();
    }

    Card GetCard()
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
