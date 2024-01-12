namespace YounathanAMiniChallengeEightToTen_Endpoints.Services.RestaurantPicker;

    public class RestaurantPickerService : IRestaurantPickerService
    {
    
        public string RestaurantMex()
        {
            string[] Mexican = {"La Huerta Vieja","La Parrilla","Las Casuelas", "La Morenita", "El Rosal", "Taqueria San Jose", "La Reyna", "Dos Compadres", "El Sol", "Taqueria Mis Compadres"};
            Random ran = new Random();
            return $"You chose Mexican.\nThe random mexican resturant is: {Mexican[ran.Next(0,10)]}"; 
        }
        public string RestaurantFast(){
            string[] FastFood = {"McDonald's","Sonic Drive-In", "Arby's", "Wendy's", "Burger King", "Wienershnitzel","Carl's Jr.", "Taco Bell", "In-N-Out", "Raising Canes"};
            Random ran = new Random();
            return $"You chose Fast Food.\nThe random fast food resturant is: {FastFood[ran.Next(0,10)]}";
        }

        public string RestaurantSushi(){
            string[] Sushi = {"Raw Sushi Bistro", "Oishi Teri", "Sushi Garden", "Fumi Sushi", "Osaka Sushi", "Kobe Sushi Buffet","Umi Sushi","Modesto Sukiyaki", "Tori Japanese Resturant","Konfuscious Eats",};
            Random ran = new Random();
            return $"You chose Sushi.\nThe random sushi resturant is: {Sushi[ran.Next(0,10)]}";
        }

    }

// return $"You chose Sushi.\nThe random sushi resturant is: {Sushi[ran.Next(0,11)]}";