# MazeGeneratorC#
Maze Generator created in C# for Unity 3D games<br>
<br>
<img width="752" height="485" alt="image" src="https://github.com/user-attachments/assets/51eb2cff-0d1b-4d5c-9e09-67a532984d55" />
<img width="399" height="371" alt="image" src="https://github.com/user-attachments/assets/a02afd8a-4200-460c-b8b9-8583f9724577" /><br>
<br>
<br>
# Setup
<img width="390" height="193" alt="image" src="https://github.com/user-attachments/assets/fb0b2175-fd21-4e16-80b2-09f9e6da0c5f" /><br>
<br>
Create a empty named MazeCell<br>
<br>
<img width="682" height="228" alt="image" src="https://github.com/user-attachments/assets/b2ca8c6d-1aaf-4793-b498-6fb0edf122a0" />
<br>
Then Create Cubes named Floor, LeftWall, RightWall, FrontWall, BackWall, UnvisitedBlock all under ( as child of MazeCell Empty Game Object )---MazeCell<br>
<br>
3D Object-->Cube<br><br>
<img width="357" height="316" alt="image" src="https://github.com/user-attachments/assets/61e1bc57-fc93-4186-90f2-9566c1e08839" /><br>
<br>
Attach The MazeCell.cs Script to the Parent ( MazeCell Empty Game Object )<br>
Assign the GameObjects in Inspector respectively<br>
<br>
<img width="670" height="292" alt="image" src="https://github.com/user-attachments/assets/f9ea13ce-ec14-42d9-9b6f-222e403ddb00" /><br>
<br>
-----------------------------------------------------------------------------------------------------------------------<br>
## Values---<X, Y, Z><br>
<br>
Floor<br>
<img width="684" height="225" alt="image" src="https://github.com/user-attachments/assets/ad0bf122-73ac-49b7-87a6-025ce9f6136a" /><br>
LeftWall<br>
<img width="684" height="232" alt="image" src="https://github.com/user-attachments/assets/abf66442-5472-4130-8282-e4af9fe9fce7" /><br>
RightWall<br>
<img width="679" height="235" alt="image" src="https://github.com/user-attachments/assets/67efef88-1909-41f8-a7b8-0e1a4eb68e34" /><br>
FrontWall<br>
<img width="682" height="226" alt="image" src="https://github.com/user-attachments/assets/fa7704f3-c3d8-437f-8f8e-67fb1e9743f8" /><br>
BackWall<br>
<img width="681" height="233" alt="image" src="https://github.com/user-attachments/assets/caa2a759-b409-492a-804c-5c2f9143cf7c" /><br>
UnvisitedBlock<br>
<img width="684" height="227" alt="image" src="https://github.com/user-attachments/assets/de5433ed-4c6b-4670-87cc-2d9bc1d8e0b0" /><br>


-----------------------------------------------------------------------------------------------------------------------<br>
<br><pre>
MazeCell
│
├── Floor
├── LeftWall
├── RightWall
├── FrontWall
├── BackWall
└── UnvisitedBlock</pre>
<br>
<img width="557" height="506" alt="image" src="https://github.com/user-attachments/assets/2332dddb-b734-4597-8398-90626a83fdb3" /><br>

It should look something like this (above diagram)<br>
Create a prefab of this and delete this from hierarchy<br>
<br>
<img width="177" height="181" alt="image" src="https://github.com/user-attachments/assets/c8fc262b-a560-4763-a97d-a277d304e094" /><br>
<br>
<img width="380" height="184" alt="image" src="https://github.com/user-attachments/assets/dedf15d0-d120-473d-95eb-7e0c92a9d15e" /><br> didn't use yellow<br>
<br>
Add Materials to the wall & floor as you like...... Add a bright red color material to the UnvisitedBlock as it will indicate which part of the maze is visited or not <br>( in code we check it using visit(), it disables the red colored UnvisitedBlock to show that the map has generated perfectly, if you see the red blocks in map then the maze did not generate in a healthy way).<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Some Space to make the md look clean<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.<br>
.<br>
###################################################################################################<br>
<br>
<img width="353" height="179" alt="image" src="https://github.com/user-attachments/assets/9d7e046a-f7c8-434c-8ed6-3283569ac079" /><br>
<br>
Create a Empty Game Object named MazeGenerator<br>
Attach the MazeGenerator.cs<br>
Assign the MazeCell Prefab in Cell Prefab<br>
<br>
<img width="682" height="213" alt="image" src="https://github.com/user-attachments/assets/31e15956-8301-448f-afe2-098b93706a40" />
<br>
Adjust the view and lighting according to you and press play <br>
## viola! You now have a maze of yours <br>
<br>
<img width="799" height="771" alt="image" src="https://github.com/user-attachments/assets/b34c2408-da4f-438b-a42c-a39a5c7f9b24" />

## give it a star thx for coming here
