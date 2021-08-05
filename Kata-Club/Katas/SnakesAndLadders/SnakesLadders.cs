using System;
using System.Collections.Generic;
using System.Text;

namespace Kata_Club.Katas.SnakesAndLadders
{
    // https://www.codewars.com/kata/587136ba2eefcb92a9000027/train/csharp
    public class SnakesLadders
    {
        public SnakesLadders()
        {
            InitialisePlayers();
        }

        public string play(int die1, int die2)
        {
            MovePlayer(_playerTurn, die1 + die2);

            var gameState = _players[_playerTurn].GetGameState();

            if (die1 == die2) return gameState;

            if (_playerTurn < _players.Count - 1)
            {
                _playerTurn++;
            }
            else
            {
                _playerTurn = 0;
            }

            return gameState;
        }

        public Player GetPlayer(int index)
        {
            return _players[index];
        }

        private List<Player> _players;
        private int _playerTurn;

        private void MovePlayer(int playerIndex, int numberOfPositions)
        {
            _players[playerIndex].Position += numberOfPositions;
        }

        private void InitialisePlayers()
        {
            _players = new List<Player>();

            var numberOfPlayers = 2;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                _players.Add(new Player($"Player {i + 1}"));
            }
        }
    }

    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public int Position { get; set; }
        public string Name { get; private set; }

        public string GetGameState()
        {
            return $"{Name} is on square {Position}";
        }
    }
}
