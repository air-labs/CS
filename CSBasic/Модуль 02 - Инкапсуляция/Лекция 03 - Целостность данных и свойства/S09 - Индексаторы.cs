using System.Collections.Generic;
using System;
namespace S09
{
    public class MyString
    {
        char[] buffer;

        
        public MyString(int capacity)
        {
            buffer = new char[capacity];
            length = 0;
        }

        int length;
        public int Length { get { return length; } }

        public char this[int index]
        {
            get
            {
                return buffer[index];
            }
            set
            {
                if (index >= buffer.Length) throw new ArgumentException();
                buffer[index] = value;
                length = Math.Max(length, index + 1);
            }
        }

        public override string ToString()
        {
            return new string(buffer,0,length);
        }

    }
	
	class Program
	{
		public static void Main()
		{
            var str = new MyString(100);
            str[0] = 'A';
            str[1] = 'B';
            Console.WriteLine(str.ToString());
		}
	}
}
