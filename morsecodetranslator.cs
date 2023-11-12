using System;
using System.Collections.Generic;

namespace MCT {
	class MorseCodeTranslator {
		private readonly Dictionary<char, string> mcTable = new Dictionary<char, string>() {
			{'a', ".-"},
			{'b', "-..."},
			{'c', "-.-."},
			{'d', "-.."},
			{'e', "."},
			{'f', "..-."},
			{'g', "--."},
			{'h', "...."},
			{'i', ".."},
			{'j', ".---"},
			{'k', "-.-"},
			{'l', ".-.."},
			{'m', "--"},
			{'n', "-."},
			{'o', "---"},
			{'p', ".--."},
			{'q', "--.-"},
			{'r', ".-."},
			{'s', "..."},
			{'t', "-"},
			{'u', "..-"},
			{'v', "...-"},
			{'w', ".--"},
			{'x', "-..-"},
			{'y', "-.--"},
			{'z', "--.."},
			{'1', ".----"},
			{'2', "..---"},
			{'3', "...--"},
			{'4', "....-"},
			{'5', "....."},
			{'6', "-...."},
			{'7', "--..."},
			{'8', "---.."},
			{'9', "----."},
			{'0', "-----"},
			{' ', "/"},
		};

		public string TextToMorse(string text) {
			string newString = "";
			foreach (char c in text) {
				char newC = c.ToString().ToLower().ToCharArray()[0];
				if (!(mcTable.ContainsKey(newC))) {return "Invalid character inputted, only a-z/0-9 supported.";}
				newString += mcTable[newC] + " ";
			}

			return newString;
		}
	}
}
