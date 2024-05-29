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
    - 시맨틱 태그

- CSS3 
    - 웹디자인 핵심

- JavaScript 

