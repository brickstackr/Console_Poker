namespace ConsolePoker
{
using System;
using System.Collections;
					
public class CardHandling
{
	struct Card
	{
		public string value;
		public string suit;
		
		public void Card_Set(string value, string suit)
		{
			this.value = value;
			this.suit=suit;
		}
	}
    class HandOfCards : IEnumerator
    {
        int position = -1;
        public Card Card1;
        public Card Card2;

        public Card Card3;

        public Card Card4;

        public Card Card5;

        public bool MoveNext()
        {
            position++;
            return (position < 5);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }}
        public Card Current
        {
            get
            {
                try
                {
                    return this.Card1;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
    }
    }
	static public string DealCards()
	{
		Card []Deck = new Card [52];
		Card t;
		int i, j, n=0;
		string [] v = new string[13] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
		string [] s = new string[4] {"H", "D", "C", "S"};
		
		Random rand = new Random();

		for(i = 0; i<4;i++)
				for(j = 0; j <13;j++)
				{
					Deck[n].Card_Set(v[j],s[i]);
					n++;
				}
		
			for(i = 0;i<52;i++)
			{
				j = rand.Next(0,52);
				t = Deck[i];
				Deck[i] = Deck[j];
				Deck[j] = Deck[i];
			}
			
			for(i=0;i<9;i++)
			{
				if (i<2) 
				{
					return Deck[i].value + Deck[i].suit;
                    //Console.Write("Player 1:");
					//Player_1[i] = Deck[i];
					//Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
				}
					else if(i<4)
					{
                        return Deck[i].value + Deck[i].suit;
						//Console.Write("Player 2:");
						//Player_2[i-2] = Deck[i];
						//Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
					}
						else 
						{
                            return Deck[i].value + Deck[i].suit;
							//Console.Write("Table:");
							//Table[i-4] = Deck[i];
							//Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
						}
			}
            return "00";
}}}