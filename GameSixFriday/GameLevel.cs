using System;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Difficulty difficulty;
        private Foe[] rooms;


        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            rooms = new Foe[numRooms];

        }

        public int GetNumRooms() => rooms.Length;
        public int GetNumFoes()
        {
            int numFoes = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    numFoes += 1;
                }
            }
            return numFoes;
        }
        public Difficulty GetDifficulty() => difficulty;


        public void SetFoeInRoom(int roomIndex, Foe foe) => rooms[roomIndex] = foe;



        public void PrintFoes()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {rooms[i].GetName()}");
                }

            }
        }



    }
}