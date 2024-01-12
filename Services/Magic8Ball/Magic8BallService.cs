namespace YounathanAMiniChallengeEightToTen_Endpoints.Services.Magic8Ball;

    public class Magic8BallService : IMagic8BallService
    {
        public string MagicBalling(string question)
        {
        Random rnd = new Random();
        int num = rnd.Next(0,9);
        switch(num){
            case 1:
                return "Yes.";
            case 2:
                return "Maybe.";
            case 3:
                return "IDK Dude im just a ball.";
            case 4:
                return "No.";
            case 5:
                return "Absolutely(did I spell that right).";
            case 6:
                return "How about you go see for yourself.";
            case 7: 
                return "Behind you.";
            case 8:
                return "That's it, you just pissed me off, ill give you 5 seconds to run!";
            default:
                return "Whoops I broke";
        }
        }
        
    }
