using DecoratorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        string message1 = "Я подъехал, выходи";
        var recipientContacts1 = new List<string>
        {
            "knigamy@mer.ci.nsu.ru",
            "+79998080980",
            "@dxmort"
        };
        Component component = new ConcreteComponent();
        Component telegramComponent = new TelegramDecorator(component);
        telegramComponent.Send(message1, recipientContacts1);
        Console.WriteLine();


        string message2 = "Гойда, братья";
        var recipientContacts2 = new List<string>
        {
            "karpenkoev@mer.ci.nsu.ru",
            "+79996660660",
            "@Chert1lus"
        };
        Component component1 = new ConcreteComponent();
        Component telegramComponent1 = new TelegramDecorator(component1);
        Component smsComponent1 = new SMSDecorator(telegramComponent1);
        smsComponent1.Send(message2, recipientContacts2);
        Console.WriteLine();

        string message3 = "Уведомление";
        var recipientContacts3 = new List<string>
        {
            "test@gmail.com",
            "+70001112233"
        };
        Component component2 = new ConcreteComponent();
        component2.Send(message3, recipientContacts3);
        Console.WriteLine();
    }
}