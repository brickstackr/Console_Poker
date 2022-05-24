using System.Linq;
namespace ConsolePoker {
class PokerEvaluator {
    public enum HandTypes
    {
        Nothing,
        OnePair,
        TwoPairs,

        ThreeKind,

        Straight,

        Flush,

        FullHouse,

        FourKind
    }
    public struct HandValue
    {
        public int Total { get; set; }
        public int HighCard { get; set; }
    }
    //sort the poker hand 

    public class NumberRank
{
    public string Number {get; set;}
    public int Rank {get; set;}

    public NumberRank(string number, int rank)
    {
        Number = number;
        Rank = rank;
    }
}

    //public List<string> SortHand(List<string> Hand)

//    {   
  //      foreach (string line in Hand)
   //     {
     //       char first = line.FirstOrDefault();
        //    bool NumberTest = Char.IsNumber(first);
        //    if (NumberTest)
        //    int CardValue = 0;
        //    if(first =='A')
        //        CardValue = 1;
        //    else if(first == 'J')
        //        CardValue= 10;
        //    else if(first == 'Q')
        //        CardValue = 11;
        //    else if(first == 'K')
        //        CardValue = 12;
        //    else if(first == '1')
        //        CardValue = 1;
        //    else if(first == '2')
         //      CardValue = 2;
        //    else if(first == '3')
        //        CardValue = 3;    
        //    else if(first == '4')
        //        CardValue = 4;
        ///    else if(first == '5')
        //        CardValue = 5;
        //    else if(first == '6')
        //        CardValue = 6;
         //   else if(first == '7')
        //        CardValue = 7;
         //   else if(first == '8')
         //       CardValue = 8;
         //   else if(first == '9')
        //        CardValue = 9;
    //    }
   // }
    class HandEvaluator
    {
    //    private int heartsSum; 
    //    private int diamondSum; 
    //    private int clubSum;

    //    private int spadesSum;

    //    private Stack<string>? HandToCheck;

    //    private int handValue;

        //public HandEvaluator(Card[] sortedHand)
        //    {
         //       heartsSum = 0;
         //       diamondsSum = 0;
        //        clubsSum = 0;
        //        spadesSum = 0;
        ///        handValue = new HandValue();
        //    }

        //public HandValue HandValues
        //{
        //    get { return handValue; }
        //    set { handValue = value; }
        //}
    public string EvaluateHand(List<string> Hand)
    {
        //getNumberOfSuit();
        //if (FourOfKind())
        //    return "Four of a Kind";
        //else if (FullHouse())
        //    return "Full House";
        //else if (Flush())
        //    return "Full House";
        //else 
        //if (Straight())
        //    return "Straight"; 
        //else if (ThreeOfKind())
        //    return "Three of a Kind";
        //else if (TwoPairs())
        //    return "Two Pairs";
        //else if (OnePair())
        //    return "One Pair";
        //if the hand is nothing, then the player 
        //with highest cards wins
        // handValue.HighCard = (int)cards[4].MyValue;
        return "Nothing";
        
    }
    //private void getNumberOfSuit()
    //{
    //    foreach (var element in Hand)
    //    {
    //        if (element.MySuit == Card.SUIT.HEARTS)
    //            heartsSum++;
    //        else if (element.MySuit == Card.SUIT.DIAMONDS)
    //            diamondSum++;
    //        else if (element.MySuit == Card.SUIT.CLUBS)
    //            clubSum++;
    //        else if (element.MySuit == Card.SUIT.SPADES)
    //            spadesSum++;

    //    }
    //}
    //private bool FourOfKind()
    //{
    //    // if the first 4 cards, add values of the four cards
    //    if(cards[0].MyValue == cards[1].MyValue && cards[2].MyValue && cards[0].MyValue == cards[3].MyValue)
    //    {
    //        handValue.Total = (int)cards[1].MyValue * 4;
    //        handValue.HighCard = (int)cards[4].MyValue;
    //        return true;
    //    }
    //    else if (cards[1].MyValue == cards[2].MyValue && cards[3].MyValue && cards[1].MyValue == cards[4].MyValue)
    //    {
    //        handValue.Total = (int)cards[1].MyValue * 4;
    ///        handValue.HighCard = (int)cards[0].MyValue;
    //        return true
    //    }
    //    return false;
   // }
    //private bool FullHouse()
    //{
        // the first 3 cards and the last 2 cards are the same value
        // the first two cards and the last 3 cards are the same value
    //    if (cards[0].MyValue == cards[1].MyValue && cards[0].MyValue == cards[2].MyValue && cards[3].MyValue == cards[4].MyValue) ||
    //        (cards[0].MyValue == cards[1].MyValue && cards[2].MyValue == cards[3].MyValue && cards[2].MyValue == cards[4].MyValue)
    //    {
    //        handValue.Total = (int)(cards[0].MyValue) + (int)(cards[1].MyValue) + (int)(cards[2].MyValue) + (int)(cards[3].MyValue) + (int)(cards[4].MyValue);
    //        return true;
    //    }
    //    return false; 
    //}
    //private bool Flush()
    //{
        // if all suits are the same
    //    if (heartsSum ==5 || diamondSum == 5 || clubSum == 5 || spadesSum == 5)
    //        {
                // if flush, the player with higher cards wins
                // whoever has the last card the highest, has automatically all of the cards higher
    //            handValue.Total = (int)cards[4].MyValue;
     //           return true;
    //        }
    //    return false;
    //}
    private bool Straight(List<string> Hand)
    {
      //   if 5 consecutive values
        Stack<string> theStack = new Stack<string>();
        {   
        foreach (string line in Hand)
        {
            char first = line.FirstOrDefault();
            // string v = first;
            theStack.Push(first.ToString());
        }
        bool isAllEqual = theStack.Distinct().Count() == 1;
        if (isAllEqual)
            return true;
        else
            return false;    
        }}
    //    {
            // player with the highest value of the last vard wins
    //        handValue.Total = (int)cards[4].MyValue; 
    //        return true; 
    //    }
    //    return false; 
    //}
    //private bool ThreeOfKind() 
    //{
        // if the 1,2,3, cards are the same or 
        // 2,3,4 cards are the same 
        // or 3,4,5 are the same
        // 3rd card will always be part of three of a kind
    //    if ((cards[0].MyValue == cards[1].MyValue) && cards[0].MyValue == cards[2].MyValue) ||
    //    (cards[1].MyValue == cards[2].MyValue && cards[1].MyValue == cards[3].MyValue))
    //    {
    //        handValue.Total = (int)cards[2].MyValue *3;
     //       handValue.HighCard = (int)cards[4].MyValue;
     //       return true;
     //   }
    //    else if (cards[2].MyValue == cards[3].MyValue && cards[2].MyValue == cards[4].MyValue)
     //   {
    //        handValue.Total = (int)cards[2].MyValue *3;
     //       handValue.HighCard = (int)cards[1].MyValue;
    //        return true;
    //    }
      //  return false;
    //}
   // private bool TwoPairs()
    //{
        // if 1,2, and 3, 4
        // if 1,2, and 4,5
        // if 2,3, and 4,5,
        // with two pairs, the 2nd card will always be part of a pair
        // the 4th card will always be part of a second pair
        //if (cards[0].MyValue == cards[1].MyValue && cards[2].MyValue == cards[3].MyValue)
        //{
        //    handValue.Total = ((int)cards[1].MyValue *2) + ((int)cards[3].MyValue *2); 
        //    handValue.HighCard = (int)cards[4].MyValue;
        //    return true;
        //}
        //else if (cards[0].MyValue == cards[1].MyValue && cards[3].MyValue == cards[4].MyValue)
        //{
        //    handValue.Total = ((int)cards[1].MyValue *2) + ((int)cards[3].MyValue *2); 
        //    handValue.HighCard = (int)cards[4].MyValue;
        //    return true; 
       // }
        //else if (cards[1].MyValue == cards[2].MyValue && cards[3].MyValue == cards[4].MyValue)
       // {
       //     handValue.Total = ((int)cards[1].MyValue *2) + ((int)cards[3].MyValue *2); 
       //     handValue.HighCard = (int)cards[1].MyValue;
        //    return true; 
       // }
        //return false; 
   // }
   // private bool OnePair()
    //{
        // if 1,2, - 5 has highest value
        //2,3 - 
        //4,5 - 3 has highest
     //   if (cards[0].MyValue == cards[1].MyValue)
      //  {
        //    handValue.Total = (int)cards[0].MyValue*2;
         //   handValue.HighCard = (int)cards[4].MyValue;
          //  return true;
       // }
       // else if (cards[1].MyValue == cards[2].MyValue)
      //  {
       //     handValue.Total = (int)cards[1].MyValue *2;
        //    handValue.HighCard = (int)cards[4].MyValue;
        //    return true;
      //  }
      //  else if (cards[2].MyValue == cards[3].MyValue)
       // {
       //     handValue.Total = (int)cards[2].MyValue *2;
        //    handValue.HighCard = (int)cards[4].MyValue;
       //     return true;
      //  }
       // else if (cards[3].MyValue == cards[4].MyValue)
       // {
        //    handValue.Total = (int)cards[3].MyValue *2;
         //   handValue.HighCard = (int)cards[2].MyValue;
          //  return true;
       // }
     //   return false;
  //  }
    }
    }}