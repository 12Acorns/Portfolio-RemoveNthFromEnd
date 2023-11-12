using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeNthFromEndApp.Utility
{
	public class ArrayUtility
	{
		public static int[] RemoveNthFromEnd(int[] _array, int _indexFromEnd)
		{
			if (_array.Length >= 30) throw new Exception("Array contains too many elements.");
			if (_indexFromEnd == 0) return _array;
			int _indexFromArrayEnd = _array.Length - _indexFromEnd;
			if (_indexFromArrayEnd < 0) throw new IndexOutOfRangeException();
			if(_array == null || _array.Length == 0) throw new NullReferenceException();

			var _arrayNew = new int[_array.Length - 1];
			int _indexOffset = 0;

			for (int i = 0; i < _arrayNew.Length; i++)
			{
				if (_array[i] >= 100) throw new Exception("Value in array is too big.");
				switch (i == _indexFromArrayEnd)
				{
					case true:
						if (i + 1 < _array.Length) 
						{ 
							_arrayNew[i] = _array[i + 1];
							_indexOffset++;
						}
						continue;
					case false:
						_arrayNew[i] = _array[i + _indexOffset];
						break;
				}
			}
			
			return _arrayNew;
		}
	}
}
