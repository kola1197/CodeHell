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
        mobsCards.Add(new Monster("Феминистки", "Вообще не понятно, откуда они тут", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Проблемы с балансом", "Даже в тетрисе были квадратные блоки", 0,
            Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Нулевая реиграбельность", "Когда была всего одна задача и всё равно не справились",
            0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("СЛОЖНААААА", "ААААААААААА", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Творческий кризис", "Да откуда мне еще взять карточек?", 0, Monster.Type.OutsideTroubles));

    }

    public void GenerateImpacts()
    {
       ImpactCards.Add(new Impact(""));
    }

    public void GenerateCards()
    {
        GenerateMobs();
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
