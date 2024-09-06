List<Question> quiz = new List<Question>();
int score= 0;

foreach (Question i in quiz){
    score += i.Run();
}
Console.Clear();
System.Console.WriteLine($"Score: {score.ToString()}");


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
            return(1);
        }
        else{
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
