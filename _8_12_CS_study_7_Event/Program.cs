using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_CS_study_7_Event
{	/*	Event를 쓰는 이유 : 상관없는 외부에서의 delegate 실행을 막기위해	*/
	internal class Program
	{
		/*	Delegate를 rapping하는 Event	*/
		/*	event가 정의된 클래스가 아니기에, event 호출 불가	*/
		static void OnInputTest()
		{
			Console.WriteLine("Input Received!");
		}
	
		static void Main(string[] args)
		{
			InputManager inputManager = new InputManager();	//InputManager타입 객체 생성,객체는 이를 참조

			inputManager.InputKey += OnInputTest;		//event에 OnInputTest함수 등록
			// inputManager.InputKey(); <- 컴파일에러


			while (true)
			{
				inputManager.Update();	//inputManager의 Update함수 실행
			}
		}
	}

}
