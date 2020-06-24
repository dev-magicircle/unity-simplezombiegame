# unity3d following zombie 가상현실콘텐츠 중간과제
simple unity3d game

###	내용
플레이어는 밖이 보이지 않는 오두막 안에 갇힌 채로 게임을 시작한다. 미로를 탈출하라는 미션을 받고 오두막의 미로를 탈출해야 하는데, 계속해서 어디선가 좀비들이 등장한다. (제작자의 이름을 이스터에그로 확인할 수 있습니다.)
###	시점
1인칭 시점
###	사용한 free asset: 
 ![asset2](https://user-images.githubusercontent.com/62414035/84532278-ed4c9800-ad20-11ea-8020-39c00374c9ed.png)
### C#스크립트(3개): PlayerController, EnemyAI, ShowUI
##### (1)	PlayerController
기능: 1인칭 시점에서 플레이어 움직임 조정, WASD키로 움직이기 가능, 마우스로 보는 방향 다르게 하기, shift키로 빠르게 달리기 등
위치: Player
참고자료: https://edu.goorm.io/learn/lecture/5026/3d-unity-%EC%83%9D%EC%A1%B4%EA%B2%8C%EC%9E%84-%EB%A7%8C%EB%93%A4%EA%B8%B0-basic/
##### (2)	EnemyAI
![enemyai](https://user-images.githubusercontent.com/62414035/84532363-1836ec00-ad21-11ea-9f75-861c157d7bcb.png)
기능: 좀비(enemy)가 플레이어를 쫓아오도록 설정
위치: Zombie
참고자료: #1 Unity 3D Simple Enemy Follow AI Script for NavMeshAgent Getting Started for Enemy AI or Behaviour
##### (3)	ShowUI
![showui2](https://user-images.githubusercontent.com/62414035/84532387-2127bd80-ad21-11ea-82f2-894b3eef35e8.png)
![showui](https://user-images.githubusercontent.com/62414035/84532380-1f5dfa00-ad21-11ea-9366-6653e5e1e5d9.png)
기능: 특정 위치에 도달하면 UI에 text를 띄운다.
위치: ArriveLine, LookingLine, StartLine
참고자료: Unity 5 - Showing Text on Trigger

##### (4)	그 외 참고자료
How to play background music in Unity
https://www.youtube.com/watch?v=pScJJIuyxyo

#####	힘들었던 부분 & 해결 방법
-	좀비가 플레이어를 따라오게 만들어야 하는데, 계속 다른 곳으로 이동
아래 지면을 bash설정을 해줘야 하고, bash가 안 된 부분에 오브젝트 배치하면 안 됨.
-	특정 위치에 다가가면 UI에 text가 나오는 걸 만들고 싶었는데, 계속해서 text가 나오지 않았음. 그래서 debug.log로 함수가 실행이 되는지 확인했는데, console창에 아무 것도 찍히지 않았음. 
Cube창의 box Collider의 isTrigger를 활성화시킴.

##### 추가하고 싶은 부분: 
-	좀비가 벽을 그대로 뚫고 들어오는데, 벽을 통과하지 못하게 만들어야 함.
-	좀비 반경 이내로 플레이어가 들어와야 움직이게끔 설정했음 좋을 것 같음
-	좀비가 다가오면 체력이 감소됨
