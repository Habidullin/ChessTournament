using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    // Клас, що представляє одну шахову гру між двома гравцями.
    // Зберігає інформацію про гравців та результат партії.
    public class Game
    {
        // Ім'я гравця, який грає білими фігурами
        public string PlayerW;
        // Ім'я гравця, який грає чорними фігурами
        public string PlayerB;
        // Результат гри: 1 - перемога білих, 0 - перемога чорних, 0.5 - нічия
        public float Result;
        public Game(string playerw, string playerb, float result)
        {
            PlayerW = playerw;
            PlayerB = playerb;
            Result = result;
        }
        // Метод для редагування даних існуючої гри
        public void Edit(string playerw, string playerb, float result)
        {
            PlayerW = playerw;
            PlayerB = playerb;
            Result = result;
        }

    }
}
