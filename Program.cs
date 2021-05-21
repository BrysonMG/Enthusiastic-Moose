using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    questionCycle();

    void questionCycle()
    {
        Console.Write("Ask the moose a question: ");
        string question = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(question))
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(question);
            Console.WriteLine();
            ResponseGenerator();
            Console.WriteLine();
            questionCycle();
        }
    }
};



void MooseSays(string message)
{ //the @ before the string allows for a multi-line string
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};

void ResponseGenerator()
{
    Random num = new Random();
    int selection = num.Next(0, 20);

    switch (selection)
    {
        case 0:
            MooseSays("As I see it, yes.");
            break;
        case 1:
            MooseSays("Ask again later.");
            break;
        case 2:
            MooseSays("Better not tell you now.");
            break;
        case 3:
            MooseSays("Cannot predict now.");
            break;
        case 4:
            MooseSays("Concentrate and ask again.");
            break;
        case 5:
            MooseSays("Don't count on it.");
            break;
        case 6:
            MooseSays("It is certain.");
            break;
        case 7:
            MooseSays("It is decidedly so.");
            break;
        case 8:
            MooseSays("Most Likely");
            break;
        case 9:
            MooseSays("My reply is no.");
            break;
        case 10:
            MooseSays("My sources say no.");
            break;
        case 11:
            MooseSays("Outlook not so good.");
            break;
        case 12:
            MooseSays("Outlook good.");
            break;
        case 13:
            MooseSays("Reply hazy, try again.");
            break;
        case 14:
            MooseSays("Signs point to yes.");
            break;
        case 15:
            MooseSays("Very doubtful.");
            break;
        case 16:
            MooseSays("Without a doubt.");
            break;
        case 17:
            MooseSays("Yes.");
            break;
        case 18:
            MooseSays("Yes - definitely.");
            break;
        case 19:
            MooseSays("You may rely on it.");
            break;
    }
};