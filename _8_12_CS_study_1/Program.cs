using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_2_Dictionary
{
	class Monster
	{
		public int id;
		public Monster(int id) { this.id = id ; }
		
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();

			// Dictionary = Hashtable 기법사용
			// 아주 큰 박스안에 1만개의 공이있고 공마다 번호가 기입되어있음
			// 박스 여러개를 쪼개 놓는다. [1~10] [11~20] [...] [...] [...] 1천개로
			// 7777공을 찾아야한다면 777번째 상자를 찾으면 쉽게 찾을수 있음.
			// 속도는 빠르지만 메모리는 손해,
			// [메모리를 내주고, 성능을 취한다]



			// 100만 마리 몬스터
			// 103번 몬스터를 찾는방법?

			//Key -> Value
			// Dictionary

			Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

			for(int i = 0; i<10000; i++)			//몬스터 10000마리 추가
			{
				dic.Add(i, new Monster(i));
			}

			Monster mon;		//몬스터 정보
			bool found = dic.TryGetValue(7777, out mon);    //(찾고자하는 몬스터, 있을경우 몬스터값 반환)

			dic.Remove(7777);
			dic.Clear();


			//dic.Add(1, new Monster(1));

			//dic[5] = new Monster(5);
		}
	}
}
