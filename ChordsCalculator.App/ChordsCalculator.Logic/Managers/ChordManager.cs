using ChordsCalculator.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordsCalculator.Logic.Managers
{
    public class ChordManager
    {
        private readonly string[] AllNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        public Chord CalculateChord(string root, string type)
        {
            Chord chord = new Chord
            {
                Root = root,
                Type = type
            };
            int rootIndex = Array.IndexOf(AllNotes, root);

            if (rootIndex == -1) return null;

            switch (type.ToLower())
            {
                case "major":
                    chord.Notes.Add(AllNotes[rootIndex]);
                    chord.Notes.Add(AllNotes[(rootIndex + 4) % 12]);
                    chord.Notes.Add(AllNotes[(rootIndex + 7) % 12]);
                    break;
                case "minor":
                    chord.Notes.Add(AllNotes[rootIndex]);
                    chord.Notes.Add(AllNotes[(rootIndex + 3) % 12]);
                    chord.Notes.Add(AllNotes[(rootIndex + 7) % 12]);
                    break;
            }
            return chord;
        }
    }
}
