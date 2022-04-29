while (true)
{
    var randomLog = string.Format(DateTimeOffset.Now.ToString("s") + " " + RandomLog(), RandomUser(), RandomScore());
    Console.WriteLine(randomLog);

    await Task.Delay(3000);
}

string RandomLog() {
    var logs = new List<string>{ 
        "{0} died and lost {1} points!",
        "{0} scored {1} points",
        "{0} scored {1} points",
        "{0} scored {1} points",
        "{0} scored {1} points",
        "{0} scored {1} points",
        "{0} joined the server",
        "{0} left the server"
    };
    return logs.OrderBy(x => Guid.NewGuid()).First();
}

int RandomScore() {
    var random = new Random();
    return random.Next(100);
}

string RandomUser() {
    var users = new List<string>{ "Sjon", "Gerrie", "Frits", "Arend-Jan" };
    return users.OrderBy(x => Guid.NewGuid()).First();
}