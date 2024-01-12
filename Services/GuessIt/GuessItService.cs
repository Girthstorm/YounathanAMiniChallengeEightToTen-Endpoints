namespace YounathanAMiniChallengeEightToTen_Endpoints.Services.GuessIt;
    public class GuessItService : IGuessItService
    {
        public string GuessEz(string num1)
        {
            Random answerGen = new Random();
            int answer = answerGen.Next(1,11);
            int num2 = 0;
            if(int.TryParse(num1, out num2)){

                if(num2 == answer){
                    return "CONGRATS YOU GOT IT RIGHT!!!!";
                } else if (num2 < answer) {
                    return $"Your number: {num2} was less than the answer: {answer}.";
                } else if (num2 > answer) {
                    return $"Your number: {num2} was greater than the answer: {answer}.";
                } else {
                    return "You found a bug";
                }
            }else{
                return "Your input was not a whole number please enter a WHOLE NUMBER.";
            }
        }
        public string GuessMed(string num1)
        {
            Random answerGen = new Random();
            int answer = answerGen.Next(1,51);
            int num2 = 0;
            if(int.TryParse(num1, out num2)){
                if(num2 == answer){
                    return "CONGRATS YOU GOT IT RIGHT!!!!";
                } else if (num2 < answer) {
                    return $"Your number: {num2} was less than the answer: {answer}.";
                } else if (num2 > answer) {
                    return $"Your number: {num2} was greater than the answer: {answer}.";
                } else {
                    return "You found a bug";
                }
            }else {
                return "Your input was not a whole number please enter a WHOLE NUMBER.";
            }
                
        }
        public string GuessHard(string num1)
        {
            Random answerGen = new Random();
            int answer = answerGen.Next(1,101);
            int num2 = 0;
            if(int.TryParse(num1, out num2)){
                if(num2 == answer){
                    return "CONGRATS YOU GOT IT RIGHT!!!!";
                } else if (num2 < answer) {
                    return $"Your number: {num2} was less than the answer: {answer}.";
                } else if (num2 > answer) {
                    return $"Your number: {num2} was greater than the answer: {answer}.";
                } else {
                    return "You found a bug";
                }
            }else{
                return "Your input was not a whole number please enter a WHOLE NUMBER.";
            }
        }
    }
