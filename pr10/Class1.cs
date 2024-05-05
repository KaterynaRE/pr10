using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl1
{
	public class Alphabet : IEnumerable<char>
	{
		public List<char> alphabets { get; set; }

		public Alphabet()
		{
			alphabets = new List<char>();
			for (char letter = 'A'; letter <= 'Z'; letter++)
			{
				alphabets.Add(letter);
			}
		}

		public void Add(char alphabet)
		{
			alphabets.Add(alphabet);
		}

		public bool Find(char symb)
		{
			return alphabets.Contains(symb);
		}
		public IEnumerator<char> GetEnumerator()
		{
			return alphabets.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
