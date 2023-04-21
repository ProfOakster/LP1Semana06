namespace GameSixFriday
{
    public class GameLevel
    {
        private int numRooms;
        private int numFoes;
        private Difficulty difficulty;
        private Foe[] rooms;


        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.numRooms = numRooms;
            numFoes = 0;
            this.difficulty = difficulty;
            rooms = new Foe[numRooms];

        }

        public int GetNumRooms() => numRooms;
        public int GetNumFoes() => numFoes;
        public Difficulty GetDifficulty() => difficulty;


        public void SetFoeInRoom(int roomIndex, Foe foe)
        {
            rooms[roomIndex] = foe;
            numFoes += 1;
        }


        public void PrintFoes()
        {

        }



    }
}