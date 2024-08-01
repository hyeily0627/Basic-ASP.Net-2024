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
    - 웹 브라우저에서 F12(개발자도구)
    - VS Code 플러그인
        - HTML Code Snippet
        - Live Server

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
        ```
        - <p>가나다라<small></small>아자차카타파하</p> : 글씨작게
        - <p>가나다라<sub></sub>아자차카타파하</p> : 아래첨자
        - <p>가나다라<suf></suf>아자차카타파하</p> : 윗 첨자
        ```
    
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
        - 무료테마(템플릿)이 아주 잘되어 있음 : https://getbootstrap.com/docs/5.3/examples/ 예제 보면서 따라 하기~! 1

- 웹 페이지 클로닝(cloning)
    - 핀터레스트 타입 웹페이지 만들기(진행중~)
    
## 5일차 
- Html + CSS + jsQuery 응용  
    - 웹 페이지 클로닝(cloning)
        - 핀터레스트 타입 + Bootstrap + 웹페이지 만들기 끝!


https://github.com/hyeily0627/Basic-ASP.Net-2024/assets/156732476/fb4f16cd-092f-4e22-bab0-a808495371aa


- https://www.youtube.com/@codehal 로그인창 웹페이지 튜토리얼 따라하기 
    - https://boxicons.com/ 아이콘
    - https://github.com/HoanghoDev?page=2&tab=repositories 유튜브 외 샘플코드 참고 (맞나?)
    
    - custom CSS 의 경우 <style> 빼고 -> css 폴더 안에 css파일로 ->  <link href="./css/main.css" rel="stylesheet"> 형식

![튜토리얼](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/codehal.png)


** 사이즈 조절해서 올리는 방법 
<!-- <img src = "https://github.com/hyeily0627/Basic-ASP.Net-2024/blob/main/images/%ED%8A%9C%ED%86%A0%EB%A6%AC%EC%96%BC.png" width="730" alt="codehal 로그인창 따라하기"> -->


## 6일차(24.06.05)
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼 따라하기 (완료)

        > 참고 영상넣기!!

        - 자동 슬라이드버튼 기능 추가

         > 참고 영상넣기!!
    

## 개인프로젝트(24.06.07)

## 8일차(2024.06.10)
- ASP.NET 
    - 1990년대 
        - MS가 웹 서버 기술로 ASP(Active Server Page)를 배포
        - 이걸 따라 한 것이 JSP(Java Server Page) 
        - ASP는 .NET 형식의 언어가 아니고, VisualBasicScript 를 사용 -> 파일 확장자는 .asp 
        - 스파게티 코드!  -> HTML + CSS + JavaScript + VBscript 의 믹스
            - 프론트엔드 + 백엔드 소스가 모두 한페이지에
            - 다만 현재 프론트엔드도 백엔드 소스가 일부는 포함 
        - 개발은 쉽다는 장점이 있지만, 그 외 유지보수가 어렵고 성능이 떨어지는 단점 
    - 2000년대 초기                      
        - MS가 .NET Framwork를 발표함 
        - C#, C++.NET , VB.NET 등의 새로운 언어를 배포하며, 여기에 맞춰서 웹 서버기술을 다시 만듦 => ASP.NET( 확장자는 .aspx) 
        - 초창기에는 스파게티코드를 거의 그대로 사용하다보니 성능도 낮은 상황...
        - 하지만 장점이 있었는데, Winform 개발 처럼 웹개발이 가능하여 쉽다는 점! 
    - 2009년
        - ASP.MVC 출시(Model View Controllor 디자인 패턴 공표) -> 성능은 향상
        - 하지만, window에서만 동작되는 한계 
    - 2016년
        - 모든 OS 플랫폼에서 동작할 수 있는 .NET Core를 재출시 
        - 여기에 웹 서버기술을 또 다시 만듦 => ASP.NET Core (최종)
    - ASP.NET은 C#이 아닌 다른 .NET 언어로도 개발 가능함 

- .NET Core(현재는 .NET 9.0 버전이고, Core라는 이름은 사용하지 않음)
    - 특징 
        - 빠른 오픈소스 
        - **크로스 플랫폼**으로, OS의 종속을 받지 않아 어디서든 사용 가능 
        - 성능의 극대화 

- ASP.NET Core 
    - ASP.NET Webforms : 2000년대 초반에 나오다가 제한된 웹사이트 개발 기술 
    - JavaScript(Vue, Angular, React) 프론트앤드 + ASP.NET Core 백앤드
    - ASP.NET Core 웹 API - 데이터 포털, 네이버, 카카오 등의 사이트를 만드는 백앤드(프론트앤드가 없어 별도 화면이 없음)
    - ASP.NET Core 웹앱(MVC) - 가장 기본적인 프론트앤드(HTML, CSS, js / .cshtml) + 백엔드(C# / aspx.cs) 웹 개발 
    - Edge용 웹 드라이버 테스트 : 엣지 프라우저에 종속된 테스트용 
    - ASP.NET Core gRPC 서비스 : 고성능 원격 프로시저(스트리밍 호출) 서비스
    - Blazor : js 프론트엔드를 따라서 컴포넌트 기반으로 개발하는 웹개발 방식 웹사이트 개발 
    - Razor - 프론트앤드 개발에 C# 코드가 특화되어 사용되는 웹사이트 개발 방식
    - .NET Asprie : Blazor + Redis + 웹 API 백엔드 

- 참조 사이트 
    - http://github.com/dotnet 
    - https://mixedcode.com/
    - https://github.com/gilbutITbook/006824
    - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1

- ASP.NET Core 웹앱(Model Veiw Controller)
    - 현재 기본적인 웹개발의 가장 표준격 
    - Java 계열도 Spring Boot MVC로 개발 

    ![MVC](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0002.png)

    - 프론트앤드 예전에는 스파게티코드가 많았는데, 현재는 최소화 되어있음(스트링부트, 파이썬, 플라스크 모두 동일!) 

- 참고 
    - ASP.NET core 웹앱(Model-View-Controller 템플릿 시작!!)

    ![ASP.NET core](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0001.png)

    - **파일 저장시 핫다시로드(HotReload) 체크**
    - 실행을 위해서는 콘솔이 닫히면 안됨(콘솔 닫기 ctrl + c) 
    - IIS Express Server - VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버 이름 
    - index.~ : 웹사이트 가장 대문
    - @로 시작하는 c# 구문. Tag helper, HTML helper로 HTML 구문내에 c# 코드를 적어서 활용하는 방법 ->> Razor 구문
    - Action -- HTML에서 form 태그 내에 Submit 버튼 클릭 ! -> 링크를 클릭하는 것, 윈앱에서 이벤트와 동일 
    - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult 라고 함 

- 데이터 베이스 연동방법
    - 1. DB Frist : 가장 전통적인 DB 연동 방식
    DB 설계 -> DB 구축 -> C# 과 연동 
    - **2. Code Frist** : 최근 트렌드 연동 방식 
    C# 엔터티 클래스 작성 -> DB 연결 설정 -> 실행 -> DB에 테이블이 생성됨
    - 2번은 EntityFramework를 사용하여 손쉽게 구축 가능 
    - 설치
        1. Microsoft.EntityFrameworkCore
        2. Microsoft.EntityFrameworkCore.Tools
        3. Microsoft.EntityFrameworkCore.SqlServer (이건 DB 따라서 달라짐/ mysql, oracle 등은 확인 필요)
    - 순서 
        1. Models 폴더 Category 클래스 생성 - 내용삽입
        2. appsettings.json에 DB연결 문자열 추가(서버- 속성 -연결문자열) 
        ** 설명 추가 DB 있는거 연결하고 Category라는 엔티티 추가 하는 과정인데 동일 엔티티 명이 있으면 안됨!   
        ```json
        {
        "Logging": {
            "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
            }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
            "DefaultConnection": "Data Source=localhost;Initial Catalog=EMS;Persist Security Info=True;User ID=sa;Password=mssql_p@ss;Encrypt=False"
            }
        }
        ```
        3. Data/ApplicationDbContext.cs 중간연결 클래스 생성 
        4. Program.cs Services 내에 DBContext 종속성 주입
        5. Nuget 패키지 관리자 > 패키지 관리자 콘솔 실핼
        ```shell
        PM> Add-Migration 마이그레이션명 (여기서는 AddCategoryToDb로 씀)
        Build started...
        Build succeeded.
        To undo this action, use Remove-Migration.
        ...
        PM> Update-Database
        ...
        Done.
        ```
        6. 컨트롤즈 폴더에서 추가 - 컨트롤러 - Entity Framework를 사용하여 뷰가 포함된 Mvc 컨트롤러 - 아래사진같이 설정 

        ![컨트롤러](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0003.png)

    - 혹시! 브라우저 실행시 '연결이 비공개로 설정되어있습니다.' 오류가 뜨는 경우 
        - 브라우저 화면 클릭 > thisisunsafe를 입력 > 새로고침 

## 9일차 (24.07.16) 다시 돌아와땅! 
- ASP.NET Core MVC
    - MVC 리뷰 
        - Model : 개발자가 따로 만듦 
        - View, Controller 폴더는 자동 생성 
        - 웹 브라우저에서 접근할 페이지를 만들려면
            1. Controller 생성
            2. View를 같이 생성할지, 나중에 생성할지 선택(같이 생성하는 것이 편함)
                - 컨트롤러 메서드 이름과 동일한 csHtml 페이지가 생성됨 
            3. Controller에 Model에서 DB와 연결될 내용을 작성
            4. Model내용을 View로 리턴

- ASP.NET Core 개인 포트폴리오 웹사이트 : MyPortfolio

* 참고 https://docs.google.com/document/d/1zLZFC7M5TkDW3kPJuFfunyx7YfAmBFWltptElsjIHDg/edit#heading=h.8a9sxshwch3f

    1. Visual Studio 에서 ASP.NET Core 웹앱(MVC)
    2. 부트스트랩 템플릿 사이트에서 알맞은 템플릿 다운로드 
        - https://startbootstrap.com/
        - https://themes.getbootstrap.com/
        - https://bootstrapmade.com/ 
    3. wwwroot 폴더 밑에 템플릿 html, css, js, 이미지 등 위치 (asset는 폴더 그대로 옮기기)
    4. 템플릿 페이지의 공통적인 부분(header, bottom)은 _layout.cshtml에 위치 
    5. 중간 페이지에서 변경되는 부분은 각 views 밑에 포함
    6. _layout.cshtml 에 공통부분 옮기기
    7. index.cshtml에 index.html에서 공통부분 외 영역 옮기기 
    8. index.cshtml 내용 수정
    9. ResumeController.cs 생성, 뷰를 같이 생성 
        - DB 관련한 설정이 없으면 Model, view를 만들기 어렵다!
        - MVC 컨트롤러 - 비어있음 : .cs 파일
        - Controller.cs 에서 index > 오른쪽 마우스 뷰 추가 
        - Resume, Project, Contact 동일 
    10. Resume 이란 폴더가 View안에 만들어져야함  
        - Resume 안 파일은 Index.cshtml 아래와 같이 화면 구성 
        ```html
        @{
        ViewData["Title"] = "Resume";
        }

        <h3>이력서 뷰 </h3>
        ```
    11. 템플릿 가져와서 넣기  
    12. code first 방식으로 Board 테이블 생성 
         - 설치
        1. Microsoft.EntityFrameworkCore
        2. Microsoft.EntityFrameworkCore.Tools
        3. Microsoft.EntityFrameworkCore.SqlServer (이건 DB 따라서 달라짐/ mysql, oracle 등은 확인 필요)
    13. Models/Board.cs 로 엔티티 클래스 생성
    14. appsettings.json 에 DB 연결문자열 추가
    15. Data/AppDbContext.cs 생성
    16. Program.cs 에 DbContext 종속성 주입
    17. NuGet패키지 관리자 콘솔 > Add-Migration, Update-Database 진행
    18. _layout.cshtml Board 링크 수정
    19. /Controller/BoardController.cs를 생성(모델, 뷰 연결)
        - ![MVC컨트롤러](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0004.png)

- 참고
    - 아이콘 https://www.flaticon.com/
    - ico 변환 https://www.freeconvert.com/
    - 구글폰트 https://fonts.google.com/
    - 부트스트랩 시작하기 https://getbootstrap.kr/docs/5.3/getting-started/introduction/
        - 버전업, 아이콘, 구역 등 

## 10일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfoilo
    1. Board.cs 멤버속성 ModDate로 이름 변경
        - BoardController.cs에서 ModeDate -> ModData로 변경
        - View/Board/*.cshtml ModeData -> ModData로 변경
    2. ASP.NET Core 템플릿으로 만들어주는 CRUD(Insert, Select, Update, Delete)    
    3. 테이블 삭제, 재생성
    4. 게시판 관련된 화면 수정작업
        - Views/board/index.cshtml 게시판 리스트화면 수정
        - Index.cshtml 테이블 틀 변경, 삭제, 수정, 삭제버튼 삭제
        - Models/Board.cs에 테이블 한글이름 추가 DisplayName() 이용

        - Views/Board/Details.cshtml 부트스트랩 적용
        - 수정/ 삭제 등 버큰 디자인 적용
        - Views/board/Create.cshtml 부트스트랩 적용
    5. SSMS에서 Board테이블 Hit, RegDate, ModDate를 NULL허용으로 설정 
    6. 웹사이트 동작 순서 
        1. https://localhost:7165/Board/Create 링크오픈
        2. BoardController -> Create 액션메서드
        3. Submit -> BoardController -> Create 액션메서드 발동
        4. Create 액션메서드 내 로직처리 DB에 데이터 입력 
        5. Models/Board.cs Moa

    7. 페이징!!
    8. 회원가입, 로그인 ...
    9. 관리자모드/페이지

## 11일차 
**주석처리 ctrl + k + C** 

## 11일차(24.07.23)
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
1. EntityFramework로 SQL 사용없이 DB 핸들링
    - DbContext.Add(삽입), Update(수정), Remove(삭제) 기능 존재
    - 위의 명령을 실행 후 DbContext.SaveChangesAsync() 실행해서 실제 DB에 반영
    - ToListAsync(), FirstOrDefaultAsync()는 SELECT로 트랜잭션이 발생X. 그래서 SaveChangesAsync()를 실행X
2. 글 조회수 올리기
3. 게시글 삭제
    - _layout.cshtml의  @await RenderSectionAsync("Scripts", required: false) 이 각 페이지에 필요시 스크립트영역을 만들어써라는 의미
    - AJAX 삭제는 나중에 다시!!!
4. **페이징**
    - 웹사이트에서 가장 중요한 기능 중 하나
    - 한 페이지에 표시할 수 있는 글의 수를 제한
    - 스크롤 페이징, 번호 페이징
    - 번호 페이징
        1. BoardController.cs Index() 액션메서드 내 FromSql()로 변경(비동기 적용 안됨, 비동기 부분 제거)
        2. 페이징용 쿼리 작성

            ```sql
                SELECT *
                  FROM (
                          SELECT ROW_NUMBER() OVER (ORDER BY Id DESC) AS rowNum
                               , Id
                               , Name
                               , UserId
                               , Title
                               , Contents
                               , Hit
                               , RegDate
                               , ModDate
                            FROM Board
                        ) AS base
                  WHERE base.rowNum BETWEEN 1 AND 10 -- 1과 10에 10씩 더하면 다음 페이지를 조회 쿼리
            ```

        3. Index() 내 로직 수정
        4. View/Board/Index.cshtml 화면코드 수정


        https://github.com/user-attachments/assets/05d6adea-5893-42db-86ed-2d3438c9ca9a


5. 검색 
    - FromSqlRaw() 메서드 변경
    - html 링크에 ?page=1&search= 검색어 추가 
6. HTML 에디터
    - Markdown 에디터
    - https://simplemde.com / 따라가서 깃허브 참조해서 코드 삽입 
    - _layout.cshtml에 js, css 링크만 추가
    - 실제 사용페이지에서 특정 js만 실행 
    - create.cshtml, Edit.cshtml을 동일하게 작업 
    - Nuget패키지에서 라이브러리 다운 : Westwind.AspNetCore.Markdown 

    ![HTML 에디터](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0005.png)
 
## 12일차(24.07.24)
7. 삭제로직 수정 
    - BoardController.cs 사용하지 않음 -> BoardRestController.cs 다시 생성(MVC 컨트롤러 비어있음 선택)
            
    ```c#
        // 어노테이션
        [Route("api/[controller]")] // api/BoardRest로 URL을 만들어줌 
        [ApiController]
    ```

    * 어노테이션은 다른 프로그램에게 유용한 정보를 제공하기 위해 사용되는 것으로 주석과 같은 의미를 가진다.
    - 컴파일러에게 문법 에러를 체크하도록 정보를 제공한다.
    - 프로그램을 빌드할 때 코드를 자동으로 생성할 수 있도록 정보를 제공한다.
    - 런타임에 특정 기능을 실행하도록 정보를 제공한다.
    - /Views/Details.cshtml jQuery를 작업(팝업)
    - /Board/Index로 화면 전환 

8. 회원가입, 로그인....
    1. /Models/User.cs 클래스 생성
    2. User클래스와 Board클래스간 관계형성 (virtual)
    3. AppDbContext.cs에 User DBset추가
    4. Add-Migration, Update-Database 실행 -> DB 생성
    5. Program.cs에 로그인 세션 설정
    6. _layout.cshtml 로그인/로그아웃 메뉴 추가
    7. HomeController.cs Login/Logout 액션메서드 작성
    8. Login() 액션메서드 마우스오른쪽 버튼 뷰생성 Login.cshtml
        - Razor 뷰  - 스캐폴딩 사진과 같이 설정  

        ![스캐폴딩](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0006.png)
        
    9. bootstrap 사이트에서 예제 파일 다운로드
    10. sign-in 폴더 내 index.html. sign-in.css Static경로(wwwroot) 복사
    11. Login.cshtml을 위의 파일 참조해서 수정
    12. HomeController.cs 에 Register() 액션메서드 작성
    13. Register.cshtml 회원가입 페이지 생성

## 13일차(24.07.25) 
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
8. 회원가입, 로그인.... 계속
    - 참고 : 사진과 같이 초록색으로 뜨는 글씨는 웹에서 따로 보이지 않는 속성 
    - input 태그의 asp-for는 HTML로 랜더링 된 뒤 id=와 name으로 변환됨 

    ![asp](https://raw.githubusercontent.com/hyeily0627/Basic-ASP.Net-2024/main/images/an0007.png) 

    - Program.cs 로그인 세션에 쿠키이름 공백 절대 안됨
        
    1. Register.cshtml에 asp-for등 C# Razor tag로 변경
    2. HomeController.cs Register Post 메서드 작성
    3. Login.cshtml에 C# Razor tag로 변경
    4. HomeController.cs Login Post 메서드 작성
    5. Logout Get메서드 추가

    https://github.com/user-attachments/assets/9018c506-85db-4223-9e6d-163e7e3b9dfa

- 추가+ 게시판 글 오류 수정
    1. Board.cs 에 있는 Name, UserID를 삭제
    2. BoardController.cs에 있는 Board 클래스와 관련된 변수도 삭제 
    3. View/Board/*.cshtml Name, UserIF를 삭제, 변경
    4. BoardController.cs 게시글 리스트 쿼리 변경 
    5. View/Board/*.cshtml 수정 
    6. BoardController.cs애 create Post 메서드에 사용자데이터 추가 수정 

9. 이력서, 프로젝트, 컨텍트 페이지 구현하기
    1. Project.cs 모델 생성
    2. AppDbContext.cs에 DbSet<Project> 추가
    3. Add-Migration, Update-Database
    4. ProjectController, View 생성
    5. Views/Project/Create.cshtml 수정
    6. ProjectController, Create Post 메서드 수정    

-------------------------------------------------------
## 13일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. AWS 라이트세일로 윈도우서버 인스턴스 만들기
        1. 구글 AWS 라이트세일 검색
        2. AWS 프리티어로 회원가입
        3. AWS 라이트세일로 로그인
        4. 루트 사용자로 로그인
        5. 인스턴스 생성
            - Linux/Unix는 라즈비안과 거의 동일
            - MS Windows OS 전용 > Windows Server 2016 선택
            - 무료 중 가장 성능이 좋은거 선택
            - 인스턴스 확인 이름 변경
            - 인스턴스 생성 클릭
        6. 인스턴스 관리
            - 관리로 진입
            - 네트워킹 탭 > 고정 IP 연결 클릭
            - 자신 고정아이피
            - Administrator
            - 비번 확인
        7. 원격 데스트톱 연결
            - 컴퓨터: 고정아이피 주소
            - Network2 Yes 클릭
            - 서버 매니저 오픈
            - IE Enhanced Security Config. ON->OFF
            - 인터넷 익스플로러 오픈 구글
            - 크롬 브라우저 설치
            - FileZilla Server 검색/ 설치
        8. 파일질라 서버 설정
            - 메뉴 > Configure 클릭
            - Server listners > 0.0.0.0 -> 내부 아이피로 변경
            - FTP and FTP over TLS 
            - Generate New > Disting,../HostName 입력, 새로 생성
            - Passive Mode 사용
                - From : 55000
                - To : 55999
            - User 생성
                - MountPoint
                    - Virtual path : /
                    - Native path : 본인 지정
                - Authentication : Required Password
                - 패스워드 입력 후 Apply
        9. 윈도우 방화벽 설정
            - Control Panel(제어판)
            - Windows Firewall > Advanced Setting
            - Inbound : 21, 55000-55999 열기

        10. AWS 방화벽 설정
            - 네트워킹 IPv4 방화벽
            - 21 포트 규칙추가
            - 55000-55999 포트 규칙추가

        11. 사용PC에서 파일질라 클라이언트 설치
            - 기본 설치
            - 사이트 관리자 
                - 새 사이트만들고
                - 호스트 : AWS pubilc ip
                - 사용자, 비번 : Filezilla server 설정한 사용자 계정
                - 전송설정 수동형 선택

        12. Visual Studio ASP.NET Core 게시
            - 프로젝트 > MRB > 게시 클릭
            - FTP/FTPS 서버 선택 > 다음
            - 서버 : aws public ip
            - 사이트 경로 : /
            - 수동모드
            - 사용자이름 패스워드 입력, 암호저장
            - 연결 유효성 검사 > 녹색체크
            - 게시 하면 됨            

        13. SQL Server 다운로드
            - 윈도우 서버 패스워드 정책 변경
                - 8문자이상 특수문자1자이상 영어대소문자
            - secpol.msc 보안정책
            - 패스워드 정책 변경 enabled -> disabled
            - 설치 후 SQL Config Manager
            - Network configuration
                - TCP/IP enable
            - 서버 재시작
            - 윈도우 방화벽, AWS 방화벽 1433포트 오픈
            - SSMS 접속 확인

        14. IIS(Interner Information Service)
            - ASP, ASP.NET 종류 웹서버 
            - Server Manager 오픈
            - Add Roles and Features 클릭
            - 기본 선택 Next
            - Select Server Roles
                - IIS Server 선택 다음
                - 기본 설치 

        15. SQL Server를 복제
            - SSMS 로컬 DB를 접속
            - 서버 종료
            - EMS.mdf, EMS_log.ldf 복사
            - FTP로 전송

        16. IIS 서버에서 ASP.NET 실행
            - 제어판 열기
            - Administraiton Tools
            - IIS 오픈
            - Default Web > Basic Setting 사이트 경로 변경
                - C:\Websites\MyPorfolio 
            - 폴더 설정 > Secuiry 탭
                - IIS_IUSERS 그룹 설정 추가

            - 구글에서 ASP.NET 코어 런타임 8 검색 다운로드
                - aspnetcore-runtime-8.0.7-win-x64.exe
                - dotnet-hosting-8.0.7-win.exe

            - IIS - Application Pool
                - ASPNETCore 애플리케이션 풀 생성
                - .NET CLR Version > No Managed... 선택
                - IIS 재시작

        17. 다음부터는 
            - Visual Studio 개발
            - Visual Studio 게시
            - DB가 변경되었으면, mdf, ldf를 FTP로 업로드
            - SQL 서버 중지 파일 이동


## 14일차(7.30)
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. 프로젝트 화면 DB연동하기
        - 지난 목요일 만들던 것 확인
        - ProjectController.cs Create() Post 메서드 수정
        - 업로드 확인
        - Edit.cshtml은 Create.cshtml과 동일하게 수정
        - Edit() Post 메서드 역시 동일 -> DB에 프로젝트 내용 추가

        - HomeController.cs Project() Get 메서드에 DB연동 내용 추가
        - Views/Home/Project.cshtml Db연동 내용 추가 -> 프로젝트에 DB내용 표시

    2. 프로젝트 이미지 올리기
        - /Models/Project.cs에 Project 클래스와 파일업로드 중간단게 TempProject 클래스 작성
        - /Controller/ProjectController.cs 수정(IWebHostEnvironment 추가)
        - UploadImageFile() 메서드 추가 작성
        - /Views/Project/Create.cshtml에 @model MyPortfolio.Models.Project 를 @model MyPortfolio.Models.TempProject로 변경
        - 및 나머지 내용 수정
        - /Views/Project/Edit.cshtml에 @model MyPortfolio.Models.Project 를 @model MyPortfolio.Models.TempProject로 변경
        - 및 나머지 내용 수정

        - 실행확인

        <img src="https://raw.githubusercontent.com/hugoMGSung/basic-aspnet-2024/main/images/an0007.png" width="700">

    2. Contact 메일보내기(네이버 연동)
        - (구글)네이버 동일 - 메일계정 2단계보안 설정
        - 네이버메일 환경설정 > POP3/SMTP 설정 사용함 변경
        - 아래 코드를 해당 Post 액션 메서드 대입
        ```cs
        try
        {
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress("보내는 계정 주소", "표시 이름", System.Text.Encoding.UTF8);
            // 받는이 메일 주소
            mailMessage.To.Add("yyy@naver.com");
            // 참조 메일 주소
            mailMessage.CC.Add("zzz@naver.com");
            // 비공개 참조 메일 주소
            mailMessage.Bcc.Add("kkk@naver.com");
            // 제목
            mailMessage.Subject = "메일 제목";
            // 메일 제목 인코딩 타입(UTF-8) 선택
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            // 본문
            mailMessage.Body = "메일 본문";
            // 본문의 포맷에 따라 선택
            mailMessage.IsBodyHtml = false;
            // 본문 인코딩 타입(UTF-8) 선택
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            // 파일 첨부
            mailMessage.Attachments.Add(new Attachment(new FileStream(@"D:\test.zip", FileMode.Open, FileAccess.Read), "test.zip"));
            // SMTP 서버 주소
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            // SMTP 포트
            SmtpServer.Port = 587;
            // SSL 사용 여부
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SmtpServer.Credentials = new System.Net.NetworkCredential("아이디", "패스워드");

            SmtpServer.Send(mailMessage);
        }
        catch (Exception ex)
        {
            // 에러메시지 HTML
        }
        ```

    3. Toastr 사용
        - https://github.com/CodeSeven/toastr 사용
        - _Layout.cshtml에 css CDN 추가
        - Partial View 생성 - 부분뷰로 /Views/Shared/_Notification.cshtml 생성
        - 아래와 같이 작성

        ```cs
        @if (TempData["success"] != null) {
            <script src="~/lib/jquery/dist/jquery.min.js"></script>
            <script src="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"></script>
            <script type="text/javascript">
                // toastr.success('Have fun storming the castle!', 'Miracle Max Says')
                toastr.success('@TempData["success"]');
            </script>
        }

            @if (TempData["error"] != null) {
            <script src="~/lib/jquery/dist/jquery.min.js"></script>
            <script src="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"></script>
            <script type="text/javascript">
                // toastr.error('I do not think that word means what you think it means.', 'Inconceivable!')
                toastr.error('@TempData["error"]');
            </script>
            <h3>@TempData["error"]</h3>
        }
        ```

        - /Views/Board/Index.cshtml에 아래의 코드 추가
        ```html
            var num = ViewBag.TotalCount - ((page - 1) * 10); // 전체 게시글 수를 (현재페이지-1)값과 페이지당 게시글수 곱을 빼기
        }

        <partial name="_Notification" />
        ```

        - /BoardController.cs Create() Post 메서드에 아래의 코드 추가
        ```cs
        await _context.SaveChangesAsync();
        // 이 부분 추가
        TempData["success"] = "성공적으로 저장했습니다.";
        ```

        - 실행결과

        <img src="https://raw.githubusercontent.com/hugoMGSung/basic-aspnet-2024/main/images/an0008.png" width="700">

    3. 부트스트랩 템플릿 커스터마이징, 자기 포트폴리오 사이트 만들기
        - 구글에서 부트스트랩 템플릿 검색
            - https://bootstraptaste.com/
            - https://startbootstrap.com/
            - https://themewagon.com/themes/
            - https://getbootstrap.com/docs/5.0/examples/
