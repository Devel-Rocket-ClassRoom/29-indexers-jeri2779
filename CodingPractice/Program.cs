using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
Console.WriteLine("## 과제 1: 기본 인덱서 예제");
Catalog catalog = new Catalog();
Console.WriteLine(catalog[0]); // 개체명[인덱스] 형태로 호출
Console.WriteLine(catalog[1]);
Console.WriteLine(catalog[2]);

Console.WriteLine("## 과제 2: 배열 필드를 감싸는 인덱서");
Car car = new Car(3);

// 인덱서를 통해 배열처럼 값 저장
car[0] = "CLA";
car[1] = "CLS";
car[2] = "AMG";

// for 문으로 순회하며 출력
for (int i = 0; i < car.Length; i++)
{
    Console.WriteLine(car[i]);
}

Console.WriteLine("## 과제 3: 요일 클래스 예제");

Week week = new Week(3);

week[0] = "일요일";
week[1] = "월요일";
week[2] = "화요일";

for (int i = 0; i < week.Length; i++)
{
    Console.WriteLine(week[i]);
}

Console.WriteLine("## 과제 4: 문자열 인덱서");


var nick = new NickName();

// 문자열 인덱서 사용: Key와 Value 형태로 저장
nick["홍길동"] = "RedPlus";
nick["김철수"] = "BlueStar";

// 문자열 인덱서로 값 출력
Console.WriteLine($"{nick["홍길동"]}, {nick["김철수"]}");


Console.WriteLine("## 과제 5: 다중 인덱서");

MultiIndexer multi = new MultiIndexer();

// 정수 인덱서 사용
multi[0] = "첫 번째 값";

// 문자열 인덱서 사용
multi["name"] = "홍길동";
multi["city"] = "서울";

Console.WriteLine($"multi[0] = {multi[0]}");
Console.WriteLine($"multi[\"name\"] = {multi["name"]}");
Console.WriteLine($"multi[\"city\"] = {multi["city"]}");

Console.WriteLine("## 과제 6: 인덱서와 속성의 비교");
Example ex = new Example();

// 속성 사용
ex.Name = "홍길동";
Console.WriteLine(ex.Name);

// 인덱서 사용
ex[0] = "첫 번째";
ex[1] = "두 번째";
Console.WriteLine($"{ex[0]}, {ex[1]}");

