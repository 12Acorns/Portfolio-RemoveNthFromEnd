using removeNthFromEndApp.Utility;
using System.ComponentModel.DataAnnotations;

namespace removeNthFromEndApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			start:
			Console.WriteLine("Enter array in form of [x, y ,z, ...] and so on, with a max length of 30, \n" +
				"with a maximum value of 100 and minimum of 0.");

			string _input = Console.ReadLine()!;

			Console.WriteLine("Enter desired index starting from end of array.");
			if(!int.TryParse(Console.ReadLine(), out int _desiredIndex))
			{
				throw new InvalidCastException("Cannot cast to int.");
			}
			if (!_input.StartsWith('['))
			{
				Console.WriteLine("Invalid Input");
				goto start;
			}
			else if (!_input.EndsWith(']'))
			{
				Console.WriteLine("Invalid Input");
				goto start;
			}
			_input = _input.Replace('[', ' ');
			_input = _input.Replace(']', ' '); ;
			string[] _splitInput = _input.Split(", ")!;
			List<int> _inputArray = new(_splitInput.Length);
			for (int i = 0; i < _splitInput.Length; i++)
			{
				switch(int.TryParse(_splitInput![i], out int _result))
				{
					case true:
						_inputArray.Add(_result);
						break;
					case false:
						throw new InvalidCastException("Cannot use unkown type in array, make sure array contains" +
							"numerical values only.");
				}
			}
			var _output = ArrayUtility.RemoveNthFromEnd(_inputArray.ToArray(), _desiredIndex);

			for (int i = 0; i < _output.Length; i++)
			{
				if(i == 0)
				{
					Console.Write($"[{_output[i]}, ");
					continue;
				}
				else if (i == _output.Length - 1)
				{
					Console.Write($"{_output[i]}]");
					continue;
				}
				switch(i % 10 == 0)
				{
					case true:
						Console.Write($"\n{_output[i]}, ");
						break;
					case false:
						Console.Write($"{_output[i]}, ");
						break;
				}
			}
			Console.WriteLine();
		}
	}
}