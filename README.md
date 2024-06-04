# Basic-ASP.Net-2024
부경대학교 2024 IoT 개발자 과정 - ASP.Net 학습 리포지토리

## 1일차
- 웹 기술 개요
    - World Wide Web (W3C) 은 인터넷의 한 파트이다(인터넷 자체는 아님)
    - Full-Stack
        1. Front-end : 웹사이트 화면으로 사람들에게 보이는 부분 컨트롤기술 
        2. Back-end : 웹사이트 뒤에서 동작하는 서버 컨트롤기술
        3. Server-Operation : HW, OS, SW 등 운영(클라우드 이용) 

- 업무용 웹사이트 참고 : https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end 
    - HTML5 : 멀티미디어, 그래픽, 통신기능, 장치 접근, 오프라인 및 저장소, 시맨틱, CSS3 
    데스크톱 앱 생성 ... 
    - CSS : **디자인쪽 공부하고 싶으면 이거 공부**
    - Java Script 

- Back-end 
    1. Java : Spring, Spring Boot, JSP...
    2. C# : ASP.net 
    3. Python : Django, fastAPI, Flask... 
    4. Ruby : Ruby on rails 
    5. C : cgi, fasCGI...
    6. JavaScript : Node.js, Express...
    7. PHP 

- 개발이란..! 
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB 

- HTML5(Hyper Text Markup Language)
    - XML(eXtensible Markup Language)이 웹페이지를 구성하기 위한 선행기술 -> 복잡해서 간략화 시킨게 HTML 
    - 확장자 : .html (.htm 도 있지만 .html로 통합)
    - VS code
        - Angular 8 and TypeScript/HTML VS CODE 설치 후 ctrl space 하면 html sample 하면 틀이 뜸
        - Live Server을 vscode에서 설치하면 실행시 바로 페이지 실행(오른쪽 버튼 Show live Server 실행)
        - 주석 <!-- -->

- 기본요소 
    - 요소 : HTML 페이지를 구성하는 각 부품(제목, 본문, 이미지 등)
        - h1 ~ h6 : 제목
        - p : 일반 문장
            - <p>Lorem</p> : 긴 샘플텍스트 생성 * (Lorem숫자) 숫자만큼 글 들어감 
            - 🚨<br> : break로 한줄 내리기(Enter)
            - 만약 <> 를 글로 출력하려면 &lt; &gt;, & = &amp; 스페이스 = &nbsp;(스페이스 여러개 들어가야할때) 등등 너무 많음!
            - <p><b>Hyejin</p></b> : Hyejin 글자가 볼드체로 표시 (<strong>Hyejin</strong>도 동일)
            - <p><em>Hyejin</p></em> : Hyejin 글자가 이탤릭체로 표시
            - <mark> </mark> : 형광펜 표시 
            - <u> </u> : 언더라인
            - <strike> </strike> : 취소선
        - div : 그룹화 구분자 
        - image : 이미지 표현
        -  <hr> : 가로선
        - <p>가나다라<small></small>아자차카타파하</p> : 글씨작게
        - <p>가나다라<sub></sub>아자차카타파하</p> : 아래첨자
        - <p>가나다라<suf></suf>아자차카타파하</p> : 윗 첨자
    
    - 태그 : 요소를 만들때 사용하는 작성 방법 
        - 내용을 가질 수 있는 요소 : <요소이름>내용</요소이름>
        - 내용을 가질 수 없는 요소 : <요소이름>
            ``` html
            <html>
                <head>
                    <!-- xml, html 공통 주석-->
                    <!-- head는 화면에 절대 안나타남. html 화면을 구성할 설정이 들어가는 부분-->
                </head>
                <body>
                    <!-- 웹 브라우저에 나타나는 화면 -->
                </body>
            </html>
            ```
        - <a href="https://www.naver.com"></a> : A 태그 - 하이퍼링크
            - <a href="https://www.naver.com" target="_blank"></a> : 타겟 - 새창으로 띄우기
            - <a href="https://www.naver.com" target="_self"> 네이버</a> : 타겟 - 현재페이지로 띄우기 
        - <ul><li>텍스트</li><li>텍스트2</li></ul> : 순번 없는 목록 (-)
        - <ol><li>텍스트</li><li>텍스트2</li></ol> : 순번 있는 목록 (1.2...)
        - table tr(행) th(제목컬럼) td(일반컬럼) : 테이블 만드는 태그 
            * colspan / Rowspan 쓸 때 컬럼 갯수 잘 맞추기 
            ```html
            <table border="1">
                <tr> 
                    <th>1번셀</th>
                    <th>2번셀</th>
                    <th>3번셀</th>
                    <th>4번셀</th>
                </tr>
                <tr>
                    <td>10</td>
                    <td>20</td>
                    <td colspan="2">30</td> 
                </tr>
                <tr>
                    <td>40</td>
                    <td>50</td>
                    <td>60</td>
                    <td rowspan="2">70</td>
                </tr>
                <tr>
                    <td>40</td>
                    <td>50</td>
                    <td>60</td>
                </tr>
            </table>
            ```
        - <audio controls><source file = "file_example_MP3_700KB.mp3"></audio> : 오디오 추가 
        - <video controls><source  src = "광안리.mp4"></audio> : 비디오 추가 
        - <object type="application/pdf" data="E to I 3 발표자료.pdf"> : 개체추가
        - <embed></embed> : 개체추가 
            ** embed 는 object 밑에 들어가면 안나오는 오류 있음
            
- 양식 태그 (body >form 안에 사용 필수)
    - front-end 입력한 내용이 Back-end로 보내는 관문
    - form을 반드시 사용
    - input 
        - type = "text"
        - type = "button"
        - type = "password" : 비밀번호 박스
        - type = "submit" : 제출
            - **진짜중요**submit 클릭시는 loopback이 발생( 새로고침이 아니라 값을 전달)
        - 값 전달 방법
            - GET : URL 뒤 ? 다음에 key=value&key=value... 데이터 전달
            - POST : 화면 뒤로 숨겨서 데이터 전달 방식 

        - type = "checkbox"
        - type = "radio"
        - type = "file" : 파일 업로드 
        - type = "image"
        - type = "reset" : 폼 내의 입력 양식 태그 값 초기화 
        - type = "hidden" : 숨김값 (유용하게 사용) - 화면 운용상 필요하지만 일반인들은 몰라도 되는 키 값들
        
    - textarea : 여러행의 텍스트 입력 
    - select : 콤보박스
    - fieldset : 그룹박스

- 공간구성 태그
    - div : 블록 형식으로 공간 분할
    - span : 

- HTML 스타일
    - <style> 사이에 주석은 /* */ </style>    
    - 내부 스타일, 외부스타일, 인라인 스타일
    
- 스크립트 
    - 내부 스크립트, 외부스크립트, 인라인 스크립트 

- 오류, 디버그
    - F12 개발자 도구로 활용
    
## 2일차
- HTML5 
    - 시맨틱 웹 : 특정 태그에 의미를 부여한 웹, 프로그램이 코드를 읽고 의미를 인식할 수 있는 지능형 웹
    - 시맨틱 태그

    ![시맨틱](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/tag.png)

    - 시맨틱 태그를 div로 바꿔도 똑같이 동작하기 때문에 요즘은 많이 사용하지 않음

- 참고❗: 한줄로 코드 써야 메모리 절약(스페이스 하나당 1byte)

- CSS3 (Cascading Style Sheet)
    - 웹디자인 핵심
    - 상단에서부터(<body>)부터 하위 태그들에 대해 계속 적용되는 스타일
    - 선택자 : 선택자에게 주어지는 디자인 속성
        -  선택자 { 키:값; 키:값; 키:값; } => h1 { color : red ; } 

    ![선택자](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/선택자.png)

    ![선택자종류](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/선택자종류.png)   

    ![박스속성](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/박스속성.png)   
    
    - 속성(property)
    - 배경, 폰트 ...
    - 레이아웃
        - HTML 만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, 원트루, 고정바...
    - 반응형 웹(Responsive Web)
        - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨!!
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'>
        ```
        - @media 태그 : 디바이스 종류별로 CSS 따로 디자인가능

## 3일차
- JavaScript
    - 스크립트 언어, ECMA Script
    - 웹 브라우저 주로 사용
    - 바닐라 스크립트 : 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js : 자바스크립트로 백엔드를 구현(파이썬과 유사) 
    => 프론트엔드를 위해 구성되었으나 더 넘어서서 백엔드까지 영역 확장
    - 특징
        - 자료형 선언이 없음. var 변수 선언 
        - 인터프리터 언어(not compile language)
        - 확장자 .js
        - 속도가 컴파일 언어에 비해서 느림 
        - VS Code도 자바스크립트로 만든 앱
        - 문장 끝 ;은 생략가능하지만 되도록이면 사용할 것! 
        - 정수와 실수를 구분하지 않음 
        - 파이썬과 동일하게 ' " 모두 사용 
        - 완전히 동일함을 비교하는 === 연산자
        - 변수 선언시 let(일반), var(지역변수), const(상수) 

    - 문서객체 : 태그를 자바스크립트에서 사용할 수 있는 객체로 만든 것 
        - '문서 객체를 조작' = 태그를 조작한다는 말! 
        - '문서 객체를 선택 한다' = 이미 존재하는 HTML 태그를 자바스크립트에서 문서 객체로 변환 하는 것 

        ![객체선택메서드](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/객체선택메서드.png)

    - DOM(Document Object Model) 
        - Html에 있는 모든 요소를 제어할 수 있음 
        - Html 애니메이션, 게임, 통신 모두 가능 
        - 이벤트 on- 으로 시작 
            - onload : 화면이 다 랜더링 되면 그 다음 발생 
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생 
            - ondbclick : 더블 클릭
            - onmousemove : 마우스를 이동하면 발생
            - onmouseover : 객체위에 마우스가 올라가면 발생 
            - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생 ... 
    
    - jQuery 
        - 자바스크립트 라이브러리 https://jquery.com/ 
        - 파일 다운로드 하지 않고 CDN 호스트 사용 
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
        - js를 편하게 사용할 수 있도록 하는 서포트 라이브러리
        - 사용빈도가 줄고 있지만, 아직도 80% 비중으로 웹사이트들이 사용

        ![jquery](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/jquery.png)
    
        ```html
            <script>
                $(document).ready(function(){
                    
                });
            </script>
        ```
        
## 4일차
- Html + CSS + jsQuery 응용 
    - jQuery 응용  
    - javascript와 jQuery를 혼용해도 상관없음
    - 각각 편할때가 따로 있기 때문! 
- Bootstrap5 : 소스참고 https://getbootstrap.com/docs/5.3/components/buttons/
    - 오픈소스 CSS 프레임 워크
    - 트위터 블루프린트 -> 부트스트랩 
    - 현재 전 세계에서 가장 각광받고 있는 프레임 워크 중 하나 
    - CSS를 동작시키기 위해서 javascript도 포함
    - 소스 다운로드(1) - 제한된 네트워크, CDN으로 링크사용(2)-인터넷에 항상 
    연결된 환경  
    - 핵심❗
        - Bootstrap5은 화면 사이즈를 12등분 
        - container 밑에 table 처럼 div를 구분해서 사용 
        ```html
        <div class="container text-center">
            <div class="row">
                <div class="col">
                Column
                </div>
                <div class="col">
                Column
                </div>
                <div class="col">
                Column
                </div>
            </div>
            </div>
        ```
        - 부트스트랩 학습에 시간을 들이는 것이 아님! copyleft가 정석 
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/
            - https://getbootstrap.com/docs/5.3/examples/ 
        - 무료테마(템플릿)이 아주 잘되어 있음 : https://getbootstrap.com/docs/5.3/examples/

- 웹 페이지 클로닝(cloning)
    - 핀터레스트 타입 웹페이지 만들기(진행중~)
    
## 5일차 
- Html + CSS + jsQuery 응용  
    - 웹 페이지 클로닝(cloning)
        - 핀터레스트 타입 + Bootstrap + 웹페이지 만들기 끝!


https://github.com/hyeily0627/Basic-ASP.Net-2024/assets/156732476/fb4f16cd-092f-4e22-bab0-a808495371aa

