﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CounterStrike
    {
        private string _playerName;
        private const int _pointsValue = 50;
        
        public double Points
        {
            get { return Skill.CurrentPoints; }
        }

        public Level Skill { get; set; }

        // constructor
        public CounterStrike(string playerName)
        {
            // new players are 'Beginner' by default
            Skill = new Beginner(this);
            _playerName = playerName;
            Console.WriteLine("{0} is the new player !", playerName);
            Console.WriteLine();
        }

        public void KillEnemies(int enemies)
        {
            var points = enemies * _pointsValue;
            Skill.WinPoints(points);

            var text = enemies <= 1 ? "enemy" : "enemies";
            Console.WriteLine("{0} killed {1} {2} => {3}pts won / sum of points: {4}", _playerName, enemies, text, points, Points);
            Console.WriteLine(" Skill: {0}", Skill.GetType().Name.ToUpper());
            Console.WriteLine();
        }

        public void HasBeenKilled()
        {
            Skill.LoosePoints(_pointsValue);
            Console.WriteLine("You have been killed: {0}pts left", Points);
            Console.WriteLine(" Skill: {0}", Skill.GetType().Name.ToUpper());
            Console.WriteLine();
        }
    }
}