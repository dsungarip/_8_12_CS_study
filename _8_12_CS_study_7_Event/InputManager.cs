using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	/*	event는 delegate랑 다르게 event가 정의된 클래스 안에서만 이벤트 호출이 가능하다.	*/
	/*	event가 정의되지않은 클래스에서는 event에 함수등록만 해놓을수 있다.	*/

namespace _8_12_CS_study_7_Event
{
	/*	Observer Pattern : 특정이벤트가 발생했을때 대상자들에게 메세지를 전달한다.	*/

	/*	InputManager의 역할	*/
	/*	사용자의 입력을 캐치해 게임로직(프로그램)에 전달하는 매개클래스	*/
	class InputManager
	{
		/*	delegate와 event의 접근한정자는 동일해야 한다.	*/

		public delegate void OnInputKey();  //	매개변수&return이 없는 함수만 등록가능
		public event OnInputKey InputKey;   //	event의 타입 정의(OnInputKey)
		
		/*	event 정의 : 접근한정자 event delegate이름 event이름	*/
		public void Update()
		{
			if (Console.KeyAvailable==false)	//	사용자의 입력을 받는다. 입력이 없을경우 false
				return;

			ConsoleKeyInfo info = Console.ReadKey();	//	입력이 있을경우 입력된 값을 info에 저장
			if(info.Key == ConsoleKey.A)	//	입력이 'A'일 경우 문장을 실행한다.
			{
				InputKey(); //	Program class에서 OnInputTest 함수를 실행시킨다.
			}
		}
	}
}