namespace ConsolePoker
{
using System;
					
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
	
	public static void DealCards()
	{
		Card []Deck = new Card [52];
		Card t;
		int i, j, n=0;
		string [] v = new string[13] {"2","3","4","5","6","7","8","9","10","J","D","K","A"};
		string [] s = new string[4] {"h", "d", "c", "s"};
		
		Card []Player_1 = new Card[2];
		Card []Player_2 = new Card[2];
		Card []Table = new Card[5];
		Card []Searching = new Card[7];
		
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
					Console.Write("Player 1:");
					Player_1[i] = Deck[i];
					Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
				}
					else if(i<4)
					{
						Console.Write("Player 2:");
						Player_2[i-2] = Deck[i];
						Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
					}
						else 
						{
							Console.Write("Table:");
							Table[i-4] = Deck[i];
							Console.WriteLine(" {0}{1}", Deck[i].value, Deck[i].suit);
						}
			}
		
    }	
    }	
	}