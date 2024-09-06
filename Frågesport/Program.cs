
string answer;
List<Question> quiz = new List<Question>();
quiz.Add(new Question("Vilket är det största talet","1","e","pi","3",3));
int score= 0;
string ptheq,pop1,pop2,pop3,pop4,pcorrect;
int pcorrect2;

while (true) {
    mainmenu();
}


void mainmenu() {
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    System.Console.WriteLine("write what you want to do");
    System.Console.WriteLine("play");
    System.Console.WriteLine("Write");
    answer = Console.ReadLine().ToLower();
    if (answer == "play") {
        takequiz();
    }
    else if (answer == "write"){
        makequiz();
    }
    
}

void makequiz() {
    while (true) {
        Console.Clear();
        System.Console.WriteLine("Type the question");
        ptheq = Console.ReadLine();
        Console.WriteLine("type 4 option seperate with enter");
        pop1 = Console.ReadLine();
        pop2 = Console.ReadLine();
        pop3 = Console.ReadLine();
        pop4 = Console.ReadLine();
    
        Console.WriteLine("Type 1 if the correct answer is option 1 and so on");
        while (true) {
        pcorrect = Console.ReadLine();
        pcorrect2 = int.Parse(pcorrect);
        if (pcorrect2 <= 4){
            quiz.Add(new Question(ptheq,pop1,pop2,pop3,pop4,pcorrect2));
            break;
        }
        else {
        System.Console.WriteLine("Write 1, 2, 3 or 4");
        }

        }
        Console.Clear();
        System.Console.WriteLine("Card added want to add another one?");
        System.Console.WriteLine("yes / no");
        answer = Console.ReadLine().ToLower();
        if (answer == "no"){
            return;
        }
        else if(answer != "yes"){
            return;
        }
        // hitta de där vertikala strecken

    }
    
    
}
void takequiz() {
    score = 0;
    Console.Clear();
    System.Console.WriteLine("press any button to go to next question");
    Console.ReadLine();
    foreach (Question i in quiz){
    
        score += i.Run();
        Console.ReadLine();
        Console.BackgroundColor = ConsoleColor.Black;
    
    }
    Console.Clear();
    System.Console.WriteLine($"Score: {score.ToString()}");
    System.Console.WriteLine("play again");
    System.Console.WriteLine("yes / no");
    answer = Console.ReadLine();
    if (answer == "yes"){
        takequiz();
    }
    //jag vet att man inte ska kalla en metod i en metod men jag är gangster
    

}


class Question
{
    string theq,op1,op2,op3,op4;
    int correct;
    public Question(string theq, string op1, string op2, string op3, string op4, int correct)
    {
        this.theq = theq;
        this.op1 = op1;
        this.op2 = op2;
        this.op3 = op3;
        this.op4 = op4;
        this.correct = correct;
    }

    public int Run()
    {
        Console.Clear();
        System.Console.WriteLine(theq);
        System.Console.WriteLine(@$"A:{op1}        B:{op2}
C:{op3}        D:{op4}");

        if (this.ask() == correct){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Correct!!!!");
            
            return(1);
            
        }
        else{
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Wrong >:)");
            return(0);
        }
        

    }

    
    private int ask(){
        while (true){
            string answer = Console.ReadLine().ToLower();
            if (answer == "a"){
                return(1);
            }
            if (answer == "b"){
                return(2);
            }
            if (answer == "c"){
                return(3);
            }
            if (answer == "d"){
                return(4);
            }
            System.Console.WriteLine("Write A, B, C or D");
        }

    }
}
