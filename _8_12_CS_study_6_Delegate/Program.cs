using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_6_Delegate
{
	// Delegate (대리자)
	internal class Program
	{
		delegate int OnClicked();   //매개변수가 없으며, return타입이 int인 함수만 등록할수있다.
		/*	delegate 정의 : 접근한정자 delegate 자료형 delegate이름	*/
		static void ButtonPressed(OnClicked clickedFunction) //인자에는 함수가 들어간다.
		{
			clickedFunction();	//함수호출
		}
		static int TestDelegate()	//예시함수1
		{
			Console.WriteLine("Hello, Delegate");
			return 0;
		}
		static int TestDelegate2()	//예시함수2
		{
			Console.WriteLine("Hello, Delegate 2");
			return 0;
		}
		static void Main(string[] args)
		{
			OnClicked clicked = new OnClicked(TestDelegate);	//delegate형 객체 생성, TestDelegate함수등록
			/*	OnClicked clicked = Test; 로 써도 컴파일러가 new를 생성해줌	*/
			
			clicked();	//함수를 대리로 순차적으로 실행한다.

			clicked += TestDelegate2;   //delegate형 객체에 TestDelegate2 함수를 추가등록
			/*	+,+=,-,-= 연산자 사용가능, -,-= 연산자로 해당함수를 뺄수있다.	*/

			ButtonPressed(clicked);	//함수에 대리자를 넘겨 함수에서 실행시킨다.

		}
	}
}
