namespace diceGame
{
    public class ScoreHandler
    {
        public static int straightCount = 0;
        public static int tripletCount = 0;
        public static int quadrupletCount = 0;
        public static int quintupletCount = 0;
        public static int sextupletCount = 0;
        public static int totalPointsCount = 0;

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
        //i believe the "you rolled quadruple 0s!" issue arrises here. 
        // the above block is returning the score value TO TripletDetector.i
        //because the below block's if statement does not reference i, we get the zeros issue.
        //something in our lambda logic is incorrect. 
        // TripletDetect just looks for triples and THEN assigns score values based on diceface values -
        //this is NOT the correct logic for 'x of kind' category scores, because x of kind scores are awarded based on
        //HOW MANY 'x' there are, not the diceface value of each 'x'. 

        public int QuadrupletOutput(int value)
        {
            if (QuadrupletDetector.hasQuadruplet) return value = 1000;
            return value = 0;
        }

        public int QuintupletOutput(int value)
        {
            if (QuintupletDetector.hasQuintuplet) return value = 2000;
            return value = 0;
        }

        public int SextupletOutput(int value)
        {
            if (SextupletDetector.hasSextuplet) return value = 3000;
            return value = 0;
        }
        /*
        public int QuintupletOutput(int value)
        {
            //
        }

        public int SextupletOutput(int value)
        {
            //
        }
        */
        public int StraightOutput(int value)
        {
            StraightDetector detector = new();
            if (detector.HasStraight()) return value = 1500;
            return value = 0;
        }
    }
}
