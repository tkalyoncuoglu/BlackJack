using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    

    public class Card 
    {

        public enum CardPicture
        {
            A = 1,
            J,
            Q,
            K
        }

        public enum CardColor
        {
            Spades = 0,
            Clubs,
            Diamods,
            Hearts
        }
        
        public int Number { get; set; }

        
        public CardColor Color { get; set; }

        public static int GetPictureNumber(CardPicture color) 
        {
            return 10 + (int)color;
        }

        public Card(CardPicture cardPicture, CardColor cardColor)
        {
            Number = GetPictureNumber(cardPicture);

            Color = cardColor;

        }

        public Card(int i, CardColor cardColor)
        {
            Number = i;

            Color = cardColor;
        }

        public static int GetMaxPictureNumber() 
        {
            return GetPictureNumber(CardPicture.K);
        }

        public static string[] NumberCaptions = new string[] { "", "A", "J", "Q", "K" }; 

        public static string[] ColorCaptions = new string[] { " \u2660", " \u2663", " \u2666", " \u2665" };  

        public int GetValue() 
        {    
            if(Number > 11)  
            {
                return 10;
            } 
            return Number;
        }

        public string GetCaption()
        {
            string res = string.Empty; 

            if(Number >= 11) 
            {
                res += NumberCaptions[Number-10]; 
            }
            else 
            {
                res += Number.ToString();
            }

            res += ColorCaptions[(int)Color]; 
            return res;
        }

        public void Print()
        {
            System.Console.WriteLine("Your Card: " + GetCaption() + " and it's value: " + GetValue());
        }
    }

    
   
} 
 