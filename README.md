# WEM_23

### Members 

* William Alejandro Pabon Guerrero/ID: 225366
* Miguel Calad Posada/ID: 350013               
* Emmanuel Echeverri Sepulveda/ID: 448007 


### Project Idea




### Vision

We are looking to do an interactive system that provide to our posible users an space where they can play with their sorrunding to experience the tradional rhytms and music of our country.


### Interest

We want to develop a loopstation that would allow people to create beats on a 4 times compass


### Proto 1.0: 
We made an arduino system with a buzzer to use it like a piano, the mini piano works but the idea changed to use a Leap Motion, the code still works
![Diagrama-Piano-Electrico-1024x463](https://user-images.githubusercontent.com/84156615/217916693-bf6f049f-c5fc-4a95-85df-6d70629816f7.png)
>Code.INO in the archives of the Git

-https://www.youtube.com/watch?v=hgfqUaslW6o-

### Proto 1.1: 
We implement de Leap motion as a sensor to use in the experience of the music creation, the Leap Motion have some problems maping the hands in some position that we need but in general, its the perfect tool for the job, the next step its to build the interface in Unity to make it workfit at all, in this case to make a functional digital piano midi and the compass.


![image](https://user-images.githubusercontent.com/84156615/219401970-f5958865-ae6d-4759-8a82-c29f8cc524c7.png)

![image](https://user-images.githubusercontent.com/84156615/219402063-0894ddfa-4240-420b-bc90-796a776a990c.png)

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Piano_test1.png)

### Proto 1.2: 
The integration of the piano and the Leap motion was a hard step in the progress, the piano system have some errors because the leap motion have some trobbles trancking the hands and the piano just can play a Note one by one, if two notes are pushed at the same time the piano doesnt play anything, one solutions its to put a multi audio device in the unity, in theory all the piano sounds are in the same audio line so if we devide it, the sounds will play individualy, if that doesnt work, a code especifing the audio system outputs will be need it.

![image](https://user-images.githubusercontent.com/84156615/220967471-6f5b3151-217d-4cb7-bcb7-1c7ff0ad0983.png)

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Drums_test1.png)
