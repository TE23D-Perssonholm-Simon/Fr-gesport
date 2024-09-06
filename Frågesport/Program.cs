
using System.Formats.Asn1;

string answer;
int answer2;
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
    System.Console.WriteLine("edit");
    answer = Console.ReadLine().ToLower();
    if (answer == "play") {
        takequiz();
    }
    else if (answer == "edit"){

        edit();
    }
    
}
void edit() {
    Console.Clear();
    System.Console.WriteLine("change");
    System.Console.WriteLine("add");
    System.Console.WriteLine("exit");
    answer = Console.ReadLine().ToLower();
    if (answer == "add") {
        addquestion();
    }
    else if (answer == "exit") {
        return;
    }
    else if (answer == "change"){
        while (change());
    }
}

bool change() {
    Console.Clear();
    System.Console.WriteLine("Type the number of the question you want to edit");
    for (int i= 0; i< quiz.Count(); i++){
        System.Console.WriteLine(@$"{i}: {quiz[i].Thequestion()}");
    }
    System.Console.WriteLine($"{quiz.Count()}: Exit");
    answer2 = int.Parse(Console.ReadLine());
    if (answer2 >= quiz.Count()) {
        return(false);
    }
    System.Console.WriteLine("delete or edit?");
    answer = Console.ReadLine();
    if (answer == "edit"){
        quiz[answer2].edit();
    }
    else if (answer == "delete"){
        quiz.RemoveAt(answer2);
    }
    return(true);
}
void addquestion() {
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
    float procentscore;
    procentscore = score* 100/quiz.Count() ;
    System.Console.WriteLine($"Score: {procentscore.ToString()}%");
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
    public string Thequestion(){
        return(theq);
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

    private string Newvalue(){
        System.Console.WriteLine("What do you want to replace it with");
        return(Console.ReadLine());
    }

    public void edit(){
        string answer;
        Console.Clear();
        System.Console.WriteLine($"the question: {theq}");
        System.Console.WriteLine($"option1: {op1}");
        System.Console.WriteLine($"option2: {op2}");
        System.Console.WriteLine($"option3: {op3}");
        System.Console.WriteLine($"option4: {op4}");
        System.Console.WriteLine($"the answer: {correct.ToString()}");
        Console.WriteLine("exit");
        while (true){
            System.Console.WriteLine("what do you want to edit");
            answer = Console.ReadLine().ToLower();
            if (answer == "the question"){
                theq = Newvalue();
                System.Console.WriteLine("changed :)");

            }
            else if (answer == "option1"){
                op1 = Newvalue();
                System.Console.WriteLine("changed :)");
            }
            else if (answer == "option2"){
                op2 = Newvalue();
                System.Console.WriteLine("changed :)");
            }
            else if (answer == "option3"){
                op3 = Newvalue();
                System.Console.WriteLine("changed :)");
            }
            else if (answer == "option4"){
                op4 = Newvalue();
                System.Console.WriteLine("changed :)");
            }
            else if (answer == "the answer"){
                System.Console.WriteLine("What do you want to change it to");
                System.Console.WriteLine("Write 1, 2, 3 or 4");
                while (true) {
                    answer = Console.ReadLine();

                    if (int.Parse(answer) <= 4){
                        correct = int.Parse(answer);
                        System.Console.WriteLine("changed :)");
                    }
            
                    else {
                    System.Console.WriteLine("Write 1, 2, 3 or 4!!!!!!");
                }
            

        }
            }
            else if (answer == "exit"){
                return;
            }
        }
        
    }
}
