﻿using System.Text;

namespace DFC.App.Help.Models.Robots
{
    public class Robot
    {
        private readonly StringBuilder robotData;

        public Robot()
        {
            robotData = new StringBuilder();
        }

        public string Data => robotData.ToString();

        public void Add(string text)
        {
            robotData.AppendLine(text);
        }
    }
}
