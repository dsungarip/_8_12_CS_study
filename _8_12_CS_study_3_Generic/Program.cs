using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_3_Generic
{
	internal class Program
	{
		// 일반화, 
		public class MyList<T>          //제네릭 클래스
		{
			T[] arr = new T[10];

			public T GetItem(int i)
			{
				return arr[i];
			}
		}
		class Monster
		{

		}

		static void Test<T>(T input)
		{

		}
		static void Main(string[] args)
		{
			//var obj3 = 3;					// == int obj3로 인식함
			//var obj4 = "hello world";		// == string obj4로 인식함

			////	모든 자료형을 object로 할경우 속도가 느림
			////	int 로 사용하면 스택에 들어가지만, object는 힙에 들어감(박싱, boxing).
			////	꺼낼때는 힙에서 나와 다시 스택으로 들어가기 때문에 느리다(언박싱 , unboxing).

			//object obj = 3;					//
			//object obj2 = "Hello World";

			//int num = (int)obj;				//꺼내올때는 (형변환)을 해줘야 한다.
			//string str = (string)obj2;

			MyList<int> myintList = new MyList<int>();
			int item = myintList.GetItem(0);

			MyList<short> myshortList = new MyList<short>();
			MyList<Monster> mymonsterList = new MyList<Monster>();

			Test<int>(3);
			Test<float>(3.0f);

		}
	}
}
