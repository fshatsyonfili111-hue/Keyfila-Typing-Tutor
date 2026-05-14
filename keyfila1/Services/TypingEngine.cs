using System;
using System.Diagnostics;

namespace keyfila1.Services
{
    public class TypingStats
    {
        public int WPM { get; set; }
        public double Accuracy { get; set; }
        public int Errors { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }

    public class TypingEngine
    {
        private Stopwatch stopwatch;
        private string targetText;
        private int totalCharacters;
        private int correctCharacters;
        private int errorCount;

        public bool IsRunning => stopwatch?.IsRunning ?? false;

        public void Start(string text)
        {
            targetText = text;
            totalCharacters = text.Length;
            correctCharacters = 0;
            errorCount = 0;
            stopwatch = Stopwatch.StartNew();
        }

        public TypingStats Stop()
        {
            stopwatch.Stop();
            return GetCurrentStats();
        }

        public void RecordKeyPress(bool isCorrect)
        {
            if (isCorrect) correctCharacters++;
            else errorCount++;
        }

        public TypingStats GetCurrentStats()
        {
            var elapsed = stopwatch?.Elapsed ?? TimeSpan.Zero;
            double minutes = elapsed.TotalMinutes;
            
            int wpm = 0;
            if (minutes > 0)
            {
                wpm = (int)((correctCharacters / 5.0) / minutes);
            }

            double accuracy = 0;
            int totalTyped = correctCharacters + errorCount;
            if (totalTyped > 0)
            {
                accuracy = (correctCharacters / (double)totalTyped) * 100;
            }

            return new TypingStats
            {
                WPM = wpm,
                Accuracy = Math.Round(accuracy, 1),
                Errors = errorCount,
                TimeElapsed = elapsed
            };
        }
    }
}
