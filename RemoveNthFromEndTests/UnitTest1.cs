using removeNthFromEndApp.Utility;
namespace RemoveNthFromEndTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestNthElementFromEnd()
		{
			int[][] _testArrays = new int[4][]
			{
				new int[5] {1, 2, 3, 4, 5},
				new int[5] {12, 33, 7, 3, 8},
				new int[4] {1, 0, 88, 5},
				new int[5] {1, 2, 3, 4, 5},
			};
			(int[] _expectedOutput, int _subtraction)[] 
				_expectedReturnType = new (int[], int)[4]
			{
				(new int[4] { 1, 2, 3, 5}, 2),
				(new int[4] {12, 33, 7, 3}, 1),
				(new int[3] { 1, 88, 5}, 3),
				(new int[4] { 2, 3, 4, 5}, 5),
			};
			for (int i = 0; i < _expectedReturnType.Length; i++)
			{
				for (int j = 0; j < _expectedReturnType[i]._expectedOutput.Length; j++)
				{
					Assert.AreEqual(_expectedReturnType[i]._expectedOutput[j],
						ArrayUtility.RemoveNthFromEnd(_testArrays[i], _expectedReturnType[i]._subtraction)[j]);
				}
			}
		}
	}
}