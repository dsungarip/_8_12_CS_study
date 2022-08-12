using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_1_list
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[1000];

			//	List <- 동적배열
			//	시간복잡도, 알고리즘 측면에서 효율적이지 못함.
			
			List<int> list = new List<int>();


			for(int i=0;i<5;i++)		//배열의 끝에 새로운 배열 생성list[0] -> list[5]
				list.Add(i);

			//	삽입, 삭제

			//list.Insert(2, 999);	//2번째 배열에 999삽입(기존데이터는 뒤로 밀려남)

			//bool success = list.Remove(3);      //입력된 특정 값을 발견하면 그 배열을 삭제,
			//									//맨 처음발견된 배열만 삭제

			list.RemoveAt(0);       //RemoveAt(n) = n번째 배열을 삭제
			list.Clear();		//list배열의 모든 배열 삭제




			for (int i = 0; i<list.Count; i++)     //list.Count == list배열길이 측정  
				Console.WriteLine(list[i]); //list 배열 출력

			foreach(int num in list)
				Console.WriteLine(num);

			list[0] = 1;
		}
	}
}
