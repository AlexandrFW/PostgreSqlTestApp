
using PostgreSqlTestApp;

// Укажите пароль от Postgres в AppDbContext

Console.WriteLine("Тестирование PostgreSQL в качестве сервера базы данных!\r");
Console.WriteLine("Создаём пользователей!\r");

// Создаём БД и записываем туда пользователй
using (var db = new AppDbContext())
{
    Console.WriteLine("Подключено к базе данных");

    var user1 = new User { Name = "Александр", Age = 37 };
    var user2 = new User { Name = "Иван", Age = 34 };
    var user3 = new User { Name = "Никита", Age = 20 };

    db.Users!.AddRange(user1, user2, user3);
    db.SaveChanges();

    Console.WriteLine("Пользователи созданы!\r");
}

Console.WriteLine("");

Console.WriteLine("Выводим список пользователей из базы данных!\r");

// Выводим пользователей в консоль
using (var db = new AppDbContext())
{
    var users = db.Users!.ToList();

    Console.WriteLine("Список пользователей:");

    if (users.Any())
    {
        foreach (var user in users)
            Console.WriteLine($"User name: {user.Name}; Age: {user.Age}");
    }
}

Console.ReadKey();