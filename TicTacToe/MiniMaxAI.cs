public class TicTacToeAI {
    public void bestMoveFunction(){

        Program instance = new Program();

        int bestEval=1000;

        int bestMove=0;

        for(int i=0;i<9;i++){
            
            if(instance.board[i]==" "){


                instance.board[i]="O";
                
                int eval=this.MiniMax(instance.board,true);
                
                if(eval<bestEval){
                    bestEval=eval;
                    bestMove=i;
                }

                instance.board[i]=" ";

            }
    
        }
       
        
        instance.board[bestMove]="O";

        return;
        

    }

    public int MiniMax(string[] board, bool isMaximizing){
        //Program instance = new Program();
        
    
        //Evaluation part of the function
        if(this.winnerAI(board,"X")){
            
            return 10;
        }
        else if(this.winnerAI(board,"O")){
            
            return -10;
        }
        else if(this.checkDraw(board)){
            
            return 0;
        }

        if(isMaximizing){
            int maxEval=-1000;
            for(int i=0; i<9;i++){
            
                if(board[i]==" "){
                    

                    board[i]="X";
                    
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

                    board[i]="O";
                    
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
    public string[] deepCopy(string[] arr){
        string[] arrCopy=new string[9];
        int counter=0;
        foreach(string i in arr){
            arrCopy[counter]=i;
            counter++;
        }
        return arrCopy;
    }

    
 
}