using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Club.Katas.SnakesAndLadders
{
    // https://www.codewars.com/kata/587136ba2eefcb92a9000027/train/csharp
    public class SnakesLadders
    {
        public SnakesLadders()
        {
            _gameOver = false;
            InitialisePlayers();
        }

        public string play(int die1, int die2)
        {
            if (_gameOver) return "Game over!";

            MovePlayer(_playerTurn, die1 + die2);

            if (_players[_playerTurn].Position == 100)
            {
                _gameOver = true;
                return $"{_players[_playerTurn].Name} Wins!";
            }

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
        private List<Shortcut> _shortcuts;

        private int _playerTurn;
        private bool _gameOver;

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

        private void InitialiseShortcuts()
        {
            List<Shortcut> ladders = new List<Shortcut>
            {
                new Shortcut(2, 38),
                new Shortcut(7, 14),
                new Shortcut(8, 31),
                new Shortcut(15, 26),
                new Shortcut(21, 42),
                new Shortcut(28, 84),
                new Shortcut(36, 44),
                new Shortcut(51, 67),
                new Shortcut(71, 91),
                new Shortcut(78, 98),
                new Shortcut(87, 94),
            };
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

    public class Shortcut
    {
        public Shortcut(int startSquare, int destinationSquare)
        {
            StartSquare = startSquare;
            DestinationSquare = destinationSquare;
        }
        public int StartSquare { get; set; }
        public int DestinationSquare { get; set; }
    }
}
