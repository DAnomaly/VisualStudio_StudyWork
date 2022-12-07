# VisualStudio_StudyWork
github 주소: https://github.com/DAnomaly/VisualStudio_StudyWork

## ProjectName: 02-photoviewer
1. 기본적인 Dialog 사용법
2. openFileDialog 사용법
3. colorDialog 사용법
4. 프로그램 종료(close())

## ProjectName: 03-mathquiz
1. Timer 사용법
2. 여러개의 버튼의 이벤트를 하나로 물리는 법
   2-1. as 사용
   2-2. equals 사용
3. Color 클래스와 SystemColor 클래스
4. MessageBox.Show(내용,제목);
5. Random 클래스

## ProjectName: 04-matchgame
1. Webdings 폰트
2. TableLayoutPanel - SellBorderStyle
3. Layout안에 있는 모든 Controls(Label) 가져오는 법

## ProjectName: 05-DemoCalculator
1. Decimal 클래스
2. StringBuilder 클래스

## ProjectName: 06-WebSocketConnection
1. 웹소켓 연결

## ProjectName: 07-SetTimeGenerateFile
1. 지정된시간 파일생성 프로그램
2. 프로젝트 내부 README파일 참조

## ProjectName: 08-SetTimeGenerateFile2
### ProjectName: 08-SetTimeGenerateFile2
1. 07번 프로젝트 단점 보안 프로젝트
2. Front프로그램 컴파일시 `08-SetTimeGenerateFile2-back`프로그램과 같이 컴파일됨
3. Windows Form에서 파일등록을 예약하는 기능
4. 예약목록은 `./Data/`폴더에 `.xml`파일로 저장됨
5. 해당 프로그램 실행시 `08-SetTimeGenerateFile2-back`프로그램과 같이 시작함
### ProjectName: 08-SetTimeGenerateFile2_back
1. `08-SetTimeGenerateFile2`의 백그라운드에서 실행될 프로그램
2. 예약목록 파일의 지정된 시간이 되면 `Config.ini`에 지정한 경로에 파일을 생성함
3. `08-SetTimeGenerateFile2_back.exe` 시작프로그램으로 등록하여 상시 동작하도록 조치 ([사이트](https://badayak.com/entry/%EC%9C%88%EB%8F%84%EC%9A%B010-%EC%8B%9C%EC%9E%91-%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8-%EB%93%B1%EB%A1%9D-%EB%B0%A9%EB%B2%95-%EB%91%90%EA%B0%80%EC%A7%80))
4. 해당 프로그램이 중복으로 실행되지 않게 조치(동일한 프로그램 발견시, 바로 종료)