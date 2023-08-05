using System;

public class Program{

    //All program variables

    public string letter="";

    bool finished=false;

    int chance=0;

    string win="";

    public string winperson="";

    public string completter="";

    int counter=0;

    public string[] board={" "," "," "," "," "," "," "," "," "};

    public bool draw=false;

    string invalid="''/'\'`~+-;:'?|{}<>.,[]()@!#$%^&*-_=qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

    string playerchance="humanplayer";

    public string input2="";

    public bool aiplayed=false;

    
    
    //main game function

    public void playfunction(){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("WELCOME TO TIC-TAC-TOE!\n");
        Console.WriteLine("PRESS ANY KEY TO PLAY, OR N TO EXIT");

        string input=Console.ReadLine().ToLower();
    
        if(input!="n"){
            Console.WriteLine("WHAT LETTER DO YOU WANT TO CHOOSE (X/O)");
            this.letter=Console.ReadLine().ToUpper();
            if(this.letter=="X"){
                this.completter="O";
            }
            else if(this.letter=="O"){
                this.completter="X";
            }
            if((this.letter!="X" && this.letter!="O") || this.letter==""){
                Console.WriteLine();
                Console.WriteLine("PLEASE ENTER A VALID CHARACTER");
                this.playfunction();
            }
            Console.WriteLine("DO YOU WANT TO PLAY AGAINST NOOBIE CPU, OR PRO CPU?(1 OR 2)");
            input2=Console.ReadLine();
            if(input2!="1" && input2!="2"){
                Console.WriteLine("INVALID VALUE, PLEASE TRY AGAIN");
                this.playfunction();
            }
            
        }
        else{
            Console.WriteLine();
            Console.WriteLine("GOODBYE!");
            return;
        }
        this.inputletter();
    }

    public void chanceswap(string p){
        if(p=="humanplayer" && this.input2=="1"){
            this.playerchance="dumbplayer";
            this.computerinputletter();
        }
        else if(p=="dumbplayer" && this.input2=="1"){
            this.playerchance="humanplayer";
            this.inputletter();
        }
        else if(p=="humanplayer" && this.input2=="2"){
            this.playerchance="aiplayer";
            this.AI();
        }
        else if(p=="aiplayer" && this.input2=="2"){
            this.playerchance="humanplayer";
            this.inputletter();
        }
    }
    public static void Main(String[] args){
         Program startKey = new Program();

         Console.ForegroundColor = ConsoleColor.Green;
         
         startKey.playfunction();
    
         startKey.getEmptySquares(startKey.board);
     }

    //Human player function
    public void inputletter(){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("WHICH POSITION DO YOU WANT TO ENTER? (0-8)");
        string inputnum=Console.ReadLine();
        this.counter=0;
        

        if(inputnum.Length>1 || inputnum.Length==0 || inputnum=="9"){
            Console.WriteLine();
            Console.WriteLine("PLEASE ENTER A VALID POSITION NUMBER (0-8)");
            Console.WriteLine();
            this.inputletter();
        }
        else if(inputnum.Length==1){
            if((int)char.Parse(inputnum)>=48 && (int)char.Parse(inputnum)<=56){
                int pos=Convert.ToInt32(inputnum);
                if(this.freespace(board,pos)){
                    this.board[pos]=this.letter;
                }
                else{
                    this.inputletter();
                }
                Console.WriteLine();
                Console.WriteLine("YOUR INPUT:");
                Console.WriteLine();
                
            }
            else{
                Console.WriteLine();
                Console.WriteLine("PLEASE ENTER A VALID POSITION NUMBER (0-8)");
                Console.WriteLine();
                this.inputletter();
            }
            
            this.aiplayed=false;
           
            
            this.winner(board);
        }

       
        
    }

    /*CPU Function*/

    public void computerinputletter(){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Random random=new Random();
        int randomnum=random.Next(0,9);
        while(!this.freespace(board,randomnum)){
            randomnum=random.Next(0,9);
        }

        this.board[randomnum]=this.completter;
        Console.WriteLine();
        Console.WriteLine("CPU'S INPUT:");
        Console.WriteLine();
        this.winner(this.board);


    }
    

    public void AI(){

        this.bestMoveFunction();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("CPU'S INPUT:");
        Console.WriteLine();
        this.aiplayed=true;
        this.winner(this.board);

        
    }

     public void bestMoveFunction(){

        int bestEval=1000;

        int bestMove=0;
        
        for(int i=0;i<9;i++){
            
            if(board[i]==" "){


                board[i]=this.completter;
                
                int eval=this.MiniMax(board,true);
                
                if(eval<bestEval){
                    bestEval=eval;
                    bestMove=i;
                }
                board[i]=" ";

            }
    
        }
       
        
        this.board[bestMove]=this.completter;

        return;
        

    }

    public int MiniMax(string[] board, bool isMaximizing){
        
    
        //Evaluation part of the function
        if(this.winnerAI(board,this.letter)){
            
            return 10;
        }
        else if(this.winnerAI(board,this.completter)){
            
            return -10;
        }
        else if(this.checkDraw(board)){
            
            return 0;
        }

        if(isMaximizing){
            int maxEval=-1000;
            for(int i=0; i<9;i++){
            
                if(board[i]==" "){
                    

                    board[i]=this.letter;
                    
                    int eval=this.MiniMax(board,false);

                    board[i]=" ";
                    
                    
                    
                    if(eval>maxEval){
                        maxEval=eval;
                    }
                    
                    
                }   
    
            }
            return maxEval;

        }

        else{
            int minEval=1000;
            for(int i=0; i<9;i++){
                if(board[i]==" "){

                    board[i]=this.completter;
                    
                    int eval=this.MiniMax(board,true);

                    
                    
                    board[i]=" ";
                
                    if(eval<minEval){
                        minEval=eval;
                        
                    }
                }   
    
            }
            return minEval;

        }
    
    return 0;
    }

    public bool winnerAI(string[] board, string mark){
        
        
        if(string.Compare(board[0],board[1])==0 && string.Compare(board[1],board[2])==0 && (board[0]==mark)){
            return true;
        }
        
        /*3,4,4,5*/
        else if(string.Compare(board[3],board[4])==0 && string.Compare(board[4],board[5])==0 && (board[3]==mark)){
            return true;
        }
        /*6,7,7,8*/
        else if(string.Compare(board[6],board[7])==0 && string.Compare(board[7],board[8])==0 && (board[6]==mark)){
            return true;
        }
        /*0,3,3,6*/
        else if(string.Compare(board[0],board[3])==0 && string.Compare(board[3],board[6])==0 && (board[0]==mark)){
            return true;
        }
        /*1,4,4,7*/
        else if(string.Compare(board[1],board[4])==0 && string.Compare(board[4],board[7])==0 && (board[1]==mark)){
            return true;
        }
        /*2,5,5,8*/
        else if(string.Compare(board[2],board[5])==0 && string.Compare(board[5],board[8])==0 && (board[2]==mark)){
            return true;
        }
        /*0,4,4,8*/
        else if(board[0]==board[4] && board[4]==board[8] && (board[0]==mark)){
            return true;
        }
        /*2,4,4,6*/
        else if(string.Compare(board[2],board[4])==0 && string.Compare(board[4],board[6])==0 && (board[2]==mark)){
            return true;
        }
        return false;
    }

    public bool checkDraw(string[] board){
        foreach(string i in board){
            if(i==" "){
                return false;
            }
        }
        return true;
    }

    public List<int> getEmptySquares(string[] board){
        
        List<int> emptySquares = new List<int>();
        for(int i=0;i<9;i++){
            if(board[i]==" "){
                emptySquares.Add(i);
            }
        }
        
        return emptySquares;
    }

    
    //Function to check if all spaces in the array are occupied
    public bool finishspace(string[] board){
        int counter=0;
        
        
        for(int i=0;i<9;i++){
            if(board[i]=="X" || board[i]=="O"){
                counter++;
                continue;
            }
            
        }
        if(counter==9){
            return true;
        }
        else{
            return false;
        }
    }

    //Function to check if space is available within the array
    public bool freespace(string[] board, int position){
        if(this.board[position]=="X" || this.board[position]=="O"){
            if(this.playerchance=="humanplayer"){
                Console.WriteLine("SORRY, THAT SPACE IS ALREADY TAKEN!");
            }
            
            return false;
        }
        else{
            return true;
        }
            
    }
        
    
    
    //All conditions that check if there is a winner or not
    public string winner(string[] board){
        
        
        if(string.Compare(board[0],board[1])==0 && string.Compare(board[1],board[2])==0 && (board[0]=="X" || board[0]=="O")){
            this.win=board[0];
        }
        
        /*3,4,4,5*/
        else if(string.Compare(board[3],board[4])==0 && string.Compare(board[4],board[5])==0 && (board[3]=="X" || board[3]=="O")){
            this.win=board[3];
        }
        /*6,7,7,8*/
        else if(string.Compare(board[6],board[7])==0 && string.Compare(board[7],board[8])==0 && (board[6]=="X" || board[6]=="O")){
            this.win=board[6];
        }
        /*0,3,3,6*/
        else if(string.Compare(board[0],board[3])==0 && string.Compare(board[3],board[6])==0 && (board[0]=="X" || board[0]=="O")){
            this.win=board[0];
        }
        /*1,4,4,7*/
        else if(string.Compare(board[1],board[4])==0 && string.Compare(board[4],board[7])==0 && (board[1]=="X" || board[1]=="O")){
            this.win=board[1];
        }
        /*2,5,5,8*/
        else if(string.Compare(board[2],board[5])==0 && string.Compare(board[5],board[8])==0 && (board[2]=="X" || board[2]=="O")){
            this.win=board[2];
        }
        /*0,4,4,8*/
        else if(board[0]==board[4] && board[4]==board[8] && (board[0]=="X" || board[0]=="O")){
            this.win=board[0];
        }
        /*2,4,4,6*/
        else if(string.Compare(board[2],board[4])==0 && string.Compare(board[4],board[6])==0 && (board[2]=="X" || board[2]=="O")){
            this.win=board[2];
        }
        
        if(this.win=="" && this.finishspace(board)==true){
            this.finished=true;
            this.draw=true;
            
            
            
        }
        
        if(this.win=="X"){
            this.finished=true;
            Console.WriteLine();
            this.winperson="X";
            
            
           
        }
        else if(this.win=="O"){
            this.finished=true;
            Console.WriteLine();
            this.winperson="O";
            
        }
        
        
        this.callprintboard();
        return " ";
    }

    public string winstorer(string winstore){
        if(this.draw){
            return "TIE";
        }
        else{
            return winstore;
        }
        
    }

    public void callprintboard(){
        this.printboard();
    }

    //Function that prints and the board and also displays the result of the game

    public void printboard(){

        Console.Write($"   {this.board[0]}   "+"|"+$"   {this.board[1]}   "+"|"+$"   {this.board[2]}   ");
        
        
        Console.Write("\n");
        Console.Write("-----------------------");
        Console.Write("\n");
        Console.Write($"   {this.board[3]}   "+"|"+$"   {this.board[4]}   "+"|"+$"   {this.board[5]}   ");
        
        
        Console.Write("\n");
        Console.Write("-----------------------");
        Console.Write("\n");
        Console.Write($"   {this.board[6]}   "+"|"+$"   {this.board[7]}   "+"|"+$"   {this.board[8]}   ");
        
       
        if(this.finished){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(this.winperson=="X"){
                if(this.winperson==this.letter){
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("YOU ARE THE WINNER!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("THANKS FOR PLAYING!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return;
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CPU WINS!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("THANKS FOR PLAYING!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return;
                }
                
            }
            else if(this.winperson=="O"){
                if(this.winperson==this.letter){
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("YOU ARE THE WINNER!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("THANKS FOR PLAYING!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return;
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CPU WINS!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("THANKS FOR PLAYING!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return;
                }
                
            }
            else if(this.draw==true){
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ITS A DRAW MATCH!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("THANKS FOR PLAYING!");
                Console.ForegroundColor = ConsoleColor.Green;
                return;
                
            }
            
        }
        else{

            this.chanceswap(this.playerchance);
            
        }
        
        

    }
}
