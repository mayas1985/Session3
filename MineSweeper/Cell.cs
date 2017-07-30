using System;

namespace MineSweeper
{
    public class Cell
    {
        public bool HasMine { get; private set; }
        public bool IsRevealed {get;private set;}
        public bool IsFlagged {get;private set;}
       
        public void AddMine(){
            HasMine = true;
        }
        public void Reveal() {
            IsRevealed = true;
        }

        public void AddFlag(){
            if(!IsRevealed)
                IsFlagged = true;
        }
    }
}
