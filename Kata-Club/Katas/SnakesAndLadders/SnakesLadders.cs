using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Club.Katas.SnakesAndLadders
{
    public class SnakesLadders
    {
        public SnakesLadders()
        {
            _gameOver = false;
            InitialisePlayers();
            InitialiseShortcuts();
        }

        public string play(int die1, int die2)
        {
            if (_gameOver) return "Game over!";

            MoveCurrentPlayer(die1 + die2);

            if (_players[_playerTurnIdx].Position == 100)
            {
                _gameOver = true;
                return $"{_players[_playerTurnIdx].Name} Wins!";
            }

            var gameState = _players[_playerTurnIdx].GetGameState();

            if (die1 != die2)
            {
                IncrementPlayerTurn();
            }

            return gameState;
        }

        public Player GetPlayer(int index)
        {
            return _players[index];
        }

        private List<Player> _players;
        private List<Shortcut> _shortcuts;

        private int _playerTurnIdx;
        private bool _gameOver;

        private void MoveCurrentPlayer(int numberOfPositions)
        {
            var currentPlayer = _players[_playerTurnIdx];

            if (currentPlayer.Position + numberOfPositions > 100)
            {
                var bounceBackPosition = 100 - (currentPlayer.Position + numberOfPositions - 100);
                currentPlayer.Position = bounceBackPosition;
            }
            else
            {
                currentPlayer.Position += numberOfPositions;
            }

            var shortcut = _shortcuts.SingleOrDefault(x => x.StartSquare == currentPlayer.Position);

            if (shortcut != null)
            {
                currentPlayer.Position = shortcut.DestinationSquare;
            }
        }

        private void IncrementPlayerTurn()
        {
            if (_playerTurnIdx < _players.Count - 1)
            {
                _playerTurnIdx++;
            }
            else
            {
                _playerTurnIdx = 0;
            }
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
            _shortcuts = new List<Shortcut>();

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

            List<Shortcut> snakes = new List<Shortcut>
            {
                new Shortcut(16, 6),
                new Shortcut(46, 25),
                new Shortcut(49, 11),
                new Shortcut(62, 19),
                new Shortcut(64, 60),
                new Shortcut(74, 53),
                new Shortcut(89, 68),
                new Shortcut(92, 88),
                new Shortcut(95, 75),
                new Shortcut(99, 80),
            };

            _shortcuts.AddRange(ladders);
            _shortcuts.AddRange(snakes);
        }
    }

    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public string GetGameState()
        {
            return $"{Name} is on square {Position}";
        }

        public int Position { get; set; }
        public string Name { get; private set; }
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
