 string value1 = "scissors";
        string value2 = "rock";

        
       

    


        string rockpaperscissors(string one, string two)
            => (one, two) switch
        {
            ("rock","paper") => "Paper Won",
            ("rock", "scissors") => "Rock Won",
            ("paper", "rock") => "Paper Won",
            ("paper", "scissors") => "Scissors Won",
            ("scissors", "rock") => "Rock Won",
            ("scissors", "paper") => "Scissors Won",
            ("rock", "rock") => "Draw",
            ("scissors", "scissors") => "Draw",
            ("paper", "paper") => "Draw",
            (_,_) => "Values Are Empty"

        };

        Console.WriteLine(rockpaperscissors("paper", "scissors")); // 1st player's answer and 2nd player's answer
