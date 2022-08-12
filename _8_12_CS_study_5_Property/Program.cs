using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_5_Property
{
	internal class Program
	{
		//	객체지향의 은닉성 (불필요한 정보를 외부로 노출하지 않겠다.)
		//	Property(프로퍼티)
		//	Geter, Get함수
		//	public int GetHp() { return hp; }
		//	Seter, Set함수
		//	public void SetHp(int hp) { this.hp = hp; }

		class Knight
		{
			//protected int hp;
			//
			//public int Hp				//	프로퍼티의 정의
			//{							//	value == 넣으려는 새로운 값
			//	get { return hp; }		//	hp값을 가져오려 할때 자동으로 get{return hp;}가 호출.
			//	set { hp = value; }		//	hp값을 넣으려 할때 자동으로 set{hp=value;}가 호출.
			//}

			/**************************************************************************************/

			//protected int hp = 100;		//	값을 수정하지 않으려면 초기값을 넣어주고 set을 뺀다.
			//public int Hp
			//{
			//	get { return hp; }			//	 hp의 값이 변경되지 않아야 할때 set을 뺀다.
			//}

			/**************************************************************************************/

			//protected int hp;
			//public int Hp
			//{
			//	get { return hp; }
			//	private set { hp = value; }		//	private,protected 등을 붙이면 내부에서만 사용가능
			//}

			/**************************************************************************************/

			public int Hp { get; set; } = 100;	//여기서 바로 초기화도 가능
			//	private int _hp;
			//	public int GetHp(){return _hp;}
			//	public void SetHp(int value){_hp = value;}
			//	{get; set;}은 위와 유사함

			//	c++ Java 필드는 private, protected로 선언후 접근가능한 public함수를 열어주는 방식이 대부분
			//	c#은 이를 개선해 편리하게 프로퍼티를 만들 수 있게 함.
			//	프로퍼티는 함수지만, 사용할때는 public 변수를 접근해 고치는것 처럼 간편히 사용가능

		}
		static void Main(string[] args)
		{
			Knight knight = new Knight();

			//knight.Hp = 100;		//set을 빼면 hp값 대입이 불가하다.

			knight.Hp = 200;
			int hp = knight.Hp;

		}
	}
}
