namespace diceGame
{
    public class ScoreHandler
    {
        /*public static void ScoreBooleans()
        {
            TripletDetector.hasTriplet =  false;
        }*/

        public int TripletOutput(int value)
        {
            if (TripletDetector.i == 1) return value = 1000;
            if (TripletDetector.i == 2) return value = 200;
            if (TripletDetector.i == 3) return value = 300;
            if (TripletDetector.i == 4) return value = 400;
            if (TripletDetector.i == 5) return value = 500;
            if (TripletDetector.i == 6) return value = 600;
            return value = 0;
        }

        public int StraightOutput(int value)
        {
            StraightDetector detector = new();
            if (detector.HasStraight()) return value = 1500;
            return value = 0;
        }

        /*public bool TripleOnes(int points)
        {
            if (Die.rollStorage.Contains(1) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple ones! 1,000 points!");
                points = 1000;
                return true;
            }
            return false;
        }

        public bool TripleTwos()
        {
            if (Die.rollStorage.Contains(2) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple twos! 200 points!");
                points = 200;
                return true;
            }
            return false;
        }

        public bool TripleThrees()
        {
            if (Die.rollStorage.Contains(3) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple threes! 300 points!");
                points = 300;
                return true;
            }
            return false;
        }

        public bool TripleFours()
        {
            if (Die.rollStorage.Contains(4) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple fours! 400 points!");
                points = 400;
                return true;
            }
            return false;
        }

        public bool TripleFives()
        {
            if (Die.rollStorage.Contains(5) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple fives! 500 points!");
                points = 500;
                return true;
            }
            return false;
        }

        public bool TripleSix()
        {
            if (Die.rollStorage.Contains(6) && TripletDetector.hasTriplet)
            {
                //Console.WriteLine("You rolled tripple sixes! 600 points!");
                points = 600;
                return true;
            }
            return false;
        }*/

        /*string value;
        public string TripletScorevalue()
        {
            string ones = "You rolled tripple ones! 1,000 points!";
            string twos = "You rolled tripple twos! 200 points!";
            string threes = "You rolled tripple threes! 300 points!";
            string fours = "You rolled tripple fours! 400 points!";
            string fives = "You rolled tripple fives! 500 points!";
            string sixes = "You rolled tripple sixes! 600 points!";

            //string[] numbers = { };

            if (TripleOnes()) { value = ones; }
            if (TripleTwos()) { value = twos; }
            if (TripleThrees()) { value = threes; }
            if (TripleFours()) { value = fours; }
            if (TripleFives()) { value = fives; }
            if (TripleSix()) { value = sixes; }
            return value;
        }*/
    }
}