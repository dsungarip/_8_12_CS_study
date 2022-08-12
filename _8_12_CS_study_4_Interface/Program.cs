using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_4_Interface
{
	internal class Program
	{
		abstract class Monster				//abstract를 추가하면 몬스터는 추상클래스 가 된다.
		{
			public abstract void Shout();	//Shout은 추상클래스로 정의가 되어서는 안되며,
		}									//Monster를 상속받는 모든 클래스는 Shout을 선언해야함.
		interface IFlyable		//상속받을경우 Fly 인터페이스 함수를 제공해야하지만,
		{						//Fly를 어떻게 구현해야 하는지는 알려주지 않는다.
			void Fly();			//접근지정자 안붙인다. abstract도 안붙인다.
		}
		class Orc : Monster
		{
			public override void Shout() 
			{
				Console.WriteLine("록타르 오가르!");
			}	
		}
		class FlyableOrc : Orc, IFlyable	//여러개의 인터페이스를 가지고있어도 문제가 없다.(부모는 안됨)
		{
			public void Fly()		//접근지정자를 붙여 Fly를 구현한다.
			{

			}
		}
		class Skeleton : Monster		//Monster를 상속받았으면 클래스 안의 Shout도 무조건 선언해야한다.
		{
			public override void Shout()
			{
				Console.WriteLine("키에에엑!");
			}
		}
		static void DoFly(IFlyable flyable)	//IFlyable 인터페이스를 내포해야만 매개변수로 사용가능
		{
			flyable.Fly();	//IFlyable 인터페이스를 내포하기에 Fly함수 호출가능.
		}

		static void Main(string[] args)
		{
			//Monster monster = new Monster();	//추상 클래스타입의 객채는 만들수 없음.

			FlyableOrc orc = new FlyableOrc();    //인터페이스로 선언된 변수에 저장가능
			DoFly(orc);	//IFlyable 인터페이스를 참조했기에 매개변수로 호출가능.

		}
	}
}
