using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCards : MonoBehaviour
{
    public List<Card> mobsCards = new List<Card>(); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GenerateCards()
    {
        mobsCards.Add(new Monster("Общение с клиентом", "Вы же сможете, вы же Эксперт!", 0, Monster.Type.OutsideTroubles));
        mobsCards.Add(new Monster("Отчёт", "Долбанные бумаги! Что? Это только за неделю?"));
        mobsCards.Add(new Monster("Дедлайн", "Вы и так его знаете..."));
        mobsCards.Add(new Monster("Баг", "Несметные орды"));
        mobsCards.Add(new Monster("Критическая ошибка",
            "Среди 400 предупреждений так легко пропустить действительно важные вещи"));
        mobsCards.Add(new Monster("Забыли проверку на null", "Ошибка новичка"));
        mobsCards.Add(new Monster("Провалы в текстуры", "Ловушка Джокера нервно курит"));
        mobsCards.Add(new Monster("Перепутали направление гравитации", "Или это был симулятор полета"));
        mobsCards.Add(new Monster("Переобучение ии", "“Правильно” не всегда значит “хорошо”"));
        mobsCards.Add(new Monster("А что если так попробовать ?",
            "Похоже на начало истории об отличном стартапе. Или на начало очень плохой идеи"));
        mobsCards.Add(new Monster("while (true))", "Бесконечность не предел!"));
        mobsCards.Add(new Monster("Я художник, я так вижу!", "-Вася! Зачем 3d Берсерк?"));
        mobsCards.Add(new Monster("Динамическая типизация", "Тут все и так ясно"));
        mobsCards.Add(new Monster("Переизбыток ctrl+c кода", "Жаль, что с деньгами так не выйдет..."));
        mobsCards.Add(new Monster("Неоднозначное тз", "Хочу то, сам не знаю чего, но чтобы принесли завтра!"));
        mobsCards.Add(new Monster("Я не буду делать как удобно!", "Цитаты великих..."));
        mobsCards.Add(new Monster("Похмелье", "Тише, пожалуйста"));
        mobsCards.Add(new Monster("Новый сериал на нетфликс", "Надо попробовать в следующий раз рассказать им спойлеры"));
        mobsCards.Add(new Monster("Токсичный тиммейт", "Действительно злой и неприятный"));
        mobsCards.Add(new Monster("Тиммейт - тормоз", "Делает быстро всего одну вещь — уходит."));
        mobsCards.Add(new Monster("Отсутствие консенсуса", "Лебедь, рак и щука"));
        mobsCards.Add(new Monster("Отпуск у тимлида", "Кто снял замок с цепи?"));
        mobsCards.Add(new Monster("Расистские шуточки", "Негр и мексиканец падают с небоскрёба.Кто упадёт"));
        mobsCards.Add(new Monster("Всеобщая прострация", "С этим надо бы что - то сделать, но как - то все равно..."));
        mobsCards.Add(new Monster("Не сходящаяся бухгалтерия", "Не математики считают, что математики считают"));
        mobsCards.Add(new Monster("Закончились кофе и вода в кулере",
            "Когда я трезвый и пустой, я поворачиваюсь к миру темной стороной"));
        mobsCards.Add(new Monster("Сломанный кондей", "Добро пожаловать в Сахару"));
        mobsCards.Add(new Monster("Эпидемия гриппа", "Передайте...Ачпхи… чаю..."));
        mobsCards.Add(new Monster("Хейтеры", "Как думаете, они ненавидят всех или только вас?"));
        mobsCards.Add(new Monster("Противники насилия", "Это они еще Доку 2 не видели..."));
        mobsCards.Add(new Monster("Проблемы с авторскими правами",
            "Экономить на композиторе и просто вставлять треки Audiomachine было не лучшей идеей"));
        mobsCards.Add(new Monster("Феминистки", "Вообще не понятно, откуда они тут"));
        mobsCards.Add(new Monster("Проблемы с балансом", "Даже в тетрисе были квадратные блоки"));
        mobsCards.Add(new Monster("Нулевая реиграбельность", "Когда была всего одна задача и всё равно не справились"));
        mobsCards.Add(new Monster("СЛОЖНААААА", "ААААААААААА"));
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
