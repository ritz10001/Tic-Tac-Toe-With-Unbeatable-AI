using System;

public class Program{

    //All program variables

    public string humanLetter="";

    bool finishedGame=false;

    string gameLetterWinner="";

    public string gameWinner="";

    public string opponentLetter="";

    int counter=0;

    public string[] board={" "," "," "," "," "," "," "," "," "};

    public bool drawGame=false;

    string invalidCharacters="''/'\'`~+-;:'?|{}<>.,[]()@!#$%^&*-_=qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

    string playerTurn="humanplayer";

    public string cpuDifficulty="";

    public bool aiPlayed=false;

    
    
    //main game function

    public void gameFunction(){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("WELCOME TO TIC-TAC-TOE!\n");
        Console.WriteLine("PRESS ANY KEY TO PLAY, OR N TO EXIT");

        string input=Console.ReadLine().ToLower();
    
        if(input!="n"){
            Console.WriteLine("WHAT LETTER DO YOU WANT TO CHOOSE (X/O)");
            this.humanLetter=Console.ReadLine().ToUpper();
            if(this.humanLetter=="X"){
                this.opponentLetter="O";
            }
            else if(this.humanLetter=="O"){
                this.opponentLetter="X";
            }
            if((this.humanLetter!="X" && this.humanLetter!="O") || this.humanLetter==""){
                Console.WriteLine();
                Console.WriteLine("PLEASE ENTER A VALID CHARACTER");
                this.gameFunction();
            }

            Console.WriteLine("DO YOU WANT TO PLAY AGAINST NOOBIE CPU, OR PRO CPU?(1 OR 2)");
            this.cpuDifficulty=Console.ReadLine();
            if(this.cpuDifficulty!="1" && this.cpuDifficulty!="2"){
                Console.WriteLine("INVALID VALUE, PLEASE TRY AGAIN");
                this.gameFunction();
            }
            
        }
        else{
            Console.WriteLine();
            Console.WriteLine("GOODBYE!");
            return;
        }
        this.humanInput();
    }

    public void chanceSwap(string p){
        if(p=="humanplayer" && this.cpuDifficulty=="1"){
            this.playerTurn="dumbplayer";
            this.randomCpuInput();
        }
        else if(p=="dumbplayer" && this.cpuDifficulty=="1"){
            this.playerTurn="humanplayer";
            this.humanInput();
        }
        else if(p=="humanplayer" && this.cpuDifficulty=="2"){
            this.playerTurn="aiplayer";
            this.AI();
        }
        else if(p=="aiplayer" && this.cpuDifficulty=="2"){
            this.playerTurn="humanplayer";
            this.humanInput();
        }
    }
    public static void Main(String[] args){
         Program startKey = new Program();

         Console.ForegroundColor = ConsoleColor.Green;
         
         startKey.gameFunction();
    
         startKey.getEmptySquares(startKey.board);
     }

    //Human player function
    public void humanInput(){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("WHICH POSITION DO YOU WANT TO ENTER? (0-8)");
        string inputIndex=Console.ReadLine();
        this.counter=0;
        
        if(inputIndex.Length>1 || inputIndex.Length==0 || inputIndex=="9"){
            Console.WriteLine();
            Console.WriteLine("PLEASE ENTER A VALID POSITION NUMBER (0-8)");
            Console.WriteLine();
            this.humanInput();
        }
        else if(inputIndex.Length==1){
            if((int)char.Parse(inputIndex)>=48 && (int)char.Parse(inputIndex)<=56){
                int positionIndex=Convert.ToInt32(inputIndex);
                if(this.freeSpace(board,positionIndex)){
                    this.board[positionIndex]=this.humanLetter;
                }
                else{
                    this.humanInput();
                }
                Console.WriteLine();
                Console.WriteLine("YOUR INPUT:");
                Console.WriteLine();
                
            }
            else{
                Console.WriteLine();
                Console.WriteLine("PLEASE ENTER A VALID POSITION NUMBER (0-8)");
                Console.WriteLine();
                this.humanInput();
            }
            
            this.aiPlayed=false;
            
            this.gameDecider(board);
        }

       
        
    }

    /*CPU Function*/

    public void randomCpuInput(){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Random random=new Random();
        int randomIndex=random.Next(0,9);
        while(!this.freeSpace(board,randomIndex)){
            randomIndex=random.Next(0,9);
        }

        this.board[randomIndex]=this.opponentLetter;
        Console.WriteLine();
        Console.WriteLine("CPU'S INPUT:");
        Console.WriteLine();
        this.gameDecider(this.board);


    }
    

    public void AI(){

        this.bestMoveFunction();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("CPU'S INPUT:");
        Console.WriteLine();
        this.aiPlayed=true;
        this.gameDecider(this.board);

        
    }

     public void bestMoveFunction(){

        int bestEval=1000;

        int bestMove=0;
        
        for(int i=0;i<9;i++){
            
            if(board[i]==" "){

                board[i]=this.opponentLetter;
                
                int eval=this.MiniMax(board,true);
                
                if(eval<bestEval){
                    bestEval=eval;
                    bestMove=i;
                }
                board[i]=" ";

            }
    
        }
        
        this.board[bestMove]=this.opponentLetter;

        return;
        

    }

    public int MiniMax(string[] board, bool isMaximizing){

        //Evaluation part of the function
        if(this.gameDeciderAI(board,this.humanLetter)){
            
            return 10;
        }
        else if(this.gameDeciderAI(board,this.opponentLetter)){
            
            return -10;
        }
        else if(this.checkDraw(board)){
            
            return 0;
        }

        if(isMaximizing){
            int maxEval=-1000;
            for(int i=0; i<9;i++){
            
                if(board[i]==" "){

                    board[i]=this.humanLetter;
                    
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

                    board[i]=this.opponentLetter;
                    
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

    public bool gameDeciderAI(string[] board, string mark){
        
        
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
    public bool isBoardComplete(string[] board){
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
    public bool freeSpace(string[] board, int position){
        if(this.board[position]=="X" || this.board[position]=="O"){
            if(this.playerTurn=="humanplayer"){
                Console.WriteLine("SORRY, THAT SPACE IS ALREADY TAKEN!");
            }
            
            return false;
        }
        else{
            return true;
        }
            
    }
        
    
    
    //All conditions that check if there is a winner or not
    public string gameDecider(string[] board){
        
        
        if(string.Compare(board[0],board[1])==0 && string.Compare(board[1],board[2])==0 && (board[0]=="X" || board[0]=="O")){
            this.gameLetterWinner=board[0];
        }
        
        /*3,4,4,5*/
        else if(string.Compare(board[3],board[4])==0 && string.Compare(board[4],board[5])==0 && (board[3]=="X" || board[3]=="O")){
            this.gameLetterWinner=board[3];
        }
        /*6,7,7,8*/
        else if(string.Compare(board[6],board[7])==0 && string.Compare(board[7],board[8])==0 && (board[6]=="X" || board[6]=="O")){
            this.gameLetterWinner=board[6];
        }
        /*0,3,3,6*/
        else if(string.Compare(board[0],board[3])==0 && string.Compare(board[3],board[6])==0 && (board[0]=="X" || board[0]=="O")){
            this.gameLetterWinner=board[0];
        }
        /*1,4,4,7*/
        else if(string.Compare(board[1],board[4])==0 && string.Compare(board[4],board[7])==0 && (board[1]=="X" || board[1]=="O")){
            this.gameLetterWinner=board[1];
        }
        /*2,5,5,8*/
        else if(string.Compare(board[2],board[5])==0 && string.Compare(board[5],board[8])==0 && (board[2]=="X" || board[2]=="O")){
            this.gameLetterWinner=board[2];
        }
        /*0,4,4,8*/
        else if(board[0]==board[4] && board[4]==board[8] && (board[0]=="X" || board[0]=="O")){
            this.gameLetterWinner=board[0];
        }
        /*2,4,4,6*/
        else if(string.Compare(board[2],board[4])==0 && string.Compare(board[4],board[6])==0 && (board[2]=="X" || board[2]=="O")){
            this.gameLetterWinner=board[2];
        }
        
        if(this.gameLetterWinner=="" && this.isBoardComplete(board)==true){
            this.finishedGame=true;
            this.drawGame=true;
            
            
            
        }
        
        if(this.gameLetterWinner=="X"){
            this.finishedGame=true;
            Console.WriteLine();
            this.gameWinner="X";
            
            
           
        }
        else if(this.gameLetterWinner=="O"){
            this.finishedGame=true;
            Console.WriteLine();
            this.gameWinner="O";
            
        }
        
        
        this.callPrintBoard();
        return " ";
    }

    public string winstorer(string winstore){
        if(this.drawGame){
            return "TIE";
        }
        else{
            return winstore;
        }
        
    }

    public void callPrintBoard(){
        this.printBoard();
    }

    //Function that prints and the board and also displays the result of the game

    public void printBoard(){

        Console.Write($"   {this.board[0]}   "+"|"+$"   {this.board[1]}   "+"|"+$"   {this.board[2]}   ");
        
        
        Console.Write("\n");
        Console.Write("-----------------------");
        Console.Write("\n");
        Console.Write($"   {this.board[3]}   "+"|"+$"   {this.board[4]}   "+"|"+$"   {this.board[5]}   ");
        
        
        Console.Write("\n");
        Console.Write("-----------------------");
        Console.Write("\n");
        Console.Write($"   {this.board[6]}   "+"|"+$"   {this.board[7]}   "+"|"+$"   {this.board[8]}   ");
        
       
        if(this.finishedGame){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(this.gameWinner=="X"){
                if(this.gameWinner==this.humanLetter){
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
            else if(this.gameWinner=="O"){
                if(this.gameWinner==this.humanLetter){
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
            else if(this.drawGame==true){
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

            this.chanceSwap(this.playerTurn);
            
        }
        
        

    }
}
